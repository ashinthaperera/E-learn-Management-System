
namespace ResultAndExam
{
    partial class LecturerExam
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLecExam = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxTimeLimit = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewStudentSubmissions = new System.Windows.Forms.DataGridView();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxFileId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.textBoxStudentId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecExam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentSubmissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Limit";
            // 
            // dataGridViewLecExam
            // 
            this.dataGridViewLecExam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLecExam.Location = new System.Drawing.Point(30, 196);
            this.dataGridViewLecExam.Name = "dataGridViewLecExam";
            this.dataGridViewLecExam.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewLecExam.TabIndex = 4;
            this.dataGridViewLecExam.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewLecExam_DataError);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(286, 196);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(286, 238);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxTimeLimit
            // 
            this.textBoxTimeLimit.Location = new System.Drawing.Point(87, 109);
            this.textBoxTimeLimit.Name = "textBoxTimeLimit";
            this.textBoxTimeLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxTimeLimit.TabIndex = 7;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(286, 284);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Student ID";
            // 
            // dataGridViewStudentSubmissions
            // 
            this.dataGridViewStudentSubmissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentSubmissions.Location = new System.Drawing.Point(30, 390);
            this.dataGridViewStudentSubmissions.Name = "dataGridViewStudentSubmissions";
            this.dataGridViewStudentSubmissions.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewStudentSubmissions.TabIndex = 10;
            this.dataGridViewStudentSubmissions.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewStudentSubmissions_DataError);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(286, 390);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(75, 23);
            this.buttonDownload.TabIndex = 11;
            this.buttonDownload.Text = "Download";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Upload Exam and Time Limit";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFileId
            // 
            this.textBoxFileId.Location = new System.Drawing.Point(87, 63);
            this.textBoxFileId.Name = "textBoxFileId";
            this.textBoxFileId.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileId.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "File ID";
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(139, 160);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(48, 13);
            this.labelFilePath.TabIndex = 15;
            this.labelFilePath.Text = "File Path";
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Location = new System.Drawing.Point(30, 155);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadFile.TabIndex = 16;
            this.buttonUploadFile.Text = "Upload File";
            this.buttonUploadFile.UseVisualStyleBackColor = true;
            this.buttonUploadFile.Click += new System.EventHandler(this.buttonUploadFile_Click);
            // 
            // textBoxStudentId
            // 
            this.textBoxStudentId.Location = new System.Drawing.Point(87, 361);
            this.textBoxStudentId.Name = "textBoxStudentId";
            this.textBoxStudentId.Size = new System.Drawing.Size(100, 20);
            this.textBoxStudentId.TabIndex = 17;
            // 
            // LecturerExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 761);
            this.Controls.Add(this.textBoxStudentId);
            this.Controls.Add(this.buttonUploadFile);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.textBoxFileId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.dataGridViewStudentSubmissions);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxTimeLimit);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewLecExam);
            this.Controls.Add(this.label1);
            this.Name = "LecturerExam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLecExam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentSubmissions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLecExam;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxTimeLimit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewStudentSubmissions;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxFileId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Button buttonUploadFile;
        private System.Windows.Forms.TextBox textBoxStudentId;
    }
}