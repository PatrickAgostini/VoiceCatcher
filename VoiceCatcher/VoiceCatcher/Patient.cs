/*
 * Created by SharpDevelop.
 * User: HO-Audio
 * Date: 19.03.2015
 * Time: 12:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace VoiceCatcher
{
	/// <summary>
	/// Description of Structs.
	/// </summary>
	public struct Patient
	{
		public string Name;
		public string Surname;
		public string Birthday;
		public string PatientID;
		public string Gender;
		
		public Patient(String Name, String Surname, String Birthday, String PatientID, String Gender)
		{
			this.Name = Name;
			this.Surname = Surname;
			this.Birthday = Birthday;
			this.PatientID = PatientID;
			this.Gender = Gender;
		}
	}
}
