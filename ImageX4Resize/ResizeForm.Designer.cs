namespace ImageX4Resize
{
    partial class ResizeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelTotalFolderNum = new System.Windows.Forms.Label();
            this.labelImageNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRootFolderSelect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxRootFolder = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelProcessNum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelProcessStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonConvertStart = new System.Windows.Forms.Button();
            this.imageAdjustBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.processProgressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFolderPath = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxHexColor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPosition4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPosition7 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPosition1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonPosition0 = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonPosition3 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.buttonPosition6 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.buttonPosition2 = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.buttonPosition5 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.buttonPosition8 = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.SelectPosition3 = new System.Windows.Forms.PictureBox();
            this.SelectPosition0 = new System.Windows.Forms.PictureBox();
            this.SelectPosition1 = new System.Windows.Forms.PictureBox();
            this.SelectPosition2 = new System.Windows.Forms.PictureBox();
            this.SelectPosition4 = new System.Windows.Forms.PictureBox();
            this.SelectPosition5 = new System.Windows.Forms.PictureBox();
            this.SelectPosition6 = new System.Windows.Forms.PictureBox();
            this.SelectPosition7 = new System.Windows.Forms.PictureBox();
            this.SelectPosition8 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition8)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Controls.Add(this.labelTotalFolderNum);
            this.groupBox1.Controls.Add(this.labelImageNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(10, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 154);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Result";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "PNG image number:";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.Location = new System.Drawing.Point(442, 110);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(94, 29);
            this.buttonRefresh.TabIndex = 9;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // labelTotalFolderNum
            // 
            this.labelTotalFolderNum.AutoSize = true;
            this.labelTotalFolderNum.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalFolderNum.Location = new System.Drawing.Point(283, 27);
            this.labelTotalFolderNum.Name = "labelTotalFolderNum";
            this.labelTotalFolderNum.Size = new System.Drawing.Size(29, 34);
            this.labelTotalFolderNum.TabIndex = 9;
            this.labelTotalFolderNum.Text = "0";
            // 
            // labelImageNum
            // 
            this.labelImageNum.AutoSize = true;
            this.labelImageNum.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelImageNum.ForeColor = System.Drawing.Color.Red;
            this.labelImageNum.Location = new System.Drawing.Point(265, 72);
            this.labelImageNum.Name = "labelImageNum";
            this.labelImageNum.Size = new System.Drawing.Size(69, 34);
            this.labelImageNum.TabIndex = 8;
            this.labelImageNum.Text = "0 / 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Total folder number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "(Need resize / Total)";
            // 
            // buttonRootFolderSelect
            // 
            this.buttonRootFolderSelect.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRootFolderSelect.Location = new System.Drawing.Point(453, 50);
            this.buttonRootFolderSelect.Name = "buttonRootFolderSelect";
            this.buttonRootFolderSelect.Size = new System.Drawing.Size(94, 29);
            this.buttonRootFolderSelect.TabIndex = 13;
            this.buttonRootFolderSelect.Text = "Select";
            this.buttonRootFolderSelect.UseVisualStyleBackColor = true;
            this.buttonRootFolderSelect.Click += new System.EventHandler(this.ButtonRootFolderSelect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "1. Select image root folder";
            // 
            // textBoxRootFolder
            // 
            this.textBoxRootFolder.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxRootFolder.Location = new System.Drawing.Point(11, 51);
            this.textBoxRootFolder.Name = "textBoxRootFolder";
            this.textBoxRootFolder.Size = new System.Drawing.Size(396, 30);
            this.textBoxRootFolder.TabIndex = 11;
            // 
            // labelFileName
            // 
            this.labelFileName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFileName.Location = new System.Drawing.Point(21, 171);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(518, 30);
            this.labelFileName.TabIndex = 24;
            this.labelFileName.Text = " File name";
            // 
            // labelProcessNum
            // 
            this.labelProcessNum.AutoSize = true;
            this.labelProcessNum.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcessNum.Location = new System.Drawing.Point(319, 40);
            this.labelProcessNum.Name = "labelProcessNum";
            this.labelProcessNum.Size = new System.Drawing.Size(57, 28);
            this.labelProcessNum.TabIndex = 22;
            this.labelProcessNum.Text = "0 / 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(107, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Source file will overwrite with adjusted file.";
            // 
            // labelProcessStatus
            // 
            this.labelProcessStatus.AutoSize = true;
            this.labelProcessStatus.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProcessStatus.Location = new System.Drawing.Point(26, 40);
            this.labelProcessStatus.Name = "labelProcessStatus";
            this.labelProcessStatus.Size = new System.Drawing.Size(117, 25);
            this.labelProcessStatus.TabIndex = 20;
            this.labelProcessStatus.Text = "Processing...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.OrangeRed;
            this.label3.Location = new System.Drawing.Point(328, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 34);
            this.label3.TabIndex = 19;
            this.label3.Text = "Buckup!";
            // 
            // buttonConvertStart
            // 
            this.buttonConvertStart.Enabled = false;
            this.buttonConvertStart.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConvertStart.Location = new System.Drawing.Point(452, 499);
            this.buttonConvertStart.Name = "buttonConvertStart";
            this.buttonConvertStart.Size = new System.Drawing.Size(94, 29);
            this.buttonConvertStart.TabIndex = 18;
            this.buttonConvertStart.Text = "Convert";
            this.buttonConvertStart.UseVisualStyleBackColor = true;
            this.buttonConvertStart.Click += new System.EventHandler(this.ButtonConvertStart_Click);
            // 
            // imageAdjustBackgroundWorker
            // 
            this.imageAdjustBackgroundWorker.WorkerReportsProgress = true;
            this.imageAdjustBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ImageAdjustBackgroundWorker_DoWork);
            this.imageAdjustBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ImageAdjustBackgroundWorker_ProgressChanged);
            this.imageAdjustBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ImageAdjustBackgroundWorker_RunWorkerCompleted);
            // 
            // processProgressBar
            // 
            this.processProgressBar.Location = new System.Drawing.Point(26, 73);
            this.processProgressBar.Name = "processProgressBar";
            this.processProgressBar.Size = new System.Drawing.Size(494, 29);
            this.processProgressBar.Step = 1;
            this.processProgressBar.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFolderPath);
            this.groupBox2.Controls.Add(this.processProgressBar);
            this.groupBox2.Controls.Add(this.labelFileName);
            this.groupBox2.Controls.Add(this.labelProcessStatus);
            this.groupBox2.Controls.Add(this.labelProcessNum);
            this.groupBox2.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(13, 560);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(548, 214);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resize process infomation";
            // 
            // labelFolderPath
            // 
            this.labelFolderPath.AutoSize = true;
            this.labelFolderPath.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFolderPath.Location = new System.Drawing.Point(26, 113);
            this.labelFolderPath.MaximumSize = new System.Drawing.Size(500, 50);
            this.labelFolderPath.Name = "labelFolderPath";
            this.labelFolderPath.Size = new System.Drawing.Size(94, 23);
            this.labelFolderPath.TabIndex = 26;
            this.labelFolderPath.Text = "Folder path";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(10, 499);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "4. Start resize images ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(10, 431);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(383, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "3. Input padding color (RGBA 32bit Hex)";
            // 
            // textBoxHexColor
            // 
            this.textBoxHexColor.Font = new System.Drawing.Font("メイリオ", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxHexColor.Location = new System.Drawing.Point(398, 427);
            this.textBoxHexColor.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxHexColor.Name = "textBoxHexColor";
            this.textBoxHexColor.Size = new System.Drawing.Size(148, 35);
            this.textBoxHexColor.TabIndex = 29;
            this.textBoxHexColor.Text = "0x00000000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(11, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(251, 25);
            this.label9.TabIndex = 30;
            this.label9.Text = "2. Select contents position";
            // 
            // buttonPosition4
            // 
            this.buttonPosition4.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition4.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition4.Location = new System.Drawing.Point(468, 324);
            this.buttonPosition4.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition4.Name = "buttonPosition4";
            this.buttonPosition4.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition4.TabIndex = 31;
            this.buttonPosition4.UseVisualStyleBackColor = false;
            this.buttonPosition4.Click += new System.EventHandler(this.ButtonPosition4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(466, 322);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPosition7
            // 
            this.buttonPosition7.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition7.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition7.Location = new System.Drawing.Point(468, 370);
            this.buttonPosition7.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition7.Name = "buttonPosition7";
            this.buttonPosition7.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition7.TabIndex = 33;
            this.buttonPosition7.UseVisualStyleBackColor = false;
            this.buttonPosition7.Click += new System.EventHandler(this.ButtonPosition7_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(466, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPosition1
            // 
            this.buttonPosition1.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition1.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition1.Location = new System.Drawing.Point(468, 278);
            this.buttonPosition1.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition1.Name = "buttonPosition1";
            this.buttonPosition1.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition1.TabIndex = 35;
            this.buttonPosition1.UseVisualStyleBackColor = false;
            this.buttonPosition1.Click += new System.EventHandler(this.ButtonPosition1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(466, 278);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // buttonPosition0
            // 
            this.buttonPosition0.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition0.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition0.Location = new System.Drawing.Point(420, 278);
            this.buttonPosition0.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition0.Name = "buttonPosition0";
            this.buttonPosition0.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition0.TabIndex = 37;
            this.buttonPosition0.UseVisualStyleBackColor = false;
            this.buttonPosition0.Click += new System.EventHandler(this.ButtonPosition0_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox4.Location = new System.Drawing.Point(420, 278);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // buttonPosition3
            // 
            this.buttonPosition3.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition3.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition3.Location = new System.Drawing.Point(420, 324);
            this.buttonPosition3.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition3.Name = "buttonPosition3";
            this.buttonPosition3.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition3.TabIndex = 39;
            this.buttonPosition3.UseVisualStyleBackColor = false;
            this.buttonPosition3.Click += new System.EventHandler(this.ButtonPosition3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox5.Location = new System.Drawing.Point(420, 322);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(35, 35);
            this.pictureBox5.TabIndex = 40;
            this.pictureBox5.TabStop = false;
            // 
            // buttonPosition6
            // 
            this.buttonPosition6.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition6.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition6.Location = new System.Drawing.Point(420, 370);
            this.buttonPosition6.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition6.Name = "buttonPosition6";
            this.buttonPosition6.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition6.TabIndex = 41;
            this.buttonPosition6.UseVisualStyleBackColor = false;
            this.buttonPosition6.Click += new System.EventHandler(this.ButtonPosition6_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox6.Location = new System.Drawing.Point(420, 364);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.TabIndex = 42;
            this.pictureBox6.TabStop = false;
            // 
            // buttonPosition2
            // 
            this.buttonPosition2.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition2.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition2.Location = new System.Drawing.Point(517, 278);
            this.buttonPosition2.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition2.Name = "buttonPosition2";
            this.buttonPosition2.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition2.TabIndex = 43;
            this.buttonPosition2.UseVisualStyleBackColor = false;
            this.buttonPosition2.Click += new System.EventHandler(this.ButtonPosition2_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Location = new System.Drawing.Point(511, 278);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(35, 35);
            this.pictureBox7.TabIndex = 44;
            this.pictureBox7.TabStop = false;
            // 
            // buttonPosition5
            // 
            this.buttonPosition5.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition5.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition5.Location = new System.Drawing.Point(517, 324);
            this.buttonPosition5.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition5.Name = "buttonPosition5";
            this.buttonPosition5.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition5.TabIndex = 45;
            this.buttonPosition5.UseVisualStyleBackColor = false;
            this.buttonPosition5.Click += new System.EventHandler(this.ButtonPosition5_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox8.Location = new System.Drawing.Point(511, 322);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.TabIndex = 46;
            this.pictureBox8.TabStop = false;
            // 
            // buttonPosition8
            // 
            this.buttonPosition8.BackColor = System.Drawing.Color.Transparent;
            this.buttonPosition8.BackgroundImage = global::ImageX4Resize.Properties.Resources.flower;
            this.buttonPosition8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonPosition8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPosition8.Location = new System.Drawing.Point(517, 370);
            this.buttonPosition8.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPosition8.Name = "buttonPosition8";
            this.buttonPosition8.Size = new System.Drawing.Size(29, 29);
            this.buttonPosition8.TabIndex = 47;
            this.buttonPosition8.UseVisualStyleBackColor = false;
            this.buttonPosition8.Click += new System.EventHandler(this.ButtonPosition8_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox9.Location = new System.Drawing.Point(511, 364);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(35, 35);
            this.pictureBox9.TabIndex = 48;
            this.pictureBox9.TabStop = false;
            // 
            // SelectPosition3
            // 
            this.SelectPosition3.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition3.Location = new System.Drawing.Point(415, 317);
            this.SelectPosition3.Name = "SelectPosition3";
            this.SelectPosition3.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition3.TabIndex = 50;
            this.SelectPosition3.TabStop = false;
            // 
            // SelectPosition0
            // 
            this.SelectPosition0.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition0.Location = new System.Drawing.Point(415, 273);
            this.SelectPosition0.Name = "SelectPosition0";
            this.SelectPosition0.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition0.TabIndex = 51;
            this.SelectPosition0.TabStop = false;
            // 
            // SelectPosition1
            // 
            this.SelectPosition1.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition1.Location = new System.Drawing.Point(461, 273);
            this.SelectPosition1.Name = "SelectPosition1";
            this.SelectPosition1.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition1.TabIndex = 52;
            this.SelectPosition1.TabStop = false;
            // 
            // SelectPosition2
            // 
            this.SelectPosition2.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition2.Location = new System.Drawing.Point(507, 273);
            this.SelectPosition2.Name = "SelectPosition2";
            this.SelectPosition2.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition2.TabIndex = 53;
            this.SelectPosition2.TabStop = false;
            // 
            // SelectPosition4
            // 
            this.SelectPosition4.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition4.Location = new System.Drawing.Point(461, 317);
            this.SelectPosition4.Name = "SelectPosition4";
            this.SelectPosition4.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition4.TabIndex = 54;
            this.SelectPosition4.TabStop = false;
            // 
            // SelectPosition5
            // 
            this.SelectPosition5.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition5.Location = new System.Drawing.Point(507, 317);
            this.SelectPosition5.Name = "SelectPosition5";
            this.SelectPosition5.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition5.TabIndex = 55;
            this.SelectPosition5.TabStop = false;
            // 
            // SelectPosition6
            // 
            this.SelectPosition6.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition6.Location = new System.Drawing.Point(415, 359);
            this.SelectPosition6.Name = "SelectPosition6";
            this.SelectPosition6.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition6.TabIndex = 56;
            this.SelectPosition6.TabStop = false;
            // 
            // SelectPosition7
            // 
            this.SelectPosition7.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition7.Location = new System.Drawing.Point(461, 359);
            this.SelectPosition7.Name = "SelectPosition7";
            this.SelectPosition7.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition7.TabIndex = 57;
            this.SelectPosition7.TabStop = false;
            // 
            // SelectPosition8
            // 
            this.SelectPosition8.BackColor = System.Drawing.Color.OrangeRed;
            this.SelectPosition8.Location = new System.Drawing.Point(507, 359);
            this.SelectPosition8.Name = "SelectPosition8";
            this.SelectPosition8.Size = new System.Drawing.Size(44, 44);
            this.SelectPosition8.TabIndex = 58;
            this.SelectPosition8.TabStop = false;
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(576, 785);
            this.Controls.Add(this.buttonPosition0);
            this.Controls.Add(this.buttonPosition8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.buttonPosition5);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.buttonPosition2);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.buttonPosition6);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.buttonPosition3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.buttonPosition1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonPosition7);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonPosition4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxHexColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonConvertStart);
            this.Controls.Add(this.buttonRootFolderSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxRootFolder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectPosition3);
            this.Controls.Add(this.SelectPosition0);
            this.Controls.Add(this.SelectPosition1);
            this.Controls.Add(this.SelectPosition2);
            this.Controls.Add(this.SelectPosition4);
            this.Controls.Add(this.SelectPosition5);
            this.Controls.Add(this.SelectPosition6);
            this.Controls.Add(this.SelectPosition7);
            this.Controls.Add(this.SelectPosition8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ResizeForm";
            this.Text = "ImageX4Resize";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectPosition8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonRefresh;
        private Label labelTotalFolderNum;
        private Label labelImageNum;
        private Label label5;
        private Label label4;
        private Button buttonRootFolderSelect;
        private Label label1;
        private TextBox textBoxRootFolder;
        private Label labelFileName;
        private Label labelProcessNum;
        private Label label2;
        private Label labelProcessStatus;
        private Label label3;
        private Button buttonConvertStart;
        private System.ComponentModel.BackgroundWorker imageAdjustBackgroundWorker;
        private ProgressBar processProgressBar;
        private Label label6;
        private GroupBox groupBox2;
        private Label label7;
        private Label label8;
        private TextBox textBoxHexColor;
        private Label label9;
        private Button buttonPosition4;
        private PictureBox pictureBox1;
        private Button buttonPosition7;
        private PictureBox pictureBox2;
        private Button buttonPosition1;
        private PictureBox pictureBox3;
        private Button buttonPosition0;
        private PictureBox pictureBox4;
        private Button buttonPosition3;
        private PictureBox pictureBox5;
        private Button buttonPosition6;
        private PictureBox pictureBox6;
        private Button buttonPosition2;
        private PictureBox pictureBox7;
        private Button buttonPosition5;
        private PictureBox pictureBox8;
        private Button buttonPosition8;
        private PictureBox pictureBox9;
        private PictureBox SelectPosition3;
        private PictureBox SelectPosition0;
        private PictureBox SelectPosition1;
        private PictureBox SelectPosition2;
        private PictureBox SelectPosition4;
        private PictureBox SelectPosition5;
        private PictureBox SelectPosition6;
        private PictureBox SelectPosition7;
        private PictureBox SelectPosition8;
        private Label labelFolderPath;
    }
}