/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Text;

namespace VoiceCatcher
{
	/// <summary>
	/// Description of DataSelectDialog.
	/// </summary>
	public partial class DataSelectDialog : Form
	{

		MainForm mainForm;
		ResourceManager resources;
		
		public DataSelectDialog(String language, MainForm mainForm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.mainForm  = mainForm;
			this.resources = mainForm.resources; 
			InitializeComponent();
			SwitchLanguage(language);
			SetRegistredUser();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void SwitchLanguage(String lang)
		{			
			this.patientIDPanel.Text = this.resources.GetString("registredPatients");
			this.btn_Cancel.Text     = this.resources.GetString("cancel");
			this.btn_Load.Text       = this.resources.GetString("open");
			
			DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
			DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
        	DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();
        	DataGridViewTextBoxColumn col5 = new DataGridViewTextBoxColumn();
       		col1.HeaderText = this.resources.GetString("clName");
        	col1.Name = "name";
        	col2.HeaderText = this.resources.GetString("clSurname");
        	col2.Name = "surname";
        	col3.HeaderText = this.resources.GetString("clBirthday");
        	col3.Name = "birthday";
        	col4.HeaderText = this.resources.GetString("clPatient_Id");
        	col4.Name = "patient_Id";
        	col5.HeaderText = this.resources.GetString("clGender");
        	col5.Name = "gender";

            registredPatientsGrid.Columns.AddRange(new DataGridViewColumn[] {col1,col2,col3,col4,col5});
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
		
		void SetRegistredUser()
		{
			this.mainForm.dbHelper.setAllUsers(registredPatientsGrid);
		}
		
		void Btn_LoadClick(object sender, EventArgs e)
		{
			
			int i = this.registredPatientsGrid.SelectedCells[0].RowIndex;
			this.mainForm.setCurrentPatient(this.registredPatientsGrid.Rows[i].Cells[4].Value.ToString(),
			this.registredPatientsGrid.Rows[i].Cells[0].Value.ToString(),
			this.registredPatientsGrid.Rows[i].Cells[1].Value.ToString(),
			this.registredPatientsGrid.Rows[i].Cells[2].Value.ToString(),
			this.registredPatientsGrid.Rows[i].Cells[3].Value.ToString());
			this.mainForm.UpDatePatInfo();
			this.Close();
		}
	}
}
