
namespace NRIcontact
{
    partial class ProofDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnUpload = new System.Windows.Forms.Button();
            this.txtboxPassportID = new System.Windows.Forms.TextBox();
            this.lblPassportID = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtboxFileName = new System.Windows.Forms.TextBox();
            this.lblAadharNumber = new System.Windows.Forms.Label();
            this.txtboxAadharNumber = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.nRIcontactDataSet2 = new NRIcontact.NRIcontactDataSet2();
            this.tblpictureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_pictureTableAdapter = new NRIcontact.NRIcontactDataSet2TableAdapters.tbl_pictureTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRIcontactDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpictureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(350, 127);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // txtboxPassportID
            // 
            this.txtboxPassportID.Location = new System.Drawing.Point(137, 52);
            this.txtboxPassportID.Name = "txtboxPassportID";
            this.txtboxPassportID.Size = new System.Drawing.Size(100, 20);
            this.txtboxPassportID.TabIndex = 1;
            // 
            // lblPassportID
            // 
            this.lblPassportID.AutoSize = true;
            this.lblPassportID.Location = new System.Drawing.Point(13, 52);
            this.lblPassportID.Name = "lblPassportID";
            this.lblPassportID.Size = new System.Drawing.Size(59, 13);
            this.lblPassportID.TabIndex = 2;
            this.lblPassportID.Text = "PassportID";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(13, 132);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(54, 13);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.Text = "File Name";
            // 
            // txtboxFileName
            // 
            this.txtboxFileName.Location = new System.Drawing.Point(137, 125);
            this.txtboxFileName.Name = "txtboxFileName";
            this.txtboxFileName.ReadOnly = true;
            this.txtboxFileName.Size = new System.Drawing.Size(182, 20);
            this.txtboxFileName.TabIndex = 3;
            // 
            // lblAadharNumber
            // 
            this.lblAadharNumber.AutoSize = true;
            this.lblAadharNumber.Location = new System.Drawing.Point(12, 85);
            this.lblAadharNumber.Name = "lblAadharNumber";
            this.lblAadharNumber.Size = new System.Drawing.Size(81, 13);
            this.lblAadharNumber.TabIndex = 8;
            this.lblAadharNumber.Text = "Aadhar Number";
            // 
            // txtboxAadharNumber
            // 
            this.txtboxAadharNumber.Location = new System.Drawing.Point(137, 82);
            this.txtboxAadharNumber.Name = "txtboxAadharNumber";
            this.txtboxAadharNumber.Size = new System.Drawing.Size(100, 20);
            this.txtboxAadharNumber.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(137, 167);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(182, 127);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 13;
            this.pictureBox.TabStop = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewImageColumn1});
            this.dataGridView.DataSource = this.tblpictureBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(15, 332);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(637, 150);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Proof Details";
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.Purple;
            this.btnReport.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Location = new System.Drawing.Point(137, 488);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(91, 35);
            this.btnReport.TabIndex = 81;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnExit.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(258, 488);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 35);
            this.btnExit.TabIndex = 80;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Teal;
            this.btnLogout.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(376, 488);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 35);
            this.btnLogout.TabIndex = 79;
            this.btnLogout.Text = "log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Fuchsia;
            this.btnBack.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(16, 488);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(91, 35);
            this.btnBack.TabIndex = 82;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nRIcontactDataSet2
            // 
            this.nRIcontactDataSet2.DataSetName = "NRIcontactDataSet2";
            this.nRIcontactDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpictureBindingSource
            // 
            this.tblpictureBindingSource.DataMember = "tbl_picture";
            this.tblpictureBindingSource.DataSource = this.nRIcontactDataSet2;
            // 
            // tbl_pictureTableAdapter
            // 
            this.tbl_pictureTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PassportID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PassportID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "AadharNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "AadharNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "FileName";
            this.dataGridViewTextBoxColumn3.HeaderText = "FileName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // ProofDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 523);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblAadharNumber);
            this.Controls.Add(this.txtboxAadharNumber);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.txtboxFileName);
            this.Controls.Add(this.lblPassportID);
            this.Controls.Add(this.txtboxPassportID);
            this.Controls.Add(this.btnUpload);
            this.Name = "ProofDetails";
            this.Text = "ProofDetails";
            this.Load += new System.EventHandler(this.ProofDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nRIcontactDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpictureBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.TextBox txtboxPassportID;
        private System.Windows.Forms.Label lblPassportID;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.TextBox txtboxFileName;
        private System.Windows.Forms.Label lblAadharNumber;
        private System.Windows.Forms.TextBox txtboxAadharNumber;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aadharNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fileNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private NRIcontact.NRIcontactDataSet2 nRIcontactDataSet2;
        private System.Windows.Forms.BindingSource tblpictureBindingSource;
        private NRIcontact.NRIcontactDataSet2TableAdapters.tbl_pictureTableAdapter tbl_pictureTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}