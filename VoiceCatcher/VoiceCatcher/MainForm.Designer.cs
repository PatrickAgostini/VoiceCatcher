/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 19:27
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Drawing;
namespace VoiceCatcher
{		
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.lblPatientID = new System.Windows.Forms.Label();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.lblGender = new System.Windows.Forms.Label();
			this.lblSurnameTitl = new System.Windows.Forms.Label();
			this.lblNameTitl = new System.Windows.Forms.Label();
			this.lblPatientIDTitl = new System.Windows.Forms.Label();
			this.lblGenderTitl = new System.Windows.Forms.Label();
			this.lblBirthdayTitl = new System.Windows.Forms.Label();
			this.patDataPanel = new System.Windows.Forms.GroupBox();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prePost = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.menuData = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.germanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.recDataPanel = new System.Windows.Forms.GroupBox();
			this.mainPlay_btn = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.post_rb = new System.Windows.Forms.RadioButton();
			this.pre_rb = new System.Windows.Forms.RadioButton();
			this.rec_btn = new System.Windows.Forms.Button();
			this.save_btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.back_btn = new System.Windows.Forms.Button();
			this.forward_btn = new System.Windows.Forms.Button();
			this.delete_btn = new System.Windows.Forms.Button();
			this.mainTab = new System.Windows.Forms.TabControl();
			this.pureToneRecTab = new System.Windows.Forms.TabPage();
			this.viewBar = new System.Windows.Forms.PictureBox();
			this.textRecTab = new System.Windows.Forms.TabPage();
			this.readTextBox = new System.Windows.Forms.RichTextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.freqLbl = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.patDataPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.recDataPanel.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.mainTab.SuspendLayout();
			this.pureToneRecTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.viewBar)).BeginInit();
			this.textRecTab.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.25137F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.74863F));
			this.tableLayoutPanel1.Controls.Add(this.lblSurname, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblName, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblPatientID, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblBirthday, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.lblGender, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblSurnameTitl, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblNameTitl, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.lblPatientIDTitl, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblGenderTitl, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblBirthdayTitl, 0, 3);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 27);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 5;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(223, 98);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// lblSurname
			// 
			this.lblSurname.Location = new System.Drawing.Point(88, 0);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(132, 19);
			this.lblSurname.TabIndex = 7;
			this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(88, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(132, 19);
			this.lblName.TabIndex = 4;
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPatientID
			// 
			this.lblPatientID.Location = new System.Drawing.Point(88, 38);
			this.lblPatientID.Name = "lblPatientID";
			this.lblPatientID.Size = new System.Drawing.Size(132, 19);
			this.lblPatientID.TabIndex = 8;
			this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBirthday
			// 
			this.lblBirthday.Location = new System.Drawing.Point(88, 58);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(132, 19);
			this.lblBirthday.TabIndex = 5;
			this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGender
			// 
			this.lblGender.Location = new System.Drawing.Point(88, 78);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(132, 19);
			this.lblGender.TabIndex = 6;
			this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSurnameTitl
			// 
			this.lblSurnameTitl.Location = new System.Drawing.Point(3, 0);
			this.lblSurnameTitl.Name = "lblSurnameTitl";
			this.lblSurnameTitl.Size = new System.Drawing.Size(79, 19);
			this.lblSurnameTitl.TabIndex = 2;
			this.lblSurnameTitl.Text = "Surname:";
			this.lblSurnameTitl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblNameTitl
			// 
			this.lblNameTitl.Location = new System.Drawing.Point(3, 19);
			this.lblNameTitl.Name = "lblNameTitl";
			this.lblNameTitl.Size = new System.Drawing.Size(79, 19);
			this.lblNameTitl.TabIndex = 0;
			this.lblNameTitl.Text = "Name:";
			this.lblNameTitl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblPatientIDTitl
			// 
			this.lblPatientIDTitl.Location = new System.Drawing.Point(3, 38);
			this.lblPatientIDTitl.Name = "lblPatientIDTitl";
			this.lblPatientIDTitl.Size = new System.Drawing.Size(79, 19);
			this.lblPatientIDTitl.TabIndex = 3;
			this.lblPatientIDTitl.Text = "Patient ID:";
			this.lblPatientIDTitl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGenderTitl
			// 
			this.lblGenderTitl.Location = new System.Drawing.Point(3, 78);
			this.lblGenderTitl.Name = "lblGenderTitl";
			this.lblGenderTitl.Size = new System.Drawing.Size(79, 20);
			this.lblGenderTitl.TabIndex = 2;
			this.lblGenderTitl.Text = "Gender:";
			this.lblGenderTitl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblBirthdayTitl
			// 
			this.lblBirthdayTitl.Location = new System.Drawing.Point(3, 58);
			this.lblBirthdayTitl.Name = "lblBirthdayTitl";
			this.lblBirthdayTitl.Size = new System.Drawing.Size(79, 19);
			this.lblBirthdayTitl.TabIndex = 2;
			this.lblBirthdayTitl.Text = "Birthday:";
			this.lblBirthdayTitl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// patDataPanel
			// 
			this.patDataPanel.Controls.Add(this.tableLayoutPanel1);
			this.patDataPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patDataPanel.Location = new System.Drawing.Point(3, 17);
			this.patDataPanel.Name = "patDataPanel";
			this.patDataPanel.Padding = new System.Windows.Forms.Padding(5, 3, 3, 3);
			this.patDataPanel.Size = new System.Drawing.Size(260, 140);
			this.patDataPanel.TabIndex = 0;
			this.patDataPanel.TabStop = false;
			this.patDataPanel.Text = "Patient Data";
			// 
			// dataGrid
			// 
			this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.type,
									this.date,
									this.prePost});
			this.dataGrid.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGrid.Location = new System.Drawing.Point(6, 21);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(248, 215);
			this.dataGrid.TabIndex = 1;
			// 
			// type
			// 
			this.type.FillWeight = 60F;
			this.type.Frozen = true;
			this.type.HeaderText = "Type";
			this.type.Name = "type";
			this.type.ReadOnly = true;
			this.type.Width = 70;
			// 
			// date
			// 
			this.date.FillWeight = 50F;
			this.date.Frozen = true;
			this.date.HeaderText = "Date";
			this.date.Name = "date";
			this.date.ReadOnly = true;
			this.date.Width = 70;
			// 
			// prePost
			// 
			this.prePost.FillWeight = 50F;
			this.prePost.Frozen = true;
			this.prePost.HeaderText = "Pre/Post";
			this.prePost.Name = "prePost";
			this.prePost.ReadOnly = true;
			this.prePost.Width = 70;
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Honeydew;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.menuData,
									this.menuSettings});
			this.menuStrip1.Location = new System.Drawing.Point(3, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(715, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// menuData
			// 
			this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.newToolStripMenuItem,
									this.loadToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.menuData.Name = "menuData";
			this.menuData.Size = new System.Drawing.Size(43, 20);
			this.menuData.Text = "Data";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.newToolStripMenuItem.Text = "New...";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItemClick);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.loadToolStripMenuItem.Text = "Load";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItemClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// menuSettings
			// 
			this.menuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.languageToolStripMenuItem});
			this.menuSettings.Name = "menuSettings";
			this.menuSettings.Size = new System.Drawing.Size(61, 20);
			this.menuSettings.Text = "Settings";
			// 
			// languageToolStripMenuItem
			// 
			this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.englishToolStripMenuItem,
									this.germanToolStripMenuItem});
			this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
			this.languageToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.languageToolStripMenuItem.Text = "Language";
			// 
			// englishToolStripMenuItem
			// 
			this.englishToolStripMenuItem.Checked = true;
			this.englishToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
			this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
			this.englishToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.englishToolStripMenuItem.Text = "English";
			this.englishToolStripMenuItem.Click += new System.EventHandler(this.EnglishToolStripMenuItemClick);
			// 
			// germanToolStripMenuItem
			// 
			this.germanToolStripMenuItem.Name = "germanToolStripMenuItem";
			this.germanToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
			this.germanToolStripMenuItem.Text = "Deutsch";
			this.germanToolStripMenuItem.Click += new System.EventHandler(this.GermanToolStripMenuItemClick);
			// 
			// recDataPanel
			// 
			this.recDataPanel.Controls.Add(this.dataGrid);
			this.recDataPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.recDataPanel.Location = new System.Drawing.Point(3, 176);
			this.recDataPanel.Name = "recDataPanel";
			this.recDataPanel.Size = new System.Drawing.Size(260, 242);
			this.recDataPanel.TabIndex = 0;
			this.recDataPanel.TabStop = false;
			this.recDataPanel.Text = "Recordings";
			// 
			// mainPlay_btn
			// 
			this.mainPlay_btn.Image = ((System.Drawing.Image)(resources.GetObject("mainPlay_btn.Image")));
			this.mainPlay_btn.Location = new System.Drawing.Point(44, 5);
			this.mainPlay_btn.Name = "mainPlay_btn";
			this.mainPlay_btn.Size = new System.Drawing.Size(35, 35);
			this.mainPlay_btn.TabIndex = 5;
			this.mainPlay_btn.UseVisualStyleBackColor = true;
			this.mainPlay_btn.Click += new System.EventHandler(this.MainPlay_btnClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.Location = new System.Drawing.Point(3, 22);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.patDataPanel);
			this.splitContainer1.Panel1.Controls.Add(this.recDataPanel);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(715, 450);
			this.splitContainer1.SplitterDistance = 275;
			this.splitContainer1.TabIndex = 4;
			// 
			// splitContainer2
			// 
			this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.mainTab);
			this.splitContainer2.Size = new System.Drawing.Size(436, 450);
			this.splitContainer2.SplitterDistance = 72;
			this.splitContainer2.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel2);
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(3, 1);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(426, 64);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Control";
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.post_rb);
			this.panel2.Controls.Add(this.pre_rb);
			this.panel2.Controls.Add(this.rec_btn);
			this.panel2.Controls.Add(this.save_btn);
			this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel2.Location = new System.Drawing.Point(198, 16);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(210, 46);
			this.panel2.TabIndex = 8;
			// 
			// post_rb
			// 
			this.post_rb.Location = new System.Drawing.Point(153, 10);
			this.post_rb.Name = "post_rb";
			this.post_rb.Size = new System.Drawing.Size(52, 24);
			this.post_rb.TabIndex = 9;
			this.post_rb.TabStop = true;
			this.post_rb.Text = "Post";
			this.post_rb.UseVisualStyleBackColor = true;
			// 
			// pre_rb
			// 
			this.pre_rb.Location = new System.Drawing.Point(99, 10);
			this.pre_rb.Name = "pre_rb";
			this.pre_rb.Size = new System.Drawing.Size(49, 24);
			this.pre_rb.TabIndex = 8;
			this.pre_rb.TabStop = true;
			this.pre_rb.Text = "Pre";
			this.pre_rb.UseVisualStyleBackColor = true;
			// 
			// rec_btn
			// 
			this.rec_btn.Image = ((System.Drawing.Image)(resources.GetObject("rec_btn.Image")));
			this.rec_btn.Location = new System.Drawing.Point(7, 5);
			this.rec_btn.Name = "rec_btn";
			this.rec_btn.Size = new System.Drawing.Size(35, 35);
			this.rec_btn.TabIndex = 7;
			this.rec_btn.UseVisualStyleBackColor = true;
			this.rec_btn.Click += new System.EventHandler(this.Rec_btnClick);
			// 
			// save_btn
			// 
			this.save_btn.Image = ((System.Drawing.Image)(resources.GetObject("save_btn.Image")));
			this.save_btn.Location = new System.Drawing.Point(48, 5);
			this.save_btn.Name = "save_btn";
			this.save_btn.Size = new System.Drawing.Size(35, 35);
			this.save_btn.TabIndex = 6;
			this.save_btn.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.back_btn);
			this.panel1.Controls.Add(this.forward_btn);
			this.panel1.Controls.Add(this.delete_btn);
			this.panel1.Controls.Add(this.mainPlay_btn);
			this.panel1.Location = new System.Drawing.Point(9, 16);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
			this.panel1.Size = new System.Drawing.Size(165, 46);
			this.panel1.TabIndex = 6;
			// 
			// back_btn
			// 
			this.back_btn.Image = ((System.Drawing.Image)(resources.GetObject("back_btn.Image")));
			this.back_btn.Location = new System.Drawing.Point(3, 5);
			this.back_btn.Name = "back_btn";
			this.back_btn.Size = new System.Drawing.Size(35, 35);
			this.back_btn.TabIndex = 10;
			this.back_btn.UseVisualStyleBackColor = true;
			// 
			// forward_btn
			// 
			this.forward_btn.Image = ((System.Drawing.Image)(resources.GetObject("forward_btn.Image")));
			this.forward_btn.Location = new System.Drawing.Point(85, 5);
			this.forward_btn.Name = "forward_btn";
			this.forward_btn.Size = new System.Drawing.Size(35, 35);
			this.forward_btn.TabIndex = 9;
			this.forward_btn.UseVisualStyleBackColor = true;
			// 
			// delete_btn
			// 
			this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
			this.delete_btn.Location = new System.Drawing.Point(126, 5);
			this.delete_btn.Name = "delete_btn";
			this.delete_btn.Size = new System.Drawing.Size(35, 35);
			this.delete_btn.TabIndex = 8;
			this.delete_btn.UseVisualStyleBackColor = true;
			// 
			// mainTab
			// 
			this.mainTab.Controls.Add(this.pureToneRecTab);
			this.mainTab.Controls.Add(this.textRecTab);
			this.mainTab.Location = new System.Drawing.Point(3, 3);
			this.mainTab.Name = "mainTab";
			this.mainTab.SelectedIndex = 0;
			this.mainTab.Size = new System.Drawing.Size(428, 364);
			this.mainTab.TabIndex = 0;
			// 
			// pureToneRecTab
			// 
			this.pureToneRecTab.BackColor = System.Drawing.Color.Honeydew;
			this.pureToneRecTab.Controls.Add(this.panel3);
			this.pureToneRecTab.Location = new System.Drawing.Point(4, 22);
			this.pureToneRecTab.Name = "pureToneRecTab";
			this.pureToneRecTab.Padding = new System.Windows.Forms.Padding(3);
			this.pureToneRecTab.Size = new System.Drawing.Size(420, 338);
			this.pureToneRecTab.TabIndex = 0;
			this.pureToneRecTab.Text = "Pure Tone Recording";
			// 
			// viewBar
			// 
			this.viewBar.BackColor = System.Drawing.Color.Transparent;
			this.viewBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.viewBar.Location = new System.Drawing.Point(24, 167);
			this.viewBar.Margin = new System.Windows.Forms.Padding(0);
			this.viewBar.Name = "viewBar";
			this.viewBar.Size = new System.Drawing.Size(250, 50);
			this.viewBar.TabIndex = 0;
			this.viewBar.TabStop = false;
			// 
			// textRecTab
			// 
			this.textRecTab.BackColor = System.Drawing.Color.Honeydew;
			this.textRecTab.Controls.Add(this.readTextBox);
			this.textRecTab.Location = new System.Drawing.Point(4, 22);
			this.textRecTab.Name = "textRecTab";
			this.textRecTab.Padding = new System.Windows.Forms.Padding(3);
			this.textRecTab.Size = new System.Drawing.Size(420, 338);
			this.textRecTab.TabIndex = 1;
			this.textRecTab.Text = "Text Recording";
			// 
			// readTextBox
			// 
			this.readTextBox.Location = new System.Drawing.Point(0, 0);
			this.readTextBox.Name = "readTextBox";
			this.readTextBox.Size = new System.Drawing.Size(422, 338);
			this.readTextBox.TabIndex = 0;
			this.readTextBox.Text = "";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.freqLbl);
			this.panel3.Controls.Add(this.viewBar);
			this.panel3.Location = new System.Drawing.Point(62, 45);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(300, 254);
			this.panel3.TabIndex = 1;
			// 
			// freqLbl
			// 
			this.freqLbl.BackColor = System.Drawing.Color.White;
			this.freqLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.freqLbl.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.freqLbl.ForeColor = System.Drawing.Color.Black;
			this.freqLbl.Location = new System.Drawing.Point(70, 47);
			this.freqLbl.Name = "freqLbl";
			this.freqLbl.Size = new System.Drawing.Size(150, 50);
			this.freqLbl.TabIndex = 1;
			this.freqLbl.Text = "0 Hz";
			this.freqLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.ClientSize = new System.Drawing.Size(721, 477);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.Text = "Voice Catcher";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.patDataPanel.ResumeLayout(false);
			this.patDataPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.recDataPanel.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.mainTab.ResumeLayout(false);
			this.pureToneRecTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.viewBar)).EndInit();
			this.textRecTab.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label freqLbl;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.PictureBox viewBar;
		private System.Windows.Forms.RichTextBox readTextBox;
		private System.Windows.Forms.TabPage textRecTab;
		private System.Windows.Forms.TabPage pureToneRecTab;
		private System.Windows.Forms.TabControl mainTab;
		private System.Windows.Forms.Button forward_btn;
		private System.Windows.Forms.Button back_btn;
		private System.Windows.Forms.RadioButton pre_rb;
		private System.Windows.Forms.RadioButton post_rb;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.Button delete_btn;
		private System.Windows.Forms.Button save_btn;
		private System.Windows.Forms.Button rec_btn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button mainPlay_btn;
		private System.Windows.Forms.GroupBox recDataPanel;
		private System.Windows.Forms.DataGridViewTextBoxColumn prePost;
		private System.Windows.Forms.DataGridViewTextBoxColumn date;
		private System.Windows.Forms.DataGridViewTextBoxColumn type;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.GroupBox patDataPanel;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.Label lblPatientID;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblSurname;
		private System.Windows.Forms.Label lblPatientIDTitl;
		private System.Windows.Forms.ToolStripMenuItem germanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuSettings;
		private System.Windows.Forms.ToolStripMenuItem menuData;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lblGenderTitl;
		private System.Windows.Forms.Label lblSurnameTitl;
		private System.Windows.Forms.Label lblBirthdayTitl;
		private System.Windows.Forms.Label lblNameTitl;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
