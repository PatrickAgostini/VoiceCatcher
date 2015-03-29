/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 23:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace VoiceCatcher
{
	partial class AddPatientDialog
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.surnameEdit = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rbFemale = new System.Windows.Forms.RadioButton();
			this.rbMale = new System.Windows.Forms.RadioButton();
			this.lblPatientID = new System.Windows.Forms.Label();
			this.patientIdEdit = new System.Windows.Forms.TextBox();
			this.lblBirthday = new System.Windows.Forms.Label();
			this.birthdayEdit = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.lblSurname = new System.Windows.Forms.Label();
			this.nameEdit = new System.Windows.Forms.TextBox();
			this.lblGender = new System.Windows.Forms.Label();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Create = new System.Windows.Forms.Button();
			this.alreadyExistsError = new System.Windows.Forms.ErrorProvider(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.alreadyExistsError)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
			this.tableLayoutPanel1.Controls.Add(this.surnameEdit, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.lblPatientID, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.patientIdEdit, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.lblBirthday, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.birthdayEdit, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblSurname, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.nameEdit, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.lblGender, 0, 8);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 9;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 242);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// surnameEdit
			// 
			this.surnameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.surnameEdit.Location = new System.Drawing.Point(94, 3);
			this.surnameEdit.Name = "surnameEdit";
			this.surnameEdit.Size = new System.Drawing.Size(175, 26);
			this.surnameEdit.TabIndex = 5;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
			this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.groupBox1.Controls.Add(this.rbFemale);
			this.groupBox1.Controls.Add(this.rbMale);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox1.Location = new System.Drawing.Point(94, 186);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(176, 53);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// rbFemale
			// 
			this.rbFemale.Checked = true;
			this.rbFemale.Location = new System.Drawing.Point(94, 11);
			this.rbFemale.Name = "rbFemale";
			this.rbFemale.Size = new System.Drawing.Size(82, 36);
			this.rbFemale.TabIndex = 0;
			this.rbFemale.TabStop = true;
			this.rbFemale.Text = "Female";
			this.rbFemale.UseVisualStyleBackColor = true;
			this.rbFemale.CheckedChanged += new System.EventHandler(this.RbFemaleCheckedChanged);
			// 
			// rbMale
			// 
			this.rbMale.Location = new System.Drawing.Point(6, 13);
			this.rbMale.Name = "rbMale";
			this.rbMale.Size = new System.Drawing.Size(82, 34);
			this.rbMale.TabIndex = 1;
			this.rbMale.TabStop = true;
			this.rbMale.Text = "Male";
			this.rbMale.UseVisualStyleBackColor = true;
			this.rbMale.CheckedChanged += new System.EventHandler(this.RbMaleCheckedChanged);
			// 
			// lblPatientID
			// 
			this.lblPatientID.Location = new System.Drawing.Point(3, 144);
			this.lblPatientID.Name = "lblPatientID";
			this.lblPatientID.Size = new System.Drawing.Size(84, 29);
			this.lblPatientID.TabIndex = 3;
			this.lblPatientID.Text = "Patient ID:";
			this.lblPatientID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// patientIdEdit
			// 
			this.patientIdEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.patientIdEdit.Location = new System.Drawing.Point(94, 147);
			this.patientIdEdit.Name = "patientIdEdit";
			this.patientIdEdit.Size = new System.Drawing.Size(175, 26);
			this.patientIdEdit.TabIndex = 8;
			// 
			// lblBirthday
			// 
			this.lblBirthday.Location = new System.Drawing.Point(3, 95);
			this.lblBirthday.Name = "lblBirthday";
			this.lblBirthday.Size = new System.Drawing.Size(84, 30);
			this.lblBirthday.TabIndex = 2;
			this.lblBirthday.Text = "Birthday:";
			this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lblBirthday.Click += new System.EventHandler(this.Label3Click);
			// 
			// birthdayEdit
			// 
			this.birthdayEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.birthdayEdit.Location = new System.Drawing.Point(94, 98);
			this.birthdayEdit.Name = "birthdayEdit";
			this.birthdayEdit.Size = new System.Drawing.Size(175, 26);
			this.birthdayEdit.TabIndex = 7;
			// 
			// lblName
			// 
			this.lblName.Location = new System.Drawing.Point(3, 46);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(84, 30);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblSurname
			// 
			this.lblSurname.Location = new System.Drawing.Point(3, 0);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(84, 29);
			this.lblSurname.TabIndex = 0;
			this.lblSurname.Text = "Surname:";
			this.lblSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// nameEdit
			// 
			this.nameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameEdit.Location = new System.Drawing.Point(94, 49);
			this.nameEdit.Name = "nameEdit";
			this.nameEdit.Size = new System.Drawing.Size(175, 26);
			this.nameEdit.TabIndex = 6;
			// 
			// lblGender
			// 
			this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.lblGender.Location = new System.Drawing.Point(3, 198);
			this.lblGender.Name = "lblGender";
			this.lblGender.Size = new System.Drawing.Size(85, 29);
			this.lblGender.TabIndex = 4;
			this.lblGender.Text = "Gender:";
			this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btn_Cancel);
			this.splitContainer1.Panel2.Controls.Add(this.btn_Create);
			this.splitContainer1.Size = new System.Drawing.Size(283, 310);
			this.splitContainer1.SplitterDistance = 255;
			this.splitContainer1.TabIndex = 1;
			this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainer1SplitterMoved);
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(282, 114);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(176, 42);
			this.panel1.TabIndex = 9;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(190, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 34);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Btn_CancelClick);
			// 
			// btn_Create
			// 
			this.btn_Create.Location = new System.Drawing.Point(15, 3);
			this.btn_Create.Name = "btn_Create";
			this.btn_Create.Size = new System.Drawing.Size(75, 34);
			this.btn_Create.TabIndex = 0;
			this.btn_Create.Text = "Create";
			this.btn_Create.UseVisualStyleBackColor = true;
			this.btn_Create.Click += new System.EventHandler(this.Button1Click);
			// 
			// alreadyExistsError
			// 
			this.alreadyExistsError.ContainerControl = this;
			// 
			// AddPatientDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 331);
			this.Controls.Add(this.splitContainer1);
			this.Name = "AddPatientDialog";
			this.Text = "AddPatientDialog";
			this.Load += new System.EventHandler(this.AddPatientDialogLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.alreadyExistsError)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ErrorProvider alreadyExistsError;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_Create;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.RadioButton rbMale;
		private System.Windows.Forms.RadioButton rbFemale;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox nameEdit;
		private System.Windows.Forms.TextBox birthdayEdit;
		private System.Windows.Forms.TextBox patientIdEdit;
		private System.Windows.Forms.TextBox surnameEdit;
		private System.Windows.Forms.Label lblSurname;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblBirthday;
		private System.Windows.Forms.Label lblPatientID;
		private System.Windows.Forms.Label lblGender;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
