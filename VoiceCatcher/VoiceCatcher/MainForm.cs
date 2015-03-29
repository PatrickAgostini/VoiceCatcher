/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 19:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
using System.Text;

namespace VoiceCatcher
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	/// 
	
	public partial class MainForm : Form
	{
		
		public String  language = "English";
		public Patient currentPatient;
		public ResourceManager resources;
		public DatabaseHelper dbHelper;
		public AudioInterface AI;
		
		bool recordingFlag = false;
		bool isPlaying     = false;
		bool isRecording   = false;
		
		int cursorPos  = 115;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			this.resources = getLanguageResources(this.language);
			this.dbHelper  = new DatabaseHelper();
			this.AI        = new AudioInterface(this.setVUMeter, this.freq);
			InitializeComponent();
			initViewBar(this.cursorPos);
			//this.vuMeter.LevelMax = 50;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void EnglishToolStripMenuItemClick(object sender, EventArgs e)
		{
			SwitchLanguage("English");
			this.englishToolStripMenuItem.Checked = true;
			this.germanToolStripMenuItem.Checked = false;
			this.language = "English";
		}
		
		
		void GermanToolStripMenuItemClick(object sender, EventArgs e)
		{
			SwitchLanguage("German");
			this.englishToolStripMenuItem.Checked = false;
			this.germanToolStripMenuItem.Checked = true;
			this.language = "German";
		}
		void SwitchLanguage(String lang)
		{
			this.resources					= getLanguageResources(lang);
			this.lblBirthdayTitl.Text 		= this.resources.GetString("lblBirthday");
			this.lblGenderTitl.Text			= this.resources.GetString("lblGender");
			this.lblNameTitl.Text 			= this.resources.GetString("lblName");
			this.lblPatientIDTitl.Text 		= this.resources.GetString("lblPatientId");
			this.lblSurnameTitl.Text 		= this.resources.GetString("lblSurname");
			this.patDataPanel.Text 	    	= this.resources.GetString("titlPatData");
			this.menuSettings.Text     		= this.resources.GetString("settings");
			this.menuData.Text    			= this.resources.GetString("data");
			this.loadToolStripMenuItem.Text	= this.resources.GetString("open");
			this.newToolStripMenuItem.Text	= this.resources.GetString("new");
			this.exitToolStripMenuItem.Text	= this.resources.GetString("exit");
			String s = this.resources.GetString("textNWnSun");
			//this.nwTextBox.AppendText(s);
		}
		
		void LoadToolStripMenuItemClick(object sender, EventArgs e)
		{
			using( DataSelectDialog dialog = new DataSelectDialog(this.language, this) )
			{
				DialogResult result = dialog.ShowDialog();
			}
		}
		
		void NewToolStripMenuItemClick(object sender, EventArgs e)
		{
			using( AddPatientDialog dialog = new AddPatientDialog(this.language, this) )
			{
				DialogResult result = dialog.ShowDialog();
			}
		}
		
		void ExitToolStripMenuItemClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void UpDatePatInfo()
		{
			this.lblBirthday.Text 	= this.currentPatient.Birthday;
			this.lblGender.Text		= this.currentPatient.Gender;
			this.lblName.Text 		= this.currentPatient.Name;
			this.lblPatientID.Text 	= this.currentPatient.PatientID;
			this.lblSurname.Text 	= this.currentPatient.Surname;
		}
		
		public void setCurrentPatient(String Name, String Surname, String PatientId, String Birthday, String Gender)
		{
			if (Name == null)
				throw new ArgumentNullException("Name");
			this.currentPatient.Name = Name;
			this.currentPatient.Surname = Surname;
			this.currentPatient.Birthday = Birthday;
			this.currentPatient.PatientID = PatientId;
			this.currentPatient.Gender		= Gender;
		}
		
		public ResourceManager getLanguageResources(String lang)
		{
			Assembly a = Assembly.Load("VoiceCatcher");
			ResourceManager resources;
			if(lang.Equals("English"))
			{
				resources = new ResourceManager("VoiceCatcher.Language.English", a);
			}
			else
			{
				resources = new ResourceManager("VoiceCatcher.Language.German", a);
			}
			
			return resources;
		}
		
		public void setVUMeter(int Level)
		{
			//this.vuMeter.Level = Level;
			Random rnd = new Random();
			
			this.initViewBar(this.cursorPos+rnd.Next(-100,100));
			
		}
		public void freq(float f)
		{
			this.freqLbl.Text = f + " Hz";
		}
		
		void ToneRecStart_btnClick(object sender, EventArgs e)
		{
			if(this.recordingFlag)
			{
				this.recordingFlag = false;
				this.AI.stopRecording();
				this.AI.saveRecording("Temp1234.wav");
			}
			else
			{
				this.recordingFlag = true;
				this.AI.startRecording(1, 3);
			}
		}
		
		void MainPlay_btnClick(object sender, EventArgs e)
		{
			this.isPlaying = togglePlayButton(this.mainPlay_btn, this.isPlaying);		
		}
		
		bool togglePlayButton(System.Windows.Forms.Button button, bool state)
		{
			if(state)
			{
				button.Image = ((System.Drawing.Image)(this.resources.GetObject("ic_play")));
				return false;
			}
			else
			{
				button.Image = ((System.Drawing.Image)(this.resources.GetObject("ic_stop")));
				return true;
			}
		}
		bool toggleRecButton(System.Windows.Forms.Button button, bool state)
		{
			if(state)
			{
				button.Image = ((System.Drawing.Image)(this.resources.GetObject("ic_rec")));
				return false;
			}
			else
			{
				button.Image = ((System.Drawing.Image)(this.resources.GetObject("ic_pause")));
				return true;
			}
		}
		
		void Rec_btnClick(object sender, EventArgs e)
		{
			this.isRecording = toggleRecButton(this.rec_btn, this.isRecording);
		}
		
		public static Image resizeImage(Image imgToResize, Size size)
		{
			return (Image)(new Bitmap(imgToResize, size));
		}
		
		void initViewBar(int pos)
		{			
			Bitmap combi = new Bitmap(250,50);
			Graphics g = Graphics.FromImage(combi);
			g.DrawImage(resizeImage((System.Drawing.Image)this.resources.GetObject("viewbar_bar"), new Size(250,50)), 0,0);
			g.DrawImage(resizeImage((System.Drawing.Image)this.resources.GetObject("viewbar_cursor"), new Size(20,50)), pos,0);
			this.viewBar.Image = combi;
		}
	}
}
