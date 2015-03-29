/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 23:31
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
	/// Description of AddPatientDialog.
	/// </summary>
	public partial class AddPatientDialog : Form
	{
		String language;
		ResourceManager resources;
		MainForm mainForm;
		DatabaseHelper dbHelper;
		
		public AddPatientDialog(String language, MainForm mainForm)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.language  = language;
			this.resources = mainForm.resources;
			this.mainForm  = mainForm;
			this.dbHelper  = mainForm.dbHelper;
			InitializeComponent();
			SwitchLanguage(language);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}
		
		void AddPatientDialogLoad(object sender, EventArgs e)
		{
			
		}
		
		void Panel2Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void Panel1Paint(object sender, PaintEventArgs e)
		{
			
		}
		
		void SplitContainer2SplitterMoved(object sender, SplitterEventArgs e)
		{
			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			String insertErr = this.dbHelper.InsertNewPatient(this.nameEdit.Text, this.surnameEdit.Text, this.patientIdEdit.Text, this.birthdayEdit.Text, getGender());
			if(insertErr==null)
			{
				this.mainForm.setCurrentPatient(this.nameEdit.Text, this.surnameEdit.Text, this.patientIdEdit.Text, this.birthdayEdit.Text, getGender());
				this.mainForm.UpDatePatInfo();
                this.Close();
			}else
			{
				MessageBox.Show(this.resources.GetString("insertError"), this.resources.GetString("insertErrorTitl"), MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void RbFemaleCheckedChanged(object sender, EventArgs e)
		{
			if(!this.rbMale.Checked)
			{
				this.rbFemale.Checked = true;
			}
			if(this.rbMale.Checked)
			{
				this.rbFemale.Checked = false;
			}
		}
		
		String getGender()
		{
			if(rbFemale.Checked)
			{
				return this.mainForm.resources.GetString("genderFemale");
			}else
			{
				return this.mainForm.resources.GetString("genderMale");
			}
		}
		
		void SwitchLanguage(String lang)
		{
			
			this.lblName.Text        = this.mainForm.resources.GetString("lblName");
			this.lblSurname.Text     = this.mainForm.resources.GetString("lblSurname");
			this.lblBirthday.Text    = this.mainForm.resources.GetString("lblBirthday");
			this.lblPatientID.Text 	 = this.mainForm.resources.GetString("lblPatientId");
			this.btn_Cancel.Text     = this.mainForm.resources.GetString("cancel");
			this.btn_Create.Text     = this.mainForm.resources.GetString("create");
			this.lblGender.Text 	 = this.mainForm.resources.GetString("lblGender");
			this.rbMale.Text 	     = this.mainForm.resources.GetString("genderMale");
			this.rbFemale.Text 	     = this.mainForm.resources.GetString("genderFemale");
		}
		
		
		void RbMaleCheckedChanged(object sender, EventArgs e)
		{
			
		}
		void RbMaleonClick(object sender, EventArgs e)
		{
		
		}
		
		void SplitContainer1SplitterMoved(object sender, SplitterEventArgs e)
		{
			
		}
		
		void Btn_CancelClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void GroupBox1Enter(object sender, EventArgs e)
		{
			
		}
	}
}
