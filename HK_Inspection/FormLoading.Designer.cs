namespace HK_Inspection
{
    partial class FormLoading
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
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbSelectModel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cbModelList = new System.Windows.Forms.ComboBox();
            this.lbReleasedDate = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.progressBarStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Brown;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(360, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(40, 40);
            this.btnExit.TabIndex = 88;
            this.btnExit.Text = "❌";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(50, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 43);
            this.label1.TabIndex = 89;
            this.label1.Text = "VISION SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelectModel
            // 
            this.lbSelectModel.AutoSize = true;
            this.lbSelectModel.BackColor = System.Drawing.SystemColors.Control;
            this.lbSelectModel.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectModel.ForeColor = System.Drawing.Color.DimGray;
            this.lbSelectModel.Location = new System.Drawing.Point(38, 204);
            this.lbSelectModel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSelectModel.Name = "lbSelectModel";
            this.lbSelectModel.Size = new System.Drawing.Size(149, 24);
            this.lbSelectModel.TabIndex = 90;
            this.lbSelectModel.Text = "SELECT MODEL";
            this.lbSelectModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Orange;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(212, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(81, 32);
            this.btnStart.TabIndex = 92;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // cbModelList
            // 
            this.cbModelList.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModelList.FormattingEnabled = true;
            this.cbModelList.Location = new System.Drawing.Point(42, 241);
            this.cbModelList.Name = "cbModelList";
            this.cbModelList.Size = new System.Drawing.Size(160, 32);
            this.cbModelList.TabIndex = 91;
            this.cbModelList.Text = "MODEL";
            // 
            // lbReleasedDate
            // 
            this.lbReleasedDate.AutoSize = true;
            this.lbReleasedDate.BackColor = System.Drawing.SystemColors.Control;
            this.lbReleasedDate.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReleasedDate.ForeColor = System.Drawing.Color.DimGray;
            this.lbReleasedDate.Location = new System.Drawing.Point(38, 414);
            this.lbReleasedDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbReleasedDate.Name = "lbReleasedDate";
            this.lbReleasedDate.Size = new System.Drawing.Size(179, 19);
            this.lbReleasedDate.TabIndex = 100;
            this.lbReleasedDate.Text = "Released on 06/12/2026";
            this.lbReleasedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.SystemColors.Control;
            this.lbVersion.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbVersion.Location = new System.Drawing.Point(208, 386);
            this.lbVersion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(42, 24);
            this.lbVersion.TabIndex = 99;
            this.lbVersion.Text = "v1.0";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(38, 386);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 98;
            this.label3.Text = "BIGSTONE VISION";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(209, 454);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 17);
            this.label9.TabIndex = 97;
            this.label9.Text = "thuanducdo.vn@gmail.com";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(39, 454);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 17);
            this.label8.TabIndex = 96;
            this.label8.Text = "please submit an email to";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(39, 437);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 17);
            this.label7.TabIndex = 95;
            this.label7.Text = "To obtain access this software or any question";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lbStatus.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lbStatus.Location = new System.Drawing.Point(38, 301);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(251, 28);
            this.lbStatus.TabIndex = 93;
            this.lbStatus.Text = "LOADING 0%";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // progressBarStatus
            // 
            this.progressBarStatus.Location = new System.Drawing.Point(42, 332);
            this.progressBarStatus.Name = "progressBarStatus";
            this.progressBarStatus.Size = new System.Drawing.Size(247, 30);
            this.progressBarStatus.TabIndex = 94;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 480);
            this.Controls.Add(this.lbReleasedDate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.progressBarStatus);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cbModelList);
            this.Controls.Add(this.lbSelectModel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.Text = "FormLoading";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSelectModel;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbModelList;
        private System.Windows.Forms.Label lbReleasedDate;
        public System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.ProgressBar progressBarStatus;
    }
}