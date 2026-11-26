namespace HK_Inspection
{
    partial class FormSetting
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
            this.SettingTabControl = new System.Windows.Forms.TabControl();
            this.tabCamera = new System.Windows.Forms.TabPage();
            this.tLPCamera = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetExposure = new System.Windows.Forms.Button();
            this.tbExposure = new System.Windows.Forms.TextBox();
            this.cbListCamera = new System.Windows.Forms.ComboBox();
            this.lbExposure = new System.Windows.Forms.Label();
            this.lbCamera = new System.Windows.Forms.Label();
            this.cbSequence = new System.Windows.Forms.ComboBox();
            this.btnLive = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbLED4 = new System.Windows.Forms.CheckBox();
            this.ckbLED3 = new System.Windows.Forms.CheckBox();
            this.ckbLED2 = new System.Windows.Forms.CheckBox();
            this.ckbLED1 = new System.Windows.Forms.CheckBox();
            this.tabProgram = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveModelSetting = new System.Windows.Forms.Button();
            this.tbModelSetting = new System.Windows.Forms.TextBox();
            this.cbListToolBlock = new System.Windows.Forms.ComboBox();
            this.btnRunOnce = new System.Windows.Forms.Button();
            this.btnSaveToolBlock = new System.Windows.Forms.Button();
            this.btnShowProgramTB = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.insToolBlockEditor1 = new Insnex.Vision2D.ToolBlock.Controls.InsToolBlockEditor();
            this.tabSpec = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSaveSpecs = new System.Windows.Forms.Button();
            this.cbListSpecs = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPLC = new System.Windows.Forms.TabPage();
            this.tbNumRegister = new System.Windows.Forms.TextBox();
            this.tbReadAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWriteAdd = new System.Windows.Forms.TextBox();
            this.tbWriteValue = new System.Windows.Forms.TextBox();
            this.tbReadValue = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.tabOthers = new System.Windows.Forms.TabPage();
            this.ckbUseCodeData = new System.Windows.Forms.CheckBox();
            this.btnOpenHistoryDialog = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbDir = new System.Windows.Forms.Label();
            this.tbHistoryDirectory = new System.Windows.Forms.TextBox();
            this.SettingTabControl.SuspendLayout();
            this.tabCamera.SuspendLayout();
            this.tLPCamera.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabProgram.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabSpec.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPLC.SuspendLayout();
            this.tabOthers.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingTabControl
            // 
            this.SettingTabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.SettingTabControl.Controls.Add(this.tabCamera);
            this.SettingTabControl.Controls.Add(this.tabProgram);
            this.SettingTabControl.Controls.Add(this.tabSpec);
            this.SettingTabControl.Controls.Add(this.tabPLC);
            this.SettingTabControl.Controls.Add(this.tabOthers);
            this.SettingTabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.SettingTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingTabControl.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingTabControl.ItemSize = new System.Drawing.Size(150, 32);
            this.SettingTabControl.Location = new System.Drawing.Point(0, 0);
            this.SettingTabControl.Name = "SettingTabControl";
            this.SettingTabControl.SelectedIndex = 0;
            this.SettingTabControl.Size = new System.Drawing.Size(984, 761);
            this.SettingTabControl.TabIndex = 2;
            // 
            // tabCamera
            // 
            this.tabCamera.BackColor = System.Drawing.Color.DimGray;
            this.tabCamera.Controls.Add(this.tLPCamera);
            this.tabCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCamera.Location = new System.Drawing.Point(4, 36);
            this.tabCamera.Name = "tabCamera";
            this.tabCamera.Padding = new System.Windows.Forms.Padding(3);
            this.tabCamera.Size = new System.Drawing.Size(976, 721);
            this.tabCamera.TabIndex = 0;
            this.tabCamera.Text = "CAMERA";
            // 
            // tLPCamera
            // 
            this.tLPCamera.ColumnCount = 2;
            this.tLPCamera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tLPCamera.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPCamera.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tLPCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPCamera.Location = new System.Drawing.Point(3, 3);
            this.tLPCamera.Name = "tLPCamera";
            this.tLPCamera.RowCount = 1;
            this.tLPCamera.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPCamera.Size = new System.Drawing.Size(970, 715);
            this.tLPCamera.TabIndex = 1;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnLive, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(194, 709);
            this.tableLayoutPanel9.TabIndex = 12;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel10.Controls.Add(this.btnSetExposure, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.tbExposure, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.cbListCamera, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.lbExposure, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.lbCamera, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.cbSequence, 0, 2);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(188, 144);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // btnSetExposure
            // 
            this.btnSetExposure.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSetExposure.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetExposure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSetExposure.FlatAppearance.BorderSize = 0;
            this.btnSetExposure.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSetExposure.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSetExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetExposure.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetExposure.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSetExposure.Location = new System.Drawing.Point(78, 98);
            this.btnSetExposure.Name = "btnSetExposure";
            this.btnSetExposure.Size = new System.Drawing.Size(107, 43);
            this.btnSetExposure.TabIndex = 1;
            this.btnSetExposure.Text = "SAVE";
            this.btnSetExposure.UseVisualStyleBackColor = false;
            // 
            // tbExposure
            // 
            this.tbExposure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbExposure.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbExposure.Location = new System.Drawing.Point(78, 50);
            this.tbExposure.Name = "tbExposure";
            this.tbExposure.Size = new System.Drawing.Size(107, 36);
            this.tbExposure.TabIndex = 0;
            // 
            // cbListCamera
            // 
            this.cbListCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbListCamera.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbListCamera.FormattingEnabled = true;
            this.cbListCamera.Location = new System.Drawing.Point(78, 3);
            this.cbListCamera.Name = "cbListCamera";
            this.cbListCamera.Size = new System.Drawing.Size(107, 37);
            this.cbListCamera.TabIndex = 5;
            // 
            // lbExposure
            // 
            this.lbExposure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExposure.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbExposure.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExposure.ForeColor = System.Drawing.SystemColors.Control;
            this.lbExposure.Location = new System.Drawing.Point(3, 47);
            this.lbExposure.Name = "lbExposure";
            this.lbExposure.Size = new System.Drawing.Size(69, 48);
            this.lbExposure.TabIndex = 0;
            this.lbExposure.Text = "Expose";
            this.lbExposure.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCamera
            // 
            this.lbCamera.AutoSize = true;
            this.lbCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCamera.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamera.ForeColor = System.Drawing.SystemColors.Control;
            this.lbCamera.Location = new System.Drawing.Point(3, 0);
            this.lbCamera.Name = "lbCamera";
            this.lbCamera.Size = new System.Drawing.Size(69, 47);
            this.lbCamera.TabIndex = 4;
            this.lbCamera.Text = "Camera";
            this.lbCamera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbSequence
            // 
            this.cbSequence.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSequence.FormattingEnabled = true;
            this.cbSequence.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbSequence.Location = new System.Drawing.Point(3, 98);
            this.cbSequence.Name = "cbSequence";
            this.cbSequence.Size = new System.Drawing.Size(69, 41);
            this.cbSequence.TabIndex = 6;
            this.cbSequence.Text = "1";
            // 
            // btnLive
            // 
            this.btnLive.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLive.FlatAppearance.BorderSize = 0;
            this.btnLive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnLive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLive.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLive.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLive.Location = new System.Drawing.Point(3, 153);
            this.btnLive.Name = "btnLive";
            this.btnLive.Size = new System.Drawing.Size(188, 44);
            this.btnLive.TabIndex = 0;
            this.btnLive.Text = "LIVE";
            this.btnLive.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbLED4);
            this.groupBox1.Controls.Add(this.ckbLED3);
            this.groupBox1.Controls.Add(this.ckbLED2);
            this.groupBox1.Controls.Add(this.ckbLED1);
            this.groupBox1.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 143);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Light Control";
            // 
            // ckbLED4
            // 
            this.ckbLED4.AutoSize = true;
            this.ckbLED4.Location = new System.Drawing.Point(7, 105);
            this.ckbLED4.Name = "ckbLED4";
            this.ckbLED4.Size = new System.Drawing.Size(64, 21);
            this.ckbLED4.TabIndex = 3;
            this.ckbLED4.Text = "LED 4";
            this.ckbLED4.UseVisualStyleBackColor = true;
            // 
            // ckbLED3
            // 
            this.ckbLED3.AutoSize = true;
            this.ckbLED3.Location = new System.Drawing.Point(7, 78);
            this.ckbLED3.Name = "ckbLED3";
            this.ckbLED3.Size = new System.Drawing.Size(63, 21);
            this.ckbLED3.TabIndex = 2;
            this.ckbLED3.Text = "LED 3";
            this.ckbLED3.UseVisualStyleBackColor = true;
            // 
            // ckbLED2
            // 
            this.ckbLED2.AutoSize = true;
            this.ckbLED2.Location = new System.Drawing.Point(7, 51);
            this.ckbLED2.Name = "ckbLED2";
            this.ckbLED2.Size = new System.Drawing.Size(63, 21);
            this.ckbLED2.TabIndex = 1;
            this.ckbLED2.Text = "LED 2";
            this.ckbLED2.UseVisualStyleBackColor = true;
            // 
            // ckbLED1
            // 
            this.ckbLED1.AutoSize = true;
            this.ckbLED1.Location = new System.Drawing.Point(7, 24);
            this.ckbLED1.Name = "ckbLED1";
            this.ckbLED1.Size = new System.Drawing.Size(61, 21);
            this.ckbLED1.TabIndex = 0;
            this.ckbLED1.Text = "LED 1";
            this.ckbLED1.UseVisualStyleBackColor = true;
            // 
            // tabProgram
            // 
            this.tabProgram.BackColor = System.Drawing.Color.DimGray;
            this.tabProgram.Controls.Add(this.tableLayoutPanel1);
            this.tabProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProgram.Location = new System.Drawing.Point(4, 36);
            this.tabProgram.Name = "tabProgram";
            this.tabProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabProgram.Size = new System.Drawing.Size(976, 721);
            this.tabProgram.TabIndex = 1;
            this.tabProgram.Text = "PROGRAM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.insToolBlockEditor1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(970, 715);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.cbListToolBlock, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnRunOnce, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnSaveToolBlock, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnShowProgramTB, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnTest, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(194, 709);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSaveModelSetting);
            this.groupBox3.Controls.Add(this.tbModelSetting);
            this.groupBox3.Font = new System.Drawing.Font("Bahnschrift", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(3, 153);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 114);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SettingModel";
            // 
            // btnSaveModelSetting
            // 
            this.btnSaveModelSetting.AccessibleRole = System.Windows.Forms.AccessibleRole.Animation;
            this.btnSaveModelSetting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveModelSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveModelSetting.FlatAppearance.BorderSize = 0;
            this.btnSaveModelSetting.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveModelSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSaveModelSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveModelSetting.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveModelSetting.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveModelSetting.Location = new System.Drawing.Point(6, 64);
            this.btnSaveModelSetting.Name = "btnSaveModelSetting";
            this.btnSaveModelSetting.Size = new System.Drawing.Size(176, 38);
            this.btnSaveModelSetting.TabIndex = 2;
            this.btnSaveModelSetting.Text = "SAVE";
            this.btnSaveModelSetting.UseVisualStyleBackColor = false;
            // 
            // tbModelSetting
            // 
            this.tbModelSetting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbModelSetting.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModelSetting.Location = new System.Drawing.Point(3, 20);
            this.tbModelSetting.Name = "tbModelSetting";
            this.tbModelSetting.Size = new System.Drawing.Size(182, 30);
            this.tbModelSetting.TabIndex = 1;
            // 
            // cbListToolBlock
            // 
            this.cbListToolBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbListToolBlock.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.cbListToolBlock.FormattingEnabled = true;
            this.cbListToolBlock.Location = new System.Drawing.Point(3, 3);
            this.cbListToolBlock.Name = "cbListToolBlock";
            this.cbListToolBlock.Size = new System.Drawing.Size(188, 37);
            this.cbListToolBlock.TabIndex = 5;
            // 
            // btnRunOnce
            // 
            this.btnRunOnce.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRunOnce.FlatAppearance.BorderSize = 0;
            this.btnRunOnce.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRunOnce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnRunOnce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRunOnce.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold);
            this.btnRunOnce.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRunOnce.Location = new System.Drawing.Point(3, 103);
            this.btnRunOnce.Name = "btnRunOnce";
            this.btnRunOnce.Size = new System.Drawing.Size(188, 44);
            this.btnRunOnce.TabIndex = 3;
            this.btnRunOnce.Text = "RUN ONCE";
            this.btnRunOnce.UseVisualStyleBackColor = false;
            // 
            // btnSaveToolBlock
            // 
            this.btnSaveToolBlock.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveToolBlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveToolBlock.FlatAppearance.BorderSize = 0;
            this.btnSaveToolBlock.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveToolBlock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSaveToolBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveToolBlock.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveToolBlock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveToolBlock.Location = new System.Drawing.Point(3, 53);
            this.btnSaveToolBlock.Name = "btnSaveToolBlock";
            this.btnSaveToolBlock.Size = new System.Drawing.Size(188, 44);
            this.btnSaveToolBlock.TabIndex = 1;
            this.btnSaveToolBlock.Text = "SAVE";
            this.btnSaveToolBlock.UseVisualStyleBackColor = false;
            // 
            // btnShowProgramTB
            // 
            this.btnShowProgramTB.AutoSize = true;
            this.btnShowProgramTB.BackColor = System.Drawing.Color.Transparent;
            this.btnShowProgramTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowProgramTB.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnShowProgramTB.FlatAppearance.BorderSize = 0;
            this.btnShowProgramTB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowProgramTB.ForeColor = System.Drawing.Color.DarkGray;
            this.btnShowProgramTB.Location = new System.Drawing.Point(161, 680);
            this.btnShowProgramTB.Name = "btnShowProgramTB";
            this.btnShowProgramTB.Size = new System.Drawing.Size(30, 26);
            this.btnShowProgramTB.TabIndex = 6;
            this.btnShowProgramTB.Text = ">";
            this.btnShowProgramTB.UseVisualStyleBackColor = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(3, 273);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(188, 44);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "TEST";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            // 
            // insToolBlockEditor1
            // 
            this.insToolBlockEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.insToolBlockEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.insToolBlockEditor1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.insToolBlockEditor1.Location = new System.Drawing.Point(203, 3);
            this.insToolBlockEditor1.Name = "insToolBlockEditor1";
            this.insToolBlockEditor1.Size = new System.Drawing.Size(764, 709);
            this.insToolBlockEditor1.TabIndex = 2;
            // 
            // tabSpec
            // 
            this.tabSpec.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabSpec.Controls.Add(this.panel1);
            this.tabSpec.Location = new System.Drawing.Point(4, 36);
            this.tabSpec.Name = "tabSpec";
            this.tabSpec.Padding = new System.Windows.Forms.Padding(3);
            this.tabSpec.Size = new System.Drawing.Size(976, 721);
            this.tabSpec.TabIndex = 5;
            this.tabSpec.Text = "SPECS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 715);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(970, 715);
            this.tableLayoutPanel3.TabIndex = 8;
            this.tableLayoutPanel3.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.btnImport, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.btnSaveSpecs, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.cbListSpecs, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(194, 536);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Enabled = false;
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImport.Location = new System.Drawing.Point(3, 103);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(188, 43);
            this.btnImport.TabIndex = 7;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Visible = false;
            // 
            // btnSaveSpecs
            // 
            this.btnSaveSpecs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveSpecs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveSpecs.FlatAppearance.BorderSize = 0;
            this.btnSaveSpecs.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDark;
            this.btnSaveSpecs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Chocolate;
            this.btnSaveSpecs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveSpecs.Font = new System.Drawing.Font("Bahnschrift", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSpecs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSaveSpecs.Location = new System.Drawing.Point(3, 53);
            this.btnSaveSpecs.Name = "btnSaveSpecs";
            this.btnSaveSpecs.Size = new System.Drawing.Size(188, 43);
            this.btnSaveSpecs.TabIndex = 6;
            this.btnSaveSpecs.Text = "SET";
            this.btnSaveSpecs.UseVisualStyleBackColor = false;
            // 
            // cbListSpecs
            // 
            this.cbListSpecs.Font = new System.Drawing.Font("Bahnschrift", 18F);
            this.cbListSpecs.FormattingEnabled = true;
            this.cbListSpecs.Location = new System.Drawing.Point(3, 3);
            this.cbListSpecs.Name = "cbListSpecs";
            this.cbListSpecs.Size = new System.Drawing.Size(188, 37);
            this.cbListSpecs.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(203, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(764, 709);
            this.panel3.TabIndex = 6;
            // 
            // tabPLC
            // 
            this.tabPLC.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabPLC.Controls.Add(this.tbNumRegister);
            this.tabPLC.Controls.Add(this.tbReadAdd);
            this.tabPLC.Controls.Add(this.label3);
            this.tabPLC.Controls.Add(this.label2);
            this.tabPLC.Controls.Add(this.tbWriteAdd);
            this.tabPLC.Controls.Add(this.tbWriteValue);
            this.tabPLC.Controls.Add(this.tbReadValue);
            this.tabPLC.Controls.Add(this.btnRead);
            this.tabPLC.Controls.Add(this.btnWrite);
            this.tabPLC.Location = new System.Drawing.Point(4, 36);
            this.tabPLC.Name = "tabPLC";
            this.tabPLC.Padding = new System.Windows.Forms.Padding(3);
            this.tabPLC.Size = new System.Drawing.Size(976, 721);
            this.tabPLC.TabIndex = 2;
            this.tabPLC.Text = "PLC";
            // 
            // tbNumRegister
            // 
            this.tbNumRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumRegister.Location = new System.Drawing.Point(803, 168);
            this.tbNumRegister.Name = "tbNumRegister";
            this.tbNumRegister.Size = new System.Drawing.Size(95, 29);
            this.tbNumRegister.TabIndex = 20;
            this.tbNumRegister.Text = "1";
            this.tbNumRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReadAdd
            // 
            this.tbReadAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadAdd.Location = new System.Drawing.Point(505, 168);
            this.tbReadAdd.Name = "tbReadAdd";
            this.tbReadAdd.Size = new System.Drawing.Size(292, 29);
            this.tbReadAdd.TabIndex = 19;
            this.tbReadAdd.Text = "U00D.Work[10]";
            this.tbReadAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Value";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Address";
            // 
            // tbWriteAdd
            // 
            this.tbWriteAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteAdd.Location = new System.Drawing.Point(243, 168);
            this.tbWriteAdd.Name = "tbWriteAdd";
            this.tbWriteAdd.Size = new System.Drawing.Size(237, 29);
            this.tbWriteAdd.TabIndex = 15;
            this.tbWriteAdd.Text = "U00D.Work[10]";
            this.tbWriteAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbWriteValue
            // 
            this.tbWriteValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWriteValue.Location = new System.Drawing.Point(243, 205);
            this.tbWriteValue.Name = "tbWriteValue";
            this.tbWriteValue.Size = new System.Drawing.Size(237, 29);
            this.tbWriteValue.TabIndex = 14;
            this.tbWriteValue.Text = "1";
            this.tbWriteValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbReadValue
            // 
            this.tbReadValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbReadValue.Location = new System.Drawing.Point(505, 205);
            this.tbReadValue.Multiline = true;
            this.tbReadValue.Name = "tbReadValue";
            this.tbReadValue.ReadOnly = true;
            this.tbReadValue.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbReadValue.Size = new System.Drawing.Size(393, 180);
            this.tbReadValue.TabIndex = 13;
            // 
            // btnRead
            // 
            this.btnRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRead.Location = new System.Drawing.Point(505, 119);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(393, 34);
            this.btnRead.TabIndex = 12;
            this.btnRead.Text = "READ";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            this.btnWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWrite.FlatAppearance.BorderSize = 0;
            this.btnWrite.Location = new System.Drawing.Point(243, 119);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(237, 34);
            this.btnWrite.TabIndex = 11;
            this.btnWrite.Text = "WRITE";
            this.btnWrite.UseVisualStyleBackColor = true;
            // 
            // tabOthers
            // 
            this.tabOthers.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tabOthers.Controls.Add(this.ckbUseCodeData);
            this.tabOthers.Controls.Add(this.btnOpenHistoryDialog);
            this.tabOthers.Controls.Add(this.label16);
            this.tabOthers.Controls.Add(this.textBox5);
            this.tabOthers.Controls.Add(this.label15);
            this.tabOthers.Controls.Add(this.textBox4);
            this.tabOthers.Controls.Add(this.label14);
            this.tabOthers.Controls.Add(this.textBox3);
            this.tabOthers.Controls.Add(this.label13);
            this.tabOthers.Controls.Add(this.textBox2);
            this.tabOthers.Controls.Add(this.lbDir);
            this.tabOthers.Controls.Add(this.tbHistoryDirectory);
            this.tabOthers.Location = new System.Drawing.Point(4, 36);
            this.tabOthers.Name = "tabOthers";
            this.tabOthers.Padding = new System.Windows.Forms.Padding(3);
            this.tabOthers.Size = new System.Drawing.Size(976, 721);
            this.tabOthers.TabIndex = 4;
            this.tabOthers.Text = "OTHERS";
            // 
            // ckbUseCodeData
            // 
            this.ckbUseCodeData.AutoSize = true;
            this.ckbUseCodeData.Checked = true;
            this.ckbUseCodeData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbUseCodeData.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbUseCodeData.ForeColor = System.Drawing.SystemColors.Control;
            this.ckbUseCodeData.Location = new System.Drawing.Point(60, 86);
            this.ckbUseCodeData.Name = "ckbUseCodeData";
            this.ckbUseCodeData.Size = new System.Drawing.Size(156, 27);
            this.ckbUseCodeData.TabIndex = 28;
            this.ckbUseCodeData.Text = "Used CodeData";
            this.ckbUseCodeData.UseVisualStyleBackColor = true;
            // 
            // btnOpenHistoryDialog
            // 
            this.btnOpenHistoryDialog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenHistoryDialog.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenHistoryDialog.Location = new System.Drawing.Point(726, 35);
            this.btnOpenHistoryDialog.Name = "btnOpenHistoryDialog";
            this.btnOpenHistoryDialog.Size = new System.Drawing.Size(90, 30);
            this.btnOpenHistoryDialog.TabIndex = 27;
            this.btnOpenHistoryDialog.Text = "OPEN";
            this.btnOpenHistoryDialog.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(128, 581);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 23);
            this.label16.TabIndex = 26;
            this.label16.Text = "IP CAM4";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(227, 578);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(480, 30);
            this.textBox5.TabIndex = 25;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(129, 523);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 23);
            this.label15.TabIndex = 24;
            this.label15.Text = "IP CAM3";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(227, 520);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(480, 30);
            this.textBox4.TabIndex = 23;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(129, 465);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 23);
            this.label14.TabIndex = 22;
            this.label14.Text = "IP CAM2";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(227, 462);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(480, 30);
            this.textBox3.TabIndex = 21;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(133, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 23);
            this.label13.TabIndex = 20;
            this.label13.Text = "IP CAM1";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(227, 404);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 30);
            this.textBox2.TabIndex = 19;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            // 
            // lbDir
            // 
            this.lbDir.AutoSize = true;
            this.lbDir.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDir.ForeColor = System.Drawing.SystemColors.Control;
            this.lbDir.Location = new System.Drawing.Point(56, 38);
            this.lbDir.Name = "lbDir";
            this.lbDir.Size = new System.Drawing.Size(153, 23);
            this.lbDir.TabIndex = 18;
            this.lbDir.Text = "History Directory";
            this.lbDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbHistoryDirectory
            // 
            this.tbHistoryDirectory.Font = new System.Drawing.Font("Bahnschrift", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHistoryDirectory.Location = new System.Drawing.Point(227, 35);
            this.tbHistoryDirectory.Name = "tbHistoryDirectory";
            this.tbHistoryDirectory.Size = new System.Drawing.Size(480, 30);
            this.tbHistoryDirectory.TabIndex = 17;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.SettingTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetting";
            this.Text = "FormSetting";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.SettingTabControl.ResumeLayout(false);
            this.tabCamera.ResumeLayout(false);
            this.tLPCamera.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProgram.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabSpec.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tabPLC.ResumeLayout(false);
            this.tabPLC.PerformLayout();
            this.tabOthers.ResumeLayout(false);
            this.tabOthers.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingTabControl;
        private System.Windows.Forms.TabPage tabCamera;
        private System.Windows.Forms.TableLayoutPanel tLPCamera;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Button btnSetExposure;
        private System.Windows.Forms.TextBox tbExposure;
        private System.Windows.Forms.ComboBox cbListCamera;
        private System.Windows.Forms.Label lbExposure;
        private System.Windows.Forms.Label lbCamera;
        protected System.Windows.Forms.ComboBox cbSequence;
        private System.Windows.Forms.Button btnLive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbLED4;
        private System.Windows.Forms.CheckBox ckbLED3;
        private System.Windows.Forms.CheckBox ckbLED2;
        private System.Windows.Forms.CheckBox ckbLED1;
        private System.Windows.Forms.TabPage tabProgram;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSaveModelSetting;
        private System.Windows.Forms.TextBox tbModelSetting;
        private System.Windows.Forms.ComboBox cbListToolBlock;
        private System.Windows.Forms.Button btnRunOnce;
        private System.Windows.Forms.Button btnSaveToolBlock;
        private System.Windows.Forms.Button btnShowProgramTB;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.TabPage tabSpec;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSaveSpecs;
        private System.Windows.Forms.ComboBox cbListSpecs;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabPage tabPLC;
        private System.Windows.Forms.TextBox tbNumRegister;
        private System.Windows.Forms.TextBox tbReadAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWriteAdd;
        private System.Windows.Forms.TextBox tbWriteValue;
        private System.Windows.Forms.TextBox tbReadValue;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TabPage tabOthers;
        private System.Windows.Forms.CheckBox ckbUseCodeData;
        private System.Windows.Forms.Button btnOpenHistoryDialog;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lbDir;
        private System.Windows.Forms.TextBox tbHistoryDirectory;
        private Insnex.Vision2D.ToolBlock.Controls.InsToolBlockEditor insToolBlockEditor1;
    }
}