/*
 * Created by SharpDevelop.
 * User: HO-Audio
 * Date: 19.03.2015
 * Time: 11:00
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SQLite;
using System.IO;
namespace VoiceCatcher
{
	/// <summary>
	/// Description of DatabaseHelper.
	/// </summary>
	public class DatabaseHelper
	{	
	
		public String dbName = "VoiceCatcherDB.db";
		public SQLiteConnection sqlite_conn;
		public SQLiteCommand sqlite_cmd;

		public DatabaseHelper()
		{
			InitDB();
		}
		
		public void InitDB()
		{
			if(!File.Exists(this.dbName))
			{
				this.sqlite_conn = new SQLiteConnection("Data Source=" + this.dbName + ";Version=3;New=True;Compress=True;");

				this.sqlite_conn.Open();

				this.sqlite_cmd = sqlite_conn.CreateCommand();

				this.sqlite_cmd.CommandText = "CREATE TABLE Patient (id integer primary key, Name  varchar(100), Surname  varchar(100), Patient_ID  varchar(100), Birthday varchar(100), Gender varchar(100));";

				this.sqlite_cmd.ExecuteNonQuery();
				
				this.sqlite_cmd.CommandText = "CREATE TABLE Recordings (id integer primary key, Patient_ID  varchar(100), Pre_Post int(1), Type varchar(100), Recording blob);";
				
				this.sqlite_cmd.ExecuteNonQuery();
			}
			else
			{
				this.sqlite_conn = new SQLiteConnection("Data Source=" + this.dbName + ";Version=3;");

				this.sqlite_cmd = sqlite_conn.CreateCommand();

				this.sqlite_conn.Open();
			}
		}
		
		public void OpenConnection()
		{
			this.sqlite_conn = new SQLiteConnection("Data Source=" + this.dbName + ";Version=3;");

			this.sqlite_conn.Open();
		}
		
		public void CloseConnection()
		{
			this.sqlite_conn.Close();
		}
		
		public String InsertNewPatient(String Name, String Surname, String Patient_ID, String Birthday, String Gender)
		{
			if(isNotRegistred(Name, Surname, Patient_ID, Birthday, Gender))
			{
				this.sqlite_cmd.CommandText = String.Format("INSERT INTO Patient (Name, Surname, Birthday, Patient_ID, Gender) values ('{0}', '{1}','{2}','{3}','{4}');",Name, Surname, Birthday, Patient_ID, Gender);
				try {
					this.sqlite_cmd.ExecuteNonQuery();
					return null;
				}
				catch (Exception ex) {
					return ex.Message;
					//throw new Exception(ex.Message);
				}
			}
			else
			{
				return "Exists";
			}
		}
		
		public Boolean isNotRegistred(String Name, String Surname, String PatientID, String Birthday, String Gender)
		{
			this.sqlite_cmd.CommandText = "select * from Patient where Name='"+ Name + "' AND Surname ='"+ Surname + "' AND Birthday='"+ Birthday + "' AND Gender='"+ Gender + "' AND Patient_ID='" + PatientID + "';";
			SQLiteDataReader reader = this.sqlite_cmd.ExecuteReader();
			int i = 0;
			while(reader.Read()) i++;
			if(i>0){
				reader.Close();
				return false;
			}
			reader.Close();
			return true;
		}
		
		public Recordings[] getRecordings(String PatientID)
		{	
            this.sqlite_cmd.CommandText = "SELECT COUNT(*) from Recordings where Patient_ID="+ PatientID + ";"; 			
			SQLiteDataReader reader = this.sqlite_cmd.ExecuteReader();
			reader.Read();
			int count = (int) reader[0];
            this.sqlite_cmd.CommandText = "select * from Recordings where Patient_ID="+ PatientID + ";";
			reader = this.sqlite_cmd.ExecuteReader();
			Recordings[] recs = new Recordings[count];
			int i = 0;
			while(i<count){
				reader.Read();
				recs[i].Type  	  = reader["Type"].ToString();
				recs[i].Pre_Post  = reader["Pre_Post"].ToString();
				recs[i].Recording = (byte[]) reader["Recording"];
				i++;
			}
			reader.Close();
			return recs;
		}
		
		public void setAllUsers(System.Windows.Forms.DataGridView registredPatientsGrid)
		{
			this.sqlite_cmd.CommandText = "SELECT * from Patient;"; 			
			SQLiteDataReader reader = this.sqlite_cmd.ExecuteReader();
			
			while(reader.Read())
			{
				registredPatientsGrid.Rows.Add(reader["name"].ToString(),reader["surname"].ToString(),reader["birthday"].ToString(),reader["patient_ID"].ToString(),reader["gender"].ToString());
			}
			reader.Close();
		}
	}
}
