namespace HK_Inspection
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tLPMain = new System.Windows.Forms.TableLayoutPanel();
            this.tLPHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lbModelSetting = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.itemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.itemHome = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStop = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pbLangENG = new System.Windows.Forms.PictureBox();
            this.pbLangVIE = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lbConnectLED = new System.Windows.Forms.Label();
            this.lbConnectPLC = new System.Windows.Forms.Label();
            this.lbConnectCam1 = new System.Windows.Forms.Label();
            this.lbConnectCam3 = new System.Windows.Forms.Label();
            this.lbConnectCam2 = new System.Windows.Forms.Label();
            this.tLPHome = new System.Windows.Forms.TableLayoutPanel();
            this.tLPResult = new System.Windows.Forms.TableLayoutPanel();
            this.tLPOKNG = new System.Windows.Forms.TableLayoutPanel();
            this.lbNGCount = new System.Windows.Forms.Label();
            this.lbOKCount = new System.Windows.Forms.Label();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlSidePanel = new System.Windows.Forms.Panel();
            this.ckbLogNGImages = new System.Windows.Forms.CheckBox();
            this.ckbLogOKImages = new System.Windows.Forms.CheckBox();
            this.btnShowPLC = new System.Windows.Forms.Button();
            this.ckbLogPLC = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbProcessComplete2 = new System.Windows.Forms.Label();
            this.lbProcessBusy2 = new System.Windows.Forms.Label();
            this.lbProcessReadRow2 = new System.Windows.Forms.Label();
            this.lbProcessComplete1 = new System.Windows.Forms.Label();
            this.lbProcessBusy1 = new System.Windows.Forms.Label();
            this.lbProcessReadRow1 = new System.Windows.Forms.Label();
            this.lbProcessReady = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbStatusSTOP = new System.Windows.Forms.Label();
            this.lbStatusSTART = new System.Windows.Forms.Label();
            this.lbStatusERROR = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTriggerP2 = new System.Windows.Forms.Button();
            this.btnTriggerP1 = new System.Windows.Forms.Button();
            this.tLPChildForm = new System.Windows.Forms.TableLayoutPanel();
            this.tLPMain.SuspendLayout();
            this.tLPHeader.SuspendLayout();
            this.MainMenuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLangENG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLangVIE)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tLPHome.SuspendLayout();
            this.tLPResult.SuspendLayout();
            this.tLPOKNG.SuspendLayout();
            this.pnlSidePanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tLPMain
            // 
            this.tLPMain.ColumnCount = 1;
            this.tLPMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Controls.Add(this.tLPHeader, 0, 0);
            this.tLPMain.Controls.Add(this.tLPHome, 0, 1);
            this.tLPMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPMain.Location = new System.Drawing.Point(0, 0);
            this.tLPMain.Name = "tLPMain";
            this.tLPMain.RowCount = 2;
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tLPMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPMain.Size = new System.Drawing.Size(1234, 1041);
            this.tLPMain.TabIndex = 3;
            // 
            // tLPHeader
            // 
            this.tLPHeader.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tLPHeader.ColumnCount = 8;
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tLPHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tLPHeader.Controls.Add(this.lbModelSetting, 3, 0);
            this.tLPHeader.Controls.Add(this.lbModelName, 4, 0);
            this.tLPHeader.Controls.Add(this.btnStart, 0, 0);
            this.tLPHeader.Controls.Add(this.MainMenuStrip, 2, 0);
            this.tLPHeader.Controls.Add(this.btnStop, 1, 0);
            this.tLPHeader.Controls.Add(this.tableLayoutPanel1, 6, 0);
            this.tLPHeader.Controls.Add(this.tableLayoutPanel2, 5, 0);
            this.tLPHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPHeader.Location = new System.Drawing.Point(3, 3);
            this.tLPHeader.Name = "tLPHeader";
            this.tLPHeader.RowCount = 1;
            this.tLPHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPHeader.Size = new System.Drawing.Size(1228, 44);
            this.tLPHeader.TabIndex = 0;
            // 
            // lbModelSetting
            // 
            this.lbModelSetting.AutoSize = true;
            this.lbModelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModelSetting.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.lbModelSetting.Location = new System.Drawing.Point(335, 0);
            this.lbModelSetting.Name = "lbModelSetting";
            this.lbModelSetting.Size = new System.Drawing.Size(306, 44);
            this.lbModelSetting.TabIndex = 14;
            this.lbModelSetting.Text = "***";
            this.lbModelSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbModelName
            // 
            this.lbModelName.AutoSize = true;
            this.lbModelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModelName.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbModelName.Location = new System.Drawing.Point(647, 0);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(94, 44);
            this.lbModelName.TabIndex = 11;
            this.lbModelName.Text = "***";
            this.lbModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Green;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "▶️ START";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // MainMenuStrip
            // 
            this.MainMenuStrip.AutoSize = false;
            this.MainMenuStrip.BackColor = System.Drawing.Color.Gray;
            this.MainMenuStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuStrip.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.MainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemFile});
            this.MainMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.MainMenuStrip.Location = new System.Drawing.Point(217, 3);
            this.MainMenuStrip.Margin = new System.Windows.Forms.Padding(3);
            this.MainMenuStrip.Name = "MainMenuStrip";
            this.MainMenuStrip.Padding = new System.Windows.Forms.Padding(2);
            this.MainMenuStrip.Size = new System.Drawing.Size(112, 38);
            this.MainMenuStrip.TabIndex = 7;
            // 
            // itemFile
            // 
            this.itemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemHome,
            this.itemSetting});
            this.itemFile.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.itemFile.Name = "itemFile";
            this.itemFile.Size = new System.Drawing.Size(105, 34);
            this.itemFile.Text = "▼ MENU";
            // 
            // itemHome
            // 
            this.itemHome.Name = "itemHome";
            this.itemHome.Size = new System.Drawing.Size(202, 32);
            this.itemHome.Text = "🏠 HOME";
            // 
            // itemSetting
            // 
            this.itemSetting.Name = "itemSetting";
            this.itemSetting.Size = new System.Drawing.Size(202, 32);
            this.itemSetting.Text = "⚙️ SETTING";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Firebrick;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnStop.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStop.Location = new System.Drawing.Point(115, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 37);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "■ STOP";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pbLangENG, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pbLangVIE, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1122, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(59, 37);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // pbLangENG
            // 
            this.pbLangENG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLangENG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLangENG.Image = ((System.Drawing.Image)(resources.GetObject("pbLangENG.Image")));
            this.pbLangENG.Location = new System.Drawing.Point(3, 5);
            this.pbLangENG.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pbLangENG.Name = "pbLangENG";
            this.pbLangENG.Size = new System.Drawing.Size(23, 27);
            this.pbLangENG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLangENG.TabIndex = 0;
            this.pbLangENG.TabStop = false;
            // 
            // pbLangVIE
            // 
            this.pbLangVIE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLangVIE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLangVIE.Image = ((System.Drawing.Image)(resources.GetObject("pbLangVIE.Image")));
            this.pbLangVIE.Location = new System.Drawing.Point(32, 3);
            this.pbLangVIE.Name = "pbLangVIE";
            this.pbLangVIE.Size = new System.Drawing.Size(24, 31);
            this.pbLangVIE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbLangVIE.TabIndex = 1;
            this.pbLangVIE.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Controls.Add(this.lbConnectLED, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.lbConnectPLC, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbConnectCam1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbConnectCam3, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lbConnectCam2, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(747, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(369, 38);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // lbConnectLED
            // 
            this.lbConnectLED.AutoSize = true;
            this.lbConnectLED.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectLED.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectLED.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectLED.Location = new System.Drawing.Point(311, 19);
            this.lbConnectLED.Name = "lbConnectLED";
            this.lbConnectLED.Size = new System.Drawing.Size(55, 19);
            this.lbConnectLED.TabIndex = 10;
            this.lbConnectLED.Text = "⚡ LED";
            this.lbConnectLED.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConnectPLC
            // 
            this.lbConnectPLC.AutoSize = true;
            this.lbConnectPLC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectPLC.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectPLC.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectPLC.Location = new System.Drawing.Point(311, 0);
            this.lbConnectPLC.Name = "lbConnectPLC";
            this.lbConnectPLC.Size = new System.Drawing.Size(55, 19);
            this.lbConnectPLC.TabIndex = 2;
            this.lbConnectPLC.Text = "🅿️ PLC";
            this.lbConnectPLC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConnectCam1
            // 
            this.lbConnectCam1.AutoSize = true;
            this.lbConnectCam1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectCam1.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectCam1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectCam1.Location = new System.Drawing.Point(80, 0);
            this.lbConnectCam1.Name = "lbConnectCam1";
            this.lbConnectCam1.Size = new System.Drawing.Size(71, 19);
            this.lbConnectCam1.TabIndex = 10;
            this.lbConnectCam1.Text = "🔵 CAM 1";
            this.lbConnectCam1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConnectCam3
            // 
            this.lbConnectCam3.AutoSize = true;
            this.lbConnectCam3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectCam3.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectCam3.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectCam3.Location = new System.Drawing.Point(234, 0);
            this.lbConnectCam3.Name = "lbConnectCam3";
            this.lbConnectCam3.Size = new System.Drawing.Size(71, 19);
            this.lbConnectCam3.TabIndex = 9;
            this.lbConnectCam3.Text = "🔴 CAM 3";
            this.lbConnectCam3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbConnectCam2
            // 
            this.lbConnectCam2.AutoSize = true;
            this.lbConnectCam2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbConnectCam2.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnectCam2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbConnectCam2.Location = new System.Drawing.Point(157, 0);
            this.lbConnectCam2.Name = "lbConnectCam2";
            this.lbConnectCam2.Size = new System.Drawing.Size(71, 19);
            this.lbConnectCam2.TabIndex = 8;
            this.lbConnectCam2.Text = "🔴 CAM 2";
            this.lbConnectCam2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tLPHome
            // 
            this.tLPHome.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tLPHome.ColumnCount = 2;
            this.tLPHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPHome.Controls.Add(this.tLPResult, 0, 0);
            this.tLPHome.Controls.Add(this.tLPChildForm, 1, 0);
            this.tLPHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPHome.Location = new System.Drawing.Point(3, 53);
            this.tLPHome.Name = "tLPHome";
            this.tLPHome.RowCount = 1;
            this.tLPHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPHome.Size = new System.Drawing.Size(1228, 985);
            this.tLPHome.TabIndex = 7;
            // 
            // tLPResult
            // 
            this.tLPResult.ColumnCount = 1;
            this.tLPResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPResult.Controls.Add(this.tLPOKNG, 0, 2);
            this.tLPResult.Controls.Add(this.pnlSidePanel, 0, 0);
            this.tLPResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPResult.Location = new System.Drawing.Point(0, 0);
            this.tLPResult.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tLPResult.Name = "tLPResult";
            this.tLPResult.RowCount = 3;
            this.tLPResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tLPResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tLPResult.Size = new System.Drawing.Size(200, 982);
            this.tLPResult.TabIndex = 3;
            // 
            // tLPOKNG
            // 
            this.tLPOKNG.ColumnCount = 1;
            this.tLPOKNG.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPOKNG.Controls.Add(this.lbNGCount, 0, 3);
            this.tLPOKNG.Controls.Add(this.lbOKCount, 0, 2);
            this.tLPOKNG.Controls.Add(this.lbTotalCount, 0, 1);
            this.tLPOKNG.Controls.Add(this.btnReset, 0, 0);
            this.tLPOKNG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPOKNG.Location = new System.Drawing.Point(0, 822);
            this.tLPOKNG.Margin = new System.Windows.Forms.Padding(0);
            this.tLPOKNG.Name = "tLPOKNG";
            this.tLPOKNG.RowCount = 4;
            this.tLPOKNG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPOKNG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPOKNG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPOKNG.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tLPOKNG.Size = new System.Drawing.Size(200, 160);
            this.tLPOKNG.TabIndex = 0;
            // 
            // lbNGCount
            // 
            this.lbNGCount.AutoSize = true;
            this.lbNGCount.BackColor = System.Drawing.Color.Red;
            this.lbNGCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNGCount.Font = new System.Drawing.Font("Bahnschrift", 22F);
            this.lbNGCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbNGCount.Location = new System.Drawing.Point(3, 123);
            this.lbNGCount.Margin = new System.Windows.Forms.Padding(3);
            this.lbNGCount.Name = "lbNGCount";
            this.lbNGCount.Size = new System.Drawing.Size(194, 34);
            this.lbNGCount.TabIndex = 3;
            this.lbNGCount.Text = "0";
            this.lbNGCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbOKCount
            // 
            this.lbOKCount.AutoSize = true;
            this.lbOKCount.BackColor = System.Drawing.Color.LimeGreen;
            this.lbOKCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbOKCount.Font = new System.Drawing.Font("Bahnschrift", 22F);
            this.lbOKCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbOKCount.Location = new System.Drawing.Point(3, 83);
            this.lbOKCount.Margin = new System.Windows.Forms.Padding(3);
            this.lbOKCount.Name = "lbOKCount";
            this.lbOKCount.Size = new System.Drawing.Size(194, 34);
            this.lbOKCount.TabIndex = 2;
            this.lbOKCount.Text = "0";
            this.lbOKCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.AutoSize = true;
            this.lbTotalCount.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTotalCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbTotalCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTotalCount.Font = new System.Drawing.Font("Bahnschrift", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCount.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTotalCount.Location = new System.Drawing.Point(3, 43);
            this.lbTotalCount.Margin = new System.Windows.Forms.Padding(3);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(194, 34);
            this.lbTotalCount.TabIndex = 3;
            this.lbTotalCount.Text = "0";
            this.lbTotalCount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DarkGray;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnReset.ForeColor = System.Drawing.SystemColors.Control;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 33);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // pnlSidePanel
            // 
            this.pnlSidePanel.Controls.Add(this.ckbLogNGImages);
            this.pnlSidePanel.Controls.Add(this.ckbLogOKImages);
            this.pnlSidePanel.Controls.Add(this.btnShowPLC);
            this.pnlSidePanel.Controls.Add(this.ckbLogPLC);
            this.pnlSidePanel.Controls.Add(this.groupBox3);
            this.pnlSidePanel.Controls.Add(this.groupBox2);
            this.pnlSidePanel.Controls.Add(this.groupBox1);
            this.pnlSidePanel.Controls.Add(this.panel1);
            this.pnlSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSidePanel.Location = new System.Drawing.Point(3, 3);
            this.pnlSidePanel.Name = "pnlSidePanel";
            this.pnlSidePanel.Size = new System.Drawing.Size(194, 798);
            this.pnlSidePanel.TabIndex = 2;
            // 
            // ckbLogNGImages
            // 
            this.ckbLogNGImages.AutoSize = true;
            this.ckbLogNGImages.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLogNGImages.ForeColor = System.Drawing.SystemColors.Control;
            this.ckbLogNGImages.Location = new System.Drawing.Point(5, 690);
            this.ckbLogNGImages.Name = "ckbLogNGImages";
            this.ckbLogNGImages.Size = new System.Drawing.Size(108, 17);
            this.ckbLogNGImages.TabIndex = 16;
            this.ckbLogNGImages.Text = "Save NG Images";
            this.ckbLogNGImages.UseVisualStyleBackColor = true;
            // 
            // ckbLogOKImages
            // 
            this.ckbLogOKImages.AutoSize = true;
            this.ckbLogOKImages.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbLogOKImages.ForeColor = System.Drawing.SystemColors.Control;
            this.ckbLogOKImages.Location = new System.Drawing.Point(5, 667);
            this.ckbLogOKImages.Name = "ckbLogOKImages";
            this.ckbLogOKImages.Size = new System.Drawing.Size(107, 17);
            this.ckbLogOKImages.TabIndex = 15;
            this.ckbLogOKImages.Text = "Save OK Images";
            this.ckbLogOKImages.UseVisualStyleBackColor = true;
            // 
            // btnShowPLC
            // 
            this.btnShowPLC.BackColor = System.Drawing.Color.Gray;
            this.btnShowPLC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPLC.FlatAppearance.BorderSize = 0;
            this.btnShowPLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPLC.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPLC.ForeColor = System.Drawing.SystemColors.Control;
            this.btnShowPLC.Location = new System.Drawing.Point(0, 639);
            this.btnShowPLC.Name = "btnShowPLC";
            this.btnShowPLC.Size = new System.Drawing.Size(114, 22);
            this.btnShowPLC.TabIndex = 14;
            this.btnShowPLC.Text = "Get PLC Data";
            this.btnShowPLC.UseVisualStyleBackColor = false;
            // 
            // ckbLogPLC
            // 
            this.ckbLogPLC.AutoSize = true;
            this.ckbLogPLC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ckbLogPLC.Location = new System.Drawing.Point(0, 781);
            this.ckbLogPLC.Name = "ckbLogPLC";
            this.ckbLogPLC.Size = new System.Drawing.Size(194, 17);
            this.ckbLogPLC.TabIndex = 13;
            this.ckbLogPLC.Text = "Log PLC";
            this.ckbLogPLC.UseVisualStyleBackColor = true;
            this.ckbLogPLC.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbProcessComplete2);
            this.groupBox3.Controls.Add(this.lbProcessBusy2);
            this.groupBox3.Controls.Add(this.lbProcessReadRow2);
            this.groupBox3.Controls.Add(this.lbProcessComplete1);
            this.groupBox3.Controls.Add(this.lbProcessBusy1);
            this.groupBox3.Controls.Add(this.lbProcessReadRow1);
            this.groupBox3.Controls.Add(this.lbProcessReady);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox3.Location = new System.Drawing.Point(0, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(194, 282);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "▶ Process";
            // 
            // lbProcessComplete2
            // 
            this.lbProcessComplete2.AutoSize = true;
            this.lbProcessComplete2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessComplete2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessComplete2.Location = new System.Drawing.Point(6, 282);
            this.lbProcessComplete2.Name = "lbProcessComplete2";
            this.lbProcessComplete2.Size = new System.Drawing.Size(88, 19);
            this.lbProcessComplete2.TabIndex = 13;
            this.lbProcessComplete2.Text = "COMPLETE";
            this.lbProcessComplete2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessBusy2
            // 
            this.lbProcessBusy2.AutoSize = true;
            this.lbProcessBusy2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessBusy2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessBusy2.Location = new System.Drawing.Point(6, 241);
            this.lbProcessBusy2.Name = "lbProcessBusy2";
            this.lbProcessBusy2.Size = new System.Drawing.Size(47, 19);
            this.lbProcessBusy2.TabIndex = 12;
            this.lbProcessBusy2.Text = "BUSY";
            this.lbProcessBusy2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessReadRow2
            // 
            this.lbProcessReadRow2.AutoSize = true;
            this.lbProcessReadRow2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessReadRow2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessReadRow2.Location = new System.Drawing.Point(6, 200);
            this.lbProcessReadRow2.Name = "lbProcessReadRow2";
            this.lbProcessReadRow2.Size = new System.Drawing.Size(100, 19);
            this.lbProcessReadRow2.TabIndex = 11;
            this.lbProcessReadRow2.Text = "READ ROW 2";
            this.lbProcessReadRow2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessComplete1
            // 
            this.lbProcessComplete1.AutoSize = true;
            this.lbProcessComplete1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessComplete1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessComplete1.Location = new System.Drawing.Point(6, 159);
            this.lbProcessComplete1.Name = "lbProcessComplete1";
            this.lbProcessComplete1.Size = new System.Drawing.Size(88, 19);
            this.lbProcessComplete1.TabIndex = 10;
            this.lbProcessComplete1.Text = "COMPLETE";
            this.lbProcessComplete1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessBusy1
            // 
            this.lbProcessBusy1.AutoSize = true;
            this.lbProcessBusy1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessBusy1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessBusy1.Location = new System.Drawing.Point(6, 118);
            this.lbProcessBusy1.Name = "lbProcessBusy1";
            this.lbProcessBusy1.Size = new System.Drawing.Size(47, 19);
            this.lbProcessBusy1.TabIndex = 9;
            this.lbProcessBusy1.Text = "BUSY";
            this.lbProcessBusy1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessReadRow1
            // 
            this.lbProcessReadRow1.AutoSize = true;
            this.lbProcessReadRow1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessReadRow1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessReadRow1.Location = new System.Drawing.Point(6, 77);
            this.lbProcessReadRow1.Name = "lbProcessReadRow1";
            this.lbProcessReadRow1.Size = new System.Drawing.Size(97, 19);
            this.lbProcessReadRow1.TabIndex = 8;
            this.lbProcessReadRow1.Text = "READ ROW 1";
            this.lbProcessReadRow1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbProcessReady
            // 
            this.lbProcessReady.AutoSize = true;
            this.lbProcessReady.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcessReady.ForeColor = System.Drawing.SystemColors.Control;
            this.lbProcessReady.Location = new System.Drawing.Point(6, 36);
            this.lbProcessReady.Name = "lbProcessReady";
            this.lbProcessReady.Size = new System.Drawing.Size(58, 19);
            this.lbProcessReady.TabIndex = 7;
            this.lbProcessReady.Text = "READY";
            this.lbProcessReady.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbStatusSTOP);
            this.groupBox2.Controls.Add(this.lbStatusSTART);
            this.groupBox2.Controls.Add(this.lbStatusERROR);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox2.Location = new System.Drawing.Point(0, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 164);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "▶ Status";
            // 
            // lbStatusSTOP
            // 
            this.lbStatusSTOP.AutoSize = true;
            this.lbStatusSTOP.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusSTOP.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStatusSTOP.Location = new System.Drawing.Point(6, 121);
            this.lbStatusSTOP.Name = "lbStatusSTOP";
            this.lbStatusSTOP.Size = new System.Drawing.Size(65, 27);
            this.lbStatusSTOP.TabIndex = 6;
            this.lbStatusSTOP.Text = "STOP";
            this.lbStatusSTOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatusSTART
            // 
            this.lbStatusSTART.AutoSize = true;
            this.lbStatusSTART.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusSTART.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStatusSTART.Location = new System.Drawing.Point(6, 76);
            this.lbStatusSTART.Name = "lbStatusSTART";
            this.lbStatusSTART.Size = new System.Drawing.Size(75, 27);
            this.lbStatusSTART.TabIndex = 5;
            this.lbStatusSTART.Text = "START";
            this.lbStatusSTART.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatusERROR
            // 
            this.lbStatusERROR.AutoSize = true;
            this.lbStatusERROR.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusERROR.ForeColor = System.Drawing.SystemColors.Control;
            this.lbStatusERROR.Location = new System.Drawing.Point(6, 31);
            this.lbStatusERROR.Name = "lbStatusERROR";
            this.lbStatusERROR.Size = new System.Drawing.Size(81, 27);
            this.lbStatusERROR.TabIndex = 4;
            this.lbStatusERROR.Text = "ERROR";
            this.lbStatusERROR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbTime);
            this.groupBox1.Controls.Add(this.lbDate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Aqua;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 105);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "▶ Date time";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.Control;
            this.lbTime.Location = new System.Drawing.Point(6, 67);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(74, 22);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "00:00:00";
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Bahnschrift", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDate.Location = new System.Drawing.Point(6, 33);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(106, 22);
            this.lbDate.TabIndex = 3;
            this.lbDate.Text = "00/00/0000";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTriggerP2);
            this.panel1.Controls.Add(this.btnTriggerP1);
            this.panel1.Location = new System.Drawing.Point(0, 598);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 35);
            this.panel1.TabIndex = 12;
            // 
            // btnTriggerP2
            // 
            this.btnTriggerP2.BackColor = System.Drawing.Color.Gray;
            this.btnTriggerP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTriggerP2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnTriggerP2.FlatAppearance.BorderSize = 0;
            this.btnTriggerP2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTriggerP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriggerP2.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnTriggerP2.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTriggerP2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriggerP2.Location = new System.Drawing.Point(67, 0);
            this.btnTriggerP2.Name = "btnTriggerP2";
            this.btnTriggerP2.Size = new System.Drawing.Size(50, 35);
            this.btnTriggerP2.TabIndex = 6;
            this.btnTriggerP2.Text = "2";
            this.btnTriggerP2.UseVisualStyleBackColor = false;
            // 
            // btnTriggerP1
            // 
            this.btnTriggerP1.BackColor = System.Drawing.Color.Gray;
            this.btnTriggerP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTriggerP1.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTriggerP1.FlatAppearance.BorderSize = 0;
            this.btnTriggerP1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnTriggerP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTriggerP1.Font = new System.Drawing.Font("Bahnschrift", 16F);
            this.btnTriggerP1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTriggerP1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTriggerP1.Location = new System.Drawing.Point(0, 0);
            this.btnTriggerP1.Name = "btnTriggerP1";
            this.btnTriggerP1.Size = new System.Drawing.Size(50, 35);
            this.btnTriggerP1.TabIndex = 5;
            this.btnTriggerP1.Text = "1";
            this.btnTriggerP1.UseVisualStyleBackColor = false;
            // 
            // tLPChildForm
            // 
            this.tLPChildForm.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tLPChildForm.ColumnCount = 1;
            this.tLPChildForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPChildForm.Location = new System.Drawing.Point(200, 0);
            this.tLPChildForm.Margin = new System.Windows.Forms.Padding(0);
            this.tLPChildForm.Name = "tLPChildForm";
            this.tLPChildForm.RowCount = 1;
            this.tLPChildForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLPChildForm.Size = new System.Drawing.Size(1028, 985);
            this.tLPChildForm.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 1041);
            this.Controls.Add(this.tLPMain);
            this.Name = "FormMain";
            this.Text = "BIGSTONE VISION v1.0";
            this.tLPMain.ResumeLayout(false);
            this.tLPHeader.ResumeLayout(false);
            this.tLPHeader.PerformLayout();
            this.MainMenuStrip.ResumeLayout(false);
            this.MainMenuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLangENG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLangVIE)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tLPHome.ResumeLayout(false);
            this.tLPResult.ResumeLayout(false);
            this.tLPOKNG.ResumeLayout(false);
            this.tLPOKNG.PerformLayout();
            this.pnlSidePanel.ResumeLayout(false);
            this.pnlSidePanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLPMain;
        private System.Windows.Forms.TableLayoutPanel tLPHeader;
        private System.Windows.Forms.Label lbModelSetting;
        private System.Windows.Forms.Label lbModelName;
        public System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.MenuStrip MainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem itemFile;
        private System.Windows.Forms.ToolStripMenuItem itemHome;
        private System.Windows.Forms.ToolStripMenuItem itemSetting;
        public System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pbLangENG;
        private System.Windows.Forms.PictureBox pbLangVIE;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lbConnectLED;
        private System.Windows.Forms.Label lbConnectPLC;
        private System.Windows.Forms.Label lbConnectCam1;
        private System.Windows.Forms.Label lbConnectCam3;
        private System.Windows.Forms.Label lbConnectCam2;
        private System.Windows.Forms.TableLayoutPanel tLPHome;
        private System.Windows.Forms.TableLayoutPanel tLPResult;
        private System.Windows.Forms.TableLayoutPanel tLPOKNG;
        private System.Windows.Forms.Label lbNGCount;
        private System.Windows.Forms.Label lbOKCount;
        private System.Windows.Forms.Label lbTotalCount;
        public System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlSidePanel;
        private System.Windows.Forms.CheckBox ckbLogNGImages;
        private System.Windows.Forms.CheckBox ckbLogOKImages;
        private System.Windows.Forms.Button btnShowPLC;
        private System.Windows.Forms.CheckBox ckbLogPLC;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbProcessComplete2;
        private System.Windows.Forms.Label lbProcessBusy2;
        private System.Windows.Forms.Label lbProcessReadRow2;
        private System.Windows.Forms.Label lbProcessComplete1;
        private System.Windows.Forms.Label lbProcessBusy1;
        private System.Windows.Forms.Label lbProcessReadRow1;
        private System.Windows.Forms.Label lbProcessReady;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbStatusSTOP;
        private System.Windows.Forms.Label lbStatusSTART;
        private System.Windows.Forms.Label lbStatusERROR;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnTriggerP2;
        public System.Windows.Forms.Button btnTriggerP1;
        private System.Windows.Forms.TableLayoutPanel tLPChildForm;
    }
}

