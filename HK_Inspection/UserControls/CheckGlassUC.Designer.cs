namespace HK_Inspection.UserControls
{
    partial class CheckGlassUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbIndex = new System.Windows.Forms.Label();
            this.insRecordDisplayControl1 = new Insnex.Vision2D.Controls.InsRecordDisplayControl();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbResult, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbIndex, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.insRecordDisplayControl1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.42857F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.Location = new System.Drawing.Point(3, 3);
            this.lbResult.Margin = new System.Windows.Forms.Padding(3);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(344, 65);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "Cheking";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndex.Location = new System.Drawing.Point(3, 431);
            this.lbIndex.Margin = new System.Windows.Forms.Padding(3);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(344, 66);
            this.lbIndex.TabIndex = 2;
            this.lbIndex.Text = "Glass*";
            this.lbIndex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // insRecordDisplayControl1
            // 
            this.insRecordDisplayControl1.AutoFitImage = true;
            this.insRecordDisplayControl1.ConfigDisplay3D_Half = 2;
            this.insRecordDisplayControl1.DisplayBackGroundColor = System.Drawing.Color.Empty;
            this.insRecordDisplayControl1.DisplayDrawEnable = true;
            this.insRecordDisplayControl1.DisplayImage = null;
            this.insRecordDisplayControl1.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.insRecordDisplayControl1.Hidden = false;
            this.insRecordDisplayControl1.KeepViewport = false;
            this.insRecordDisplayControl1.Location = new System.Drawing.Point(1, 72);
            this.insRecordDisplayControl1.Margin = new System.Windows.Forms.Padding(1);
            this.insRecordDisplayControl1.MouseMode = Insnex.Vision2D.Core.InsDisplayMouseModeConstants.Pointer;
            this.insRecordDisplayControl1.Name = "insRecordDisplayControl1";
            this.insRecordDisplayControl1.ShowRecordID = 0;
            this.insRecordDisplayControl1.ShowRecordList = true;
            this.insRecordDisplayControl1.ShowStatusBar = false;
            this.insRecordDisplayControl1.Size = new System.Drawing.Size(347, 355);
            this.insRecordDisplayControl1.TabIndex = 3;
            this.insRecordDisplayControl1.DoubleClick += new System.EventHandler(this.recordDisplayDoubleClicked);
            // 
            // CheckGlassUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "CheckGlassUC";
            this.Size = new System.Drawing.Size(350, 500);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbIndex;
        private Insnex.Vision2D.Controls.InsRecordDisplayControl insRecordDisplayControl1;
    }
}
