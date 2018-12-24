namespace WindowsFormsApp3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.CreateTab = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl2 = new MetroFramework.Controls.MetroTabControl();
            this.folderLoc = new MetroFramework.Controls.MetroTabPage();
            this.btnNext = new MetroFramework.Controls.MetroButton();
            this.chk2 = new MetroFramework.Controls.MetroCheckBox();
            this.chk1 = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.selectBtn = new MetroFramework.Controls.MetroButton();
            this.txtFolderLocation = new MetroFramework.Controls.MetroTextBox();
            this.FilesTab = new System.Windows.Forms.TabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.encry1 = new System.Windows.Forms.TabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.savePoint = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnEncrypt = new MetroFramework.Controls.MetroButton();
            this.randomPassChk = new MetroFramework.Controls.MetroCheckBox();
            this.passranBtn = new MetroFramework.Controls.MetroButton();
            this.recoveryChks = new MetroFramework.Controls.MetroCheckBox();
            this.txtpassconfirm = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtpassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.folderEncryAlgo = new MetroFramework.Controls.MetroCheckBox();
            this.filesEncryHashed = new MetroFramework.Controls.MetroCheckBox();
            this.hashingCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.OpenTab = new System.Windows.Forms.TabPage();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.btnLockFolder = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnSelectFolder = new MetroFramework.Controls.MetroButton();
            this.btnUnlockFolder = new MetroFramework.Controls.MetroButton();
            this.txtFolderSelection = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.txtboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.txtboxUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.metroTabControl1.SuspendLayout();
            this.CreateTab.SuspendLayout();
            this.metroTabControl2.SuspendLayout();
            this.folderLoc.SuspendLayout();
            this.FilesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.encry1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.OpenTab.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.CreateTab);
            this.metroTabControl1.Controls.Add(this.OpenTab);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(776, 426);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // CreateTab
            // 
            this.CreateTab.Controls.Add(this.metroTabControl2);
            this.CreateTab.HorizontalScrollbarBarColor = true;
            this.CreateTab.HorizontalScrollbarHighlightOnWheel = false;
            this.CreateTab.HorizontalScrollbarSize = 10;
            this.CreateTab.Location = new System.Drawing.Point(4, 38);
            this.CreateTab.Name = "CreateTab";
            this.CreateTab.Size = new System.Drawing.Size(768, 384);
            this.CreateTab.TabIndex = 0;
            this.CreateTab.Text = "Create SavePoint";
            this.CreateTab.VerticalScrollbarBarColor = true;
            this.CreateTab.VerticalScrollbarHighlightOnWheel = false;
            this.CreateTab.VerticalScrollbarSize = 10;
            // 
            // metroTabControl2
            // 
            this.metroTabControl2.Controls.Add(this.folderLoc);
            this.metroTabControl2.Controls.Add(this.FilesTab);
            this.metroTabControl2.Controls.Add(this.encry1);
            this.metroTabControl2.Location = new System.Drawing.Point(3, 3);
            this.metroTabControl2.Name = "metroTabControl2";
            this.metroTabControl2.SelectedIndex = 2;
            this.metroTabControl2.Size = new System.Drawing.Size(753, 370);
            this.metroTabControl2.TabIndex = 2;
            this.metroTabControl2.UseSelectable = true;
            // 
            // folderLoc
            // 
            this.folderLoc.Controls.Add(this.btnNext);
            this.folderLoc.Controls.Add(this.chk2);
            this.folderLoc.Controls.Add(this.chk1);
            this.folderLoc.Controls.Add(this.metroLabel1);
            this.folderLoc.Controls.Add(this.selectBtn);
            this.folderLoc.Controls.Add(this.txtFolderLocation);
            this.folderLoc.HorizontalScrollbarBarColor = true;
            this.folderLoc.HorizontalScrollbarHighlightOnWheel = false;
            this.folderLoc.HorizontalScrollbarSize = 10;
            this.folderLoc.Location = new System.Drawing.Point(4, 38);
            this.folderLoc.Name = "folderLoc";
            this.folderLoc.Size = new System.Drawing.Size(745, 328);
            this.folderLoc.TabIndex = 0;
            this.folderLoc.Text = "Folder Location";
            this.folderLoc.VerticalScrollbarBarColor = true;
            this.folderLoc.VerticalScrollbarHighlightOnWheel = false;
            this.folderLoc.VerticalScrollbarSize = 10;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(13, 116);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(108, 29);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = "Next";
            this.btnNext.UseSelectable = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Enabled = false;
            this.chk2.Location = new System.Drawing.Point(10, 90);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(112, 15);
            this.chk2.TabIndex = 6;
            this.chk2.Text = "Folder Have Files";
            this.chk2.UseSelectable = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.Enabled = false;
            this.chk1.Location = new System.Drawing.Point(10, 69);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(103, 15);
            this.chk1.TabIndex = 5;
            this.chk1.Text = "Selected Folder";
            this.chk1.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(10, 154);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(730, 76);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(384, 20);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(117, 32);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "Select Folder";
            this.selectBtn.UseSelectable = true;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // txtFolderLocation
            // 
            // 
            // 
            // 
            this.txtFolderLocation.CustomButton.Image = null;
            this.txtFolderLocation.CustomButton.Location = new System.Drawing.Point(334, 1);
            this.txtFolderLocation.CustomButton.Name = "";
            this.txtFolderLocation.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtFolderLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderLocation.CustomButton.TabIndex = 1;
            this.txtFolderLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderLocation.CustomButton.UseSelectable = true;
            this.txtFolderLocation.CustomButton.Visible = false;
            this.txtFolderLocation.Enabled = false;
            this.txtFolderLocation.Lines = new string[0];
            this.txtFolderLocation.Location = new System.Drawing.Point(10, 17);
            this.txtFolderLocation.MaxLength = 32767;
            this.txtFolderLocation.Name = "txtFolderLocation";
            this.txtFolderLocation.PasswordChar = '\0';
            this.txtFolderLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderLocation.SelectedText = "";
            this.txtFolderLocation.SelectionLength = 0;
            this.txtFolderLocation.SelectionStart = 0;
            this.txtFolderLocation.ShortcutsEnabled = true;
            this.txtFolderLocation.Size = new System.Drawing.Size(368, 35);
            this.txtFolderLocation.TabIndex = 2;
            this.txtFolderLocation.UseSelectable = true;
            this.txtFolderLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FilesTab
            // 
            this.FilesTab.Controls.Add(this.metroLabel7);
            this.FilesTab.Controls.Add(this.metroButton1);
            this.FilesTab.Controls.Add(this.metroGrid1);
            this.FilesTab.Location = new System.Drawing.Point(4, 38);
            this.FilesTab.Name = "FilesTab";
            this.FilesTab.Size = new System.Drawing.Size(745, 328);
            this.FilesTab.TabIndex = 2;
            this.FilesTab.Text = "Files";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(512, 61);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(237, 152);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = resources.GetString("metroLabel7.Text");
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(510, 14);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(169, 29);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Update Files PassWord";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 3);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(493, 311);
            this.metroGrid1.TabIndex = 0;
            this.metroGrid1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellEndEdit);
            // 
            // encry1
            // 
            this.encry1.Controls.Add(this.metroPanel2);
            this.encry1.Controls.Add(this.metroPanel1);
            this.encry1.Location = new System.Drawing.Point(4, 38);
            this.encry1.Name = "encry1";
            this.encry1.Size = new System.Drawing.Size(745, 328);
            this.encry1.TabIndex = 1;
            this.encry1.Text = "Encryption Options";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.savePoint);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.btnEncrypt);
            this.metroPanel2.Controls.Add(this.randomPassChk);
            this.metroPanel2.Controls.Add(this.passranBtn);
            this.metroPanel2.Controls.Add(this.recoveryChks);
            this.metroPanel2.Controls.Add(this.txtpassconfirm);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.txtpassword);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(290, 15);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(452, 267);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // savePoint
            // 
            this.savePoint.AutoSize = true;
            this.savePoint.FontSize = MetroFramework.MetroLabelSize.Small;
            this.savePoint.Location = new System.Drawing.Point(5, 222);
            this.savePoint.Name = "savePoint";
            this.savePoint.Size = new System.Drawing.Size(110, 19);
            this.savePoint.TabIndex = 9;
            this.savePoint.Text = "Folder Save Here";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(3, 151);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(436, 60);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = resources.GetString("metroLabel6.Text");
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(3, 103);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(174, 36);
            this.btnEncrypt.TabIndex = 9;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseSelectable = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // randomPassChk
            // 
            this.randomPassChk.AutoSize = true;
            this.randomPassChk.Enabled = false;
            this.randomPassChk.Location = new System.Drawing.Point(231, 39);
            this.randomPassChk.Name = "randomPassChk";
            this.randomPassChk.Size = new System.Drawing.Size(151, 15);
            this.randomPassChk.TabIndex = 8;
            this.randomPassChk.Text = "Random Pass Generated";
            this.randomPassChk.UseSelectable = true;
            // 
            // passranBtn
            // 
            this.passranBtn.Location = new System.Drawing.Point(197, 104);
            this.passranBtn.Name = "passranBtn";
            this.passranBtn.Size = new System.Drawing.Size(162, 35);
            this.passranBtn.TabIndex = 7;
            this.passranBtn.Text = "Generate Random Password";
            this.passranBtn.UseSelectable = true;
            // 
            // recoveryChks
            // 
            this.recoveryChks.AutoSize = true;
            this.recoveryChks.Location = new System.Drawing.Point(231, 9);
            this.recoveryChks.Name = "recoveryChks";
            this.recoveryChks.Size = new System.Drawing.Size(150, 15);
            this.recoveryChks.TabIndex = 6;
            this.recoveryChks.Text = "Encrypt Recovery Folder";
            this.recoveryChks.UseSelectable = true;
            // 
            // txtpassconfirm
            // 
            // 
            // 
            // 
            this.txtpassconfirm.CustomButton.Image = null;
            this.txtpassconfirm.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtpassconfirm.CustomButton.Name = "";
            this.txtpassconfirm.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassconfirm.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassconfirm.CustomButton.TabIndex = 1;
            this.txtpassconfirm.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassconfirm.CustomButton.UseSelectable = true;
            this.txtpassconfirm.CustomButton.Visible = false;
            this.txtpassconfirm.Lines = new string[0];
            this.txtpassconfirm.Location = new System.Drawing.Point(3, 74);
            this.txtpassconfirm.MaxLength = 32767;
            this.txtpassconfirm.Name = "txtpassconfirm";
            this.txtpassconfirm.PasswordChar = '\0';
            this.txtpassconfirm.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassconfirm.SelectedText = "";
            this.txtpassconfirm.SelectionLength = 0;
            this.txtpassconfirm.SelectionStart = 0;
            this.txtpassconfirm.ShortcutsEnabled = true;
            this.txtpassconfirm.Size = new System.Drawing.Size(204, 23);
            this.txtpassconfirm.TabIndex = 5;
            this.txtpassconfirm.UseSelectable = true;
            this.txtpassconfirm.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassconfirm.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 57);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(106, 19);
            this.metroLabel5.TabIndex = 4;
            this.metroLabel5.Text = "Folder Confirm :";
            // 
            // txtpassword
            // 
            // 
            // 
            // 
            this.txtpassword.CustomButton.Image = null;
            this.txtpassword.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtpassword.CustomButton.Name = "";
            this.txtpassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtpassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtpassword.CustomButton.TabIndex = 1;
            this.txtpassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtpassword.CustomButton.UseSelectable = true;
            this.txtpassword.CustomButton.Visible = false;
            this.txtpassword.Lines = new string[0];
            this.txtpassword.Location = new System.Drawing.Point(3, 31);
            this.txtpassword.MaxLength = 32767;
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtpassword.SelectedText = "";
            this.txtpassword.SelectionLength = 0;
            this.txtpassword.SelectionStart = 0;
            this.txtpassword.ShortcutsEnabled = true;
            this.txtpassword.Size = new System.Drawing.Size(204, 23);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.UseSelectable = true;
            this.txtpassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtpassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 9);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(112, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Folder Password :";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.folderEncryAlgo);
            this.metroPanel1.Controls.Add(this.filesEncryHashed);
            this.metroPanel1.Controls.Add(this.hashingCombo);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroComboBox1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(13, 15);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(271, 267);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // folderEncryAlgo
            // 
            this.folderEncryAlgo.AutoSize = true;
            this.folderEncryAlgo.Enabled = false;
            this.folderEncryAlgo.Location = new System.Drawing.Point(6, 161);
            this.folderEncryAlgo.Name = "folderEncryAlgo";
            this.folderEncryAlgo.Size = new System.Drawing.Size(196, 15);
            this.folderEncryAlgo.TabIndex = 8;
            this.folderEncryAlgo.Text = "Encryption Algorithm for Folders";
            this.folderEncryAlgo.UseSelectable = true;
            // 
            // filesEncryHashed
            // 
            this.filesEncryHashed.AutoSize = true;
            this.filesEncryHashed.Enabled = false;
            this.filesEncryHashed.Location = new System.Drawing.Point(6, 140);
            this.filesEncryHashed.Name = "filesEncryHashed";
            this.filesEncryHashed.Size = new System.Drawing.Size(175, 15);
            this.filesEncryHashed.TabIndex = 7;
            this.filesEncryHashed.Text = "Hashing Algorithmn for Files";
            this.filesEncryHashed.UseSelectable = true;
            // 
            // hashingCombo
            // 
            this.hashingCombo.FormattingEnabled = true;
            this.hashingCombo.ItemHeight = 23;
            this.hashingCombo.Location = new System.Drawing.Point(6, 96);
            this.hashingCombo.Name = "hashingCombo";
            this.hashingCombo.PromptText = "SHA-384 (48)";
            this.hashingCombo.Size = new System.Drawing.Size(206, 29);
            this.hashingCombo.TabIndex = 6;
            this.hashingCombo.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(6, 74);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(118, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Hashing Algorithm";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(6, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(134, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Encryption Algorithm";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "AES"});
            this.metroComboBox1.Location = new System.Drawing.Point(6, 31);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "AES";
            this.metroComboBox1.Size = new System.Drawing.Size(206, 29);
            this.metroComboBox1.TabIndex = 2;
            this.metroComboBox1.UseSelectable = true;
            // 
            // OpenTab
            // 
            this.OpenTab.Controls.Add(this.metroPanel4);
            this.OpenTab.Controls.Add(this.metroPanel3);
            this.OpenTab.Location = new System.Drawing.Point(4, 38);
            this.OpenTab.Name = "OpenTab";
            this.OpenTab.Size = new System.Drawing.Size(768, 384);
            this.OpenTab.TabIndex = 1;
            this.OpenTab.Text = "Open SavePoint";
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.btnLockFolder);
            this.metroPanel4.Controls.Add(this.metroLabel10);
            this.metroPanel4.Controls.Add(this.btnSelectFolder);
            this.metroPanel4.Controls.Add(this.btnUnlockFolder);
            this.metroPanel4.Controls.Add(this.txtFolderSelection);
            this.metroPanel4.Controls.Add(this.metroLabel12);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(359, 48);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(384, 288);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // btnLockFolder
            // 
            this.btnLockFolder.Location = new System.Drawing.Point(108, 225);
            this.btnLockFolder.Name = "btnLockFolder";
            this.btnLockFolder.Size = new System.Drawing.Size(154, 35);
            this.btnLockFolder.TabIndex = 11;
            this.btnLockFolder.Text = "Lock Folder";
            this.btnLockFolder.UseSelectable = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(16, 22);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(355, 45);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Specify folder location that you wish to unlock and view \r\ncontents. Once complet" +
    "ed, lock the folder to prevent security \r\nbreach.";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(31, 130);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(314, 36);
            this.btnSelectFolder.TabIndex = 9;
            this.btnSelectFolder.Text = "Select Folder";
            this.btnSelectFolder.UseSelectable = true;
            // 
            // btnUnlockFolder
            // 
            this.btnUnlockFolder.Location = new System.Drawing.Point(108, 183);
            this.btnUnlockFolder.Name = "btnUnlockFolder";
            this.btnUnlockFolder.Size = new System.Drawing.Size(154, 36);
            this.btnUnlockFolder.TabIndex = 9;
            this.btnUnlockFolder.Text = "Unlock Folder";
            this.btnUnlockFolder.UseSelectable = true;
            // 
            // txtFolderSelection
            // 
            // 
            // 
            // 
            this.txtFolderSelection.CustomButton.Image = null;
            this.txtFolderSelection.CustomButton.Location = new System.Drawing.Point(292, 1);
            this.txtFolderSelection.CustomButton.Name = "";
            this.txtFolderSelection.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFolderSelection.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFolderSelection.CustomButton.TabIndex = 1;
            this.txtFolderSelection.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFolderSelection.CustomButton.UseSelectable = true;
            this.txtFolderSelection.CustomButton.Visible = false;
            this.txtFolderSelection.Lines = new string[0];
            this.txtFolderSelection.Location = new System.Drawing.Point(31, 100);
            this.txtFolderSelection.MaxLength = 32767;
            this.txtFolderSelection.Name = "txtFolderSelection";
            this.txtFolderSelection.PasswordChar = '\0';
            this.txtFolderSelection.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFolderSelection.SelectedText = "";
            this.txtFolderSelection.SelectionLength = 0;
            this.txtFolderSelection.SelectionStart = 0;
            this.txtFolderSelection.ShortcutsEnabled = true;
            this.txtFolderSelection.Size = new System.Drawing.Size(314, 23);
            this.txtFolderSelection.TabIndex = 3;
            this.txtFolderSelection.UseSelectable = true;
            this.txtFolderSelection.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFolderSelection.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(31, 78);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(106, 19);
            this.metroLabel12.TabIndex = 2;
            this.metroLabel12.Text = "Folder Selection:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.txtboxPassword);
            this.metroPanel3.Controls.Add(this.metroLabel9);
            this.metroPanel3.Controls.Add(this.txtboxUser);
            this.metroPanel3.Controls.Add(this.metroLabel11);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(25, 48);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(328, 182);
            this.metroPanel3.TabIndex = 4;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel8.Location = new System.Drawing.Point(28, 22);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(250, 45);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Insert username and password credentials\r\nbefore attempting to unlock/lock specif" +
    "ied \r\nfolder contents.";
            // 
            // txtboxPassword
            // 
            // 
            // 
            // 
            this.txtboxPassword.CustomButton.Image = null;
            this.txtboxPassword.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtboxPassword.CustomButton.Name = "";
            this.txtboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxPassword.CustomButton.TabIndex = 1;
            this.txtboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxPassword.CustomButton.UseSelectable = true;
            this.txtboxPassword.CustomButton.Visible = false;
            this.txtboxPassword.Lines = new string[0];
            this.txtboxPassword.Location = new System.Drawing.Point(28, 141);
            this.txtboxPassword.MaxLength = 32767;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '\0';
            this.txtboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionLength = 0;
            this.txtboxPassword.SelectionStart = 0;
            this.txtboxPassword.ShortcutsEnabled = true;
            this.txtboxPassword.Size = new System.Drawing.Size(204, 23);
            this.txtboxPassword.TabIndex = 5;
            this.txtboxPassword.UseSelectable = true;
            this.txtboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(28, 124);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(147, 19);
            this.metroLabel9.TabIndex = 4;
            this.metroLabel9.Text = "Password Confirmation:";
            // 
            // txtboxUser
            // 
            // 
            // 
            // 
            this.txtboxUser.CustomButton.Image = null;
            this.txtboxUser.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.txtboxUser.CustomButton.Name = "";
            this.txtboxUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxUser.CustomButton.TabIndex = 1;
            this.txtboxUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxUser.CustomButton.UseSelectable = true;
            this.txtboxUser.CustomButton.Visible = false;
            this.txtboxUser.Lines = new string[0];
            this.txtboxUser.Location = new System.Drawing.Point(28, 98);
            this.txtboxUser.MaxLength = 32767;
            this.txtboxUser.Name = "txtboxUser";
            this.txtboxUser.PasswordChar = '\0';
            this.txtboxUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxUser.SelectedText = "";
            this.txtboxUser.SelectionLength = 0;
            this.txtboxUser.SelectionStart = 0;
            this.txtboxUser.ShortcutsEnabled = true;
            this.txtboxUser.Size = new System.Drawing.Size(204, 23);
            this.txtboxUser.TabIndex = 3;
            this.txtboxUser.UseSelectable = true;
            this.txtboxUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(28, 76);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(119, 19);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "User Confirmation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 460);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.metroTabControl1.ResumeLayout(false);
            this.CreateTab.ResumeLayout(false);
            this.metroTabControl2.ResumeLayout(false);
            this.folderLoc.ResumeLayout(false);
            this.folderLoc.PerformLayout();
            this.FilesTab.ResumeLayout(false);
            this.FilesTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.encry1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.OpenTab.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage CreateTab;
        private MetroFramework.Controls.MetroTabControl metroTabControl2;
        private System.Windows.Forms.TabPage OpenTab;
        private MetroFramework.Controls.MetroTabPage folderLoc;
        private System.Windows.Forms.TabPage encry1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton selectBtn;
        private MetroFramework.Controls.MetroTextBox txtFolderLocation;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private MetroFramework.Controls.MetroCheckBox chk2;
        private MetroFramework.Controls.MetroCheckBox chk1;
        private MetroFramework.Controls.MetroButton btnNext;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroComboBox hashingCombo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroCheckBox filesEncryHashed;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroCheckBox folderEncryAlgo;
        private MetroFramework.Controls.MetroButton passranBtn;
        private MetroFramework.Controls.MetroCheckBox recoveryChks;
        private MetroFramework.Controls.MetroTextBox txtpassconfirm;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtpassword;
        private MetroFramework.Controls.MetroCheckBox randomPassChk;
        private MetroFramework.Controls.MetroButton btnEncrypt;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.TabPage FilesTab;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel savePoint;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton btnLockFolder;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnSelectFolder;
        private MetroFramework.Controls.MetroButton btnUnlockFolder;
        private MetroFramework.Controls.MetroTextBox txtFolderSelection;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox txtboxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox txtboxUser;
        private MetroFramework.Controls.MetroLabel metroLabel11;
    }
}

