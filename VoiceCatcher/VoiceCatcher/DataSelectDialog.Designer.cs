/*
 * Created by SharpDevelop.
 * User: Patrick
 * Date: 18/03/2015
 * Time: 23:05
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace VoiceCatcher
{
	partial class DataSelectDialog
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
			this.patientIDPanel = new System.Windows.Forms.GroupBox();
			this.registredPatientsGrid = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.btn_Load = new System.Windows.Forms.Button();
			this.patientIDPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.registredPatientsGrid)).BeginInit();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// patientIDPanel
			// 
			this.patientIDPanel.Controls.Add(this.registredPatientsGrid);
			this.patientIDPanel.Location = new System.Drawing.Point(12, 12);
			this.patientIDPanel.Name = "patientIDPanel";
			this.patientIDPanel.Size = new System.Drawing.Size(522, 200);
			this.patientIDPanel.TabIndex = 1;
			this.patientIDPanel.TabStop = false;
			this.patientIDPanel.Text = "Registred Patients";
			this.patientIDPanel.Enter += new System.EventHandler(this.GroupBox1Enter);
			// 
			// registredPatientsGrid
			// 
			this.registredPatientsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.registredPatientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.registredPatientsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.registredPatientsGrid.Location = new System.Drawing.Point(6, 19);
			this.registredPatientsGrid.Name = "registredPatientsGrid";
			this.registredPatientsGrid.Size = new System.Drawing.Size(510, 198);
			this.registredPatientsGrid.TabIndex = 0;
			this.registredPatientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegistredPatientsGridCellContentClick);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Location = new System.Drawing.Point(12, 12);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btn_Cancel);
			this.splitContainer1.Panel2.Controls.Add(this.btn_Load);
			this.splitContainer1.Size = new System.Drawing.Size(522, 269);
			this.splitContainer1.SplitterDistance = 220;
			this.splitContainer1.TabIndex = 2;
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Location = new System.Drawing.Point(288, 7);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 35);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.Button2Click);
			// 
			// btn_Load
			// 
			this.btn_Load.Location = new System.Drawing.Point(166, 7);
			this.btn_Load.Name = "btn_Load";
			this.btn_Load.Size = new System.Drawing.Size(75, 35);
			this.btn_Load.TabIndex = 0;
			this.btn_Load.Text = "Load";
			this.btn_Load.UseVisualStyleBackColor = true;
			this.btn_Load.Click += new System.EventHandler(this.Btn_LoadClick);
			// 
			// DataSelectDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 295);
			this.Controls.Add(this.patientIDPanel);
			this.Controls.Add(this.splitContainer1);
			this.Name = "DataSelectDialog";
			this.Text = "Select Data";
			this.patientIDPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.registredPatientsGrid)).EndInit();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		public System.Windows.Forms.DataGridView registredPatientsGrid;
		private System.Windows.Forms.Button btn_Load;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox patientIDPanel;
		
		void RegistredPatientsGridCellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			
		}
	}
}
