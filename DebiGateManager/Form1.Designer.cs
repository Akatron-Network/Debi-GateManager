
namespace DebiGateManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.mainpage = new System.Windows.Forms.TabPage();
            this.Run_BTN = new MaterialSkin.Controls.MaterialRaisedButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Login_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.Logout_BTN = new MaterialSkin.Controls.MaterialFlatButton();
            this.password_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.username_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.Service_State_TB = new MaterialSkin.Controls.MaterialLabel();
            this.settingspage = new System.Windows.Forms.TabPage();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.Auto_Start_CB = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Path_Gateway_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIGATEPATH_DBSCHEME_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIGATEPATH_DBTRANSLATE_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIGATEPATH_CONNECTOR_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIGATEPATH_COLLECTIONS_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIGATEPATH_AUTH_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.LANGUAGE_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIPORT = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.APIHOST_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Path_Node_TB = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ConsoleTB = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.ServiceRunCTRL = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.NotifyMenuStrip = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.Open = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.Exit = new MaterialSkin.Controls.MaterialToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.autostarter = new System.Windows.Forms.Timer(this.components);
            this.materialTabControl1.SuspendLayout();
            this.mainpage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.settingspage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NotifyMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabControl1.Controls.Add(this.mainpage);
            this.materialTabControl1.Controls.Add(this.settingspage);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 67);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(496, 427);
            this.materialTabControl1.TabIndex = 2;
            // 
            // mainpage
            // 
            this.mainpage.BackColor = System.Drawing.Color.LightGray;
            this.mainpage.Controls.Add(this.Run_BTN);
            this.mainpage.Controls.Add(this.groupBox1);
            this.mainpage.Controls.Add(this.materialDivider1);
            this.mainpage.Controls.Add(this.Service_State_TB);
            this.mainpage.Location = new System.Drawing.Point(4, 24);
            this.mainpage.Name = "mainpage";
            this.mainpage.Padding = new System.Windows.Forms.Padding(3);
            this.mainpage.Size = new System.Drawing.Size(488, 399);
            this.mainpage.TabIndex = 0;
            this.mainpage.Text = "Ana Sayfa";
            // 
            // Run_BTN
            // 
            this.Run_BTN.Depth = 0;
            this.Run_BTN.Location = new System.Drawing.Point(149, 249);
            this.Run_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Run_BTN.Name = "Run_BTN";
            this.Run_BTN.Primary = true;
            this.Run_BTN.Size = new System.Drawing.Size(199, 55);
            this.Run_BTN.TabIndex = 7;
            this.Run_BTN.Text = "RUN SERVICE";
            this.Run_BTN.UseVisualStyleBackColor = true;
            this.Run_BTN.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.Login_BTN);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.Logout_BTN);
            this.groupBox1.Controls.Add(this.password_TB);
            this.groupBox1.Controls.Add(this.materialLabel4);
            this.groupBox1.Controls.Add(this.username_TB);
            this.groupBox1.Controls.Add(this.materialLabel5);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(54, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 178);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // Login_BTN
            // 
            this.Login_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_BTN.AutoSize = true;
            this.Login_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Login_BTN.Depth = 0;
            this.Login_BTN.Enabled = false;
            this.Login_BTN.Location = new System.Drawing.Point(327, 128);
            this.Login_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Login_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Login_BTN.Name = "Login_BTN";
            this.Login_BTN.Primary = false;
            this.Login_BTN.Size = new System.Drawing.Size(55, 36);
            this.Login_BTN.TabIndex = 3;
            this.Login_BTN.Text = "LOG IN";
            this.Login_BTN.UseVisualStyleBackColor = true;
            this.Login_BTN.Click += new System.EventHandler(this.Login_BTN_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(6, 19);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(107, 19);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Authentication";
            // 
            // Logout_BTN
            // 
            this.Logout_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Logout_BTN.AutoSize = true;
            this.Logout_BTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout_BTN.Depth = 0;
            this.Logout_BTN.Location = new System.Drawing.Point(317, 15);
            this.Logout_BTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout_BTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout_BTN.Name = "Logout_BTN";
            this.Logout_BTN.Primary = true;
            this.Logout_BTN.Size = new System.Drawing.Size(65, 36);
            this.Logout_BTN.TabIndex = 4;
            this.Logout_BTN.Text = "LogOut";
            this.Logout_BTN.UseVisualStyleBackColor = true;
            this.Logout_BTN.Click += new System.EventHandler(this.Logout_BTN_Click);
            // 
            // password_TB
            // 
            this.password_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_TB.Depth = 0;
            this.password_TB.Enabled = false;
            this.password_TB.Hint = "";
            this.password_TB.Location = new System.Drawing.Point(94, 96);
            this.password_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.password_TB.Name = "password_TB";
            this.password_TB.PasswordChar = '*';
            this.password_TB.SelectedText = "";
            this.password_TB.SelectionLength = 0;
            this.password_TB.SelectionStart = 0;
            this.password_TB.Size = new System.Drawing.Size(289, 23);
            this.password_TB.TabIndex = 2;
            this.password_TB.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(6, 60);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(44, 19);
            this.materialLabel4.TabIndex = 2;
            this.materialLabel4.Text = "User:";
            // 
            // username_TB
            // 
            this.username_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username_TB.Depth = 0;
            this.username_TB.Enabled = false;
            this.username_TB.Hint = "";
            this.username_TB.Location = new System.Drawing.Point(94, 60);
            this.username_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.username_TB.Name = "username_TB";
            this.username_TB.PasswordChar = '\0';
            this.username_TB.SelectedText = "";
            this.username_TB.SelectionLength = 0;
            this.username_TB.SelectionStart = 0;
            this.username_TB.Size = new System.Drawing.Size(289, 23);
            this.username_TB.TabIndex = 1;
            this.username_TB.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(6, 96);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(79, 19);
            this.materialLabel5.TabIndex = 2;
            this.materialLabel5.Text = "Password:";
            // 
            // materialDivider1
            // 
            this.materialDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(-4, 43);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(495, 10);
            this.materialDivider1.TabIndex = 3;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // Service_State_TB
            // 
            this.Service_State_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Service_State_TB.AutoSize = true;
            this.Service_State_TB.Depth = 0;
            this.Service_State_TB.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Service_State_TB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Service_State_TB.Location = new System.Drawing.Point(194, 11);
            this.Service_State_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Service_State_TB.Name = "Service_State_TB";
            this.Service_State_TB.Size = new System.Drawing.Size(108, 19);
            this.Service_State_TB.TabIndex = 1;
            this.Service_State_TB.Text = "Service: Active";
            this.Service_State_TB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // settingspage
            // 
            this.settingspage.BackColor = System.Drawing.Color.LightGray;
            this.settingspage.Controls.Add(this.materialDivider2);
            this.settingspage.Controls.Add(this.Auto_Start_CB);
            this.settingspage.Controls.Add(this.materialFlatButton1);
            this.settingspage.Controls.Add(this.materialLabel13);
            this.settingspage.Controls.Add(this.materialLabel10);
            this.settingspage.Controls.Add(this.materialLabel9);
            this.settingspage.Controls.Add(this.materialLabel12);
            this.settingspage.Controls.Add(this.materialLabel8);
            this.settingspage.Controls.Add(this.materialLabel11);
            this.settingspage.Controls.Add(this.materialLabel7);
            this.settingspage.Controls.Add(this.materialLabel6);
            this.settingspage.Controls.Add(this.materialLabel2);
            this.settingspage.Controls.Add(this.materialLabel1);
            this.settingspage.Controls.Add(this.Path_Gateway_TB);
            this.settingspage.Controls.Add(this.APIGATEPATH_DBSCHEME_TB);
            this.settingspage.Controls.Add(this.APIGATEPATH_DBTRANSLATE_TB);
            this.settingspage.Controls.Add(this.APIGATEPATH_CONNECTOR_TB);
            this.settingspage.Controls.Add(this.APIGATEPATH_COLLECTIONS_TB);
            this.settingspage.Controls.Add(this.APIGATEPATH_AUTH_TB);
            this.settingspage.Controls.Add(this.LANGUAGE_TB);
            this.settingspage.Controls.Add(this.APIPORT);
            this.settingspage.Controls.Add(this.APIHOST_TB);
            this.settingspage.Controls.Add(this.Path_Node_TB);
            this.settingspage.Location = new System.Drawing.Point(4, 24);
            this.settingspage.Name = "settingspage";
            this.settingspage.Padding = new System.Windows.Forms.Padding(3);
            this.settingspage.Size = new System.Drawing.Size(488, 399);
            this.settingspage.TabIndex = 1;
            this.settingspage.Text = "Ayarlar";
            // 
            // materialDivider2
            // 
            this.materialDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(-3, 80);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(495, 10);
            this.materialDivider2.TabIndex = 9;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // Auto_Start_CB
            // 
            this.Auto_Start_CB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Auto_Start_CB.AutoSize = true;
            this.Auto_Start_CB.Checked = true;
            this.Auto_Start_CB.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Auto_Start_CB.Depth = 0;
            this.Auto_Start_CB.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Auto_Start_CB.Location = new System.Drawing.Point(8, 358);
            this.Auto_Start_CB.Margin = new System.Windows.Forms.Padding(0);
            this.Auto_Start_CB.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Auto_Start_CB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Auto_Start_CB.Name = "Auto_Start_CB";
            this.Auto_Start_CB.Ripple = true;
            this.Auto_Start_CB.Size = new System.Drawing.Size(141, 30);
            this.Auto_Start_CB.TabIndex = 8;
            this.Auto_Start_CB.Text = "Auto Start Service";
            this.Auto_Start_CB.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(433, 352);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(46, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "SAVE";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(10, 276);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(105, 19);
            this.materialLabel13.TabIndex = 6;
            this.materialLabel13.Text = "Schemes Path";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(10, 247);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(112, 19);
            this.materialLabel10.TabIndex = 6;
            this.materialLabel10.Text = "Translator Path";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(10, 218);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(113, 19);
            this.materialLabel9.TabIndex = 6;
            this.materialLabel9.Text = "Connector Path";
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(10, 189);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(120, 19);
            this.materialLabel12.TabIndex = 6;
            this.materialLabel12.Text = "Collections Path";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(10, 160);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(74, 19);
            this.materialLabel8.TabIndex = 6;
            this.materialLabel8.Text = "Auth Path";
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(10, 305);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(73, 19);
            this.materialLabel11.TabIndex = 6;
            this.materialLabel11.Text = "Language";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(11, 131);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(64, 19);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "API Port";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(10, 102);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(69, 19);
            this.materialLabel6.TabIndex = 6;
            this.materialLabel6.Text = "API Host";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 46);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Node Path";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(10, 18);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(102, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "GateWay Path";
            // 
            // Path_Gateway_TB
            // 
            this.Path_Gateway_TB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Path_Gateway_TB.Depth = 0;
            this.Path_Gateway_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Path_Gateway_TB.Hint = "";
            this.Path_Gateway_TB.Location = new System.Drawing.Point(142, 18);
            this.Path_Gateway_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Path_Gateway_TB.Name = "Path_Gateway_TB";
            this.Path_Gateway_TB.PasswordChar = '\0';
            this.Path_Gateway_TB.SelectedText = "";
            this.Path_Gateway_TB.SelectionLength = 0;
            this.Path_Gateway_TB.SelectionStart = 0;
            this.Path_Gateway_TB.Size = new System.Drawing.Size(337, 23);
            this.Path_Gateway_TB.TabIndex = 5;
            this.Path_Gateway_TB.Text = "D:\\YEDEK\\Workflow\\Akatron Network\\Debi\\Debi-Gateway\\";
            this.Path_Gateway_TB.UseSystemPasswordChar = false;
            // 
            // APIGATEPATH_DBSCHEME_TB
            // 
            this.APIGATEPATH_DBSCHEME_TB.Depth = 0;
            this.APIGATEPATH_DBSCHEME_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIGATEPATH_DBSCHEME_TB.Hint = "";
            this.APIGATEPATH_DBSCHEME_TB.Location = new System.Drawing.Point(142, 276);
            this.APIGATEPATH_DBSCHEME_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIGATEPATH_DBSCHEME_TB.Name = "APIGATEPATH_DBSCHEME_TB";
            this.APIGATEPATH_DBSCHEME_TB.PasswordChar = '\0';
            this.APIGATEPATH_DBSCHEME_TB.SelectedText = "";
            this.APIGATEPATH_DBSCHEME_TB.SelectionLength = 0;
            this.APIGATEPATH_DBSCHEME_TB.SelectionStart = 0;
            this.APIGATEPATH_DBSCHEME_TB.Size = new System.Drawing.Size(337, 23);
            this.APIGATEPATH_DBSCHEME_TB.TabIndex = 5;
            this.APIGATEPATH_DBSCHEME_TB.Text = "/api/functions/gateway/dbscheme/";
            this.APIGATEPATH_DBSCHEME_TB.UseSystemPasswordChar = false;
            // 
            // APIGATEPATH_DBTRANSLATE_TB
            // 
            this.APIGATEPATH_DBTRANSLATE_TB.Depth = 0;
            this.APIGATEPATH_DBTRANSLATE_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIGATEPATH_DBTRANSLATE_TB.Hint = "";
            this.APIGATEPATH_DBTRANSLATE_TB.Location = new System.Drawing.Point(142, 247);
            this.APIGATEPATH_DBTRANSLATE_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIGATEPATH_DBTRANSLATE_TB.Name = "APIGATEPATH_DBTRANSLATE_TB";
            this.APIGATEPATH_DBTRANSLATE_TB.PasswordChar = '\0';
            this.APIGATEPATH_DBTRANSLATE_TB.SelectedText = "";
            this.APIGATEPATH_DBTRANSLATE_TB.SelectionLength = 0;
            this.APIGATEPATH_DBTRANSLATE_TB.SelectionStart = 0;
            this.APIGATEPATH_DBTRANSLATE_TB.Size = new System.Drawing.Size(337, 23);
            this.APIGATEPATH_DBTRANSLATE_TB.TabIndex = 5;
            this.APIGATEPATH_DBTRANSLATE_TB.Text = "/api/functions/gateway/dbtranslates/";
            this.APIGATEPATH_DBTRANSLATE_TB.UseSystemPasswordChar = false;
            // 
            // APIGATEPATH_CONNECTOR_TB
            // 
            this.APIGATEPATH_CONNECTOR_TB.Depth = 0;
            this.APIGATEPATH_CONNECTOR_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIGATEPATH_CONNECTOR_TB.Hint = "";
            this.APIGATEPATH_CONNECTOR_TB.Location = new System.Drawing.Point(142, 218);
            this.APIGATEPATH_CONNECTOR_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIGATEPATH_CONNECTOR_TB.Name = "APIGATEPATH_CONNECTOR_TB";
            this.APIGATEPATH_CONNECTOR_TB.PasswordChar = '\0';
            this.APIGATEPATH_CONNECTOR_TB.SelectedText = "";
            this.APIGATEPATH_CONNECTOR_TB.SelectionLength = 0;
            this.APIGATEPATH_CONNECTOR_TB.SelectionStart = 0;
            this.APIGATEPATH_CONNECTOR_TB.Size = new System.Drawing.Size(337, 23);
            this.APIGATEPATH_CONNECTOR_TB.TabIndex = 5;
            this.APIGATEPATH_CONNECTOR_TB.Text = "/api/functions/gateway/connector/";
            this.APIGATEPATH_CONNECTOR_TB.UseSystemPasswordChar = false;
            // 
            // APIGATEPATH_COLLECTIONS_TB
            // 
            this.APIGATEPATH_COLLECTIONS_TB.Depth = 0;
            this.APIGATEPATH_COLLECTIONS_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIGATEPATH_COLLECTIONS_TB.Hint = "";
            this.APIGATEPATH_COLLECTIONS_TB.Location = new System.Drawing.Point(142, 189);
            this.APIGATEPATH_COLLECTIONS_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIGATEPATH_COLLECTIONS_TB.Name = "APIGATEPATH_COLLECTIONS_TB";
            this.APIGATEPATH_COLLECTIONS_TB.PasswordChar = '\0';
            this.APIGATEPATH_COLLECTIONS_TB.SelectedText = "";
            this.APIGATEPATH_COLLECTIONS_TB.SelectionLength = 0;
            this.APIGATEPATH_COLLECTIONS_TB.SelectionStart = 0;
            this.APIGATEPATH_COLLECTIONS_TB.Size = new System.Drawing.Size(337, 23);
            this.APIGATEPATH_COLLECTIONS_TB.TabIndex = 5;
            this.APIGATEPATH_COLLECTIONS_TB.Text = "/api/functions/gateway/collections/";
            this.APIGATEPATH_COLLECTIONS_TB.UseSystemPasswordChar = false;
            // 
            // APIGATEPATH_AUTH_TB
            // 
            this.APIGATEPATH_AUTH_TB.Depth = 0;
            this.APIGATEPATH_AUTH_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIGATEPATH_AUTH_TB.Hint = "";
            this.APIGATEPATH_AUTH_TB.Location = new System.Drawing.Point(142, 160);
            this.APIGATEPATH_AUTH_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIGATEPATH_AUTH_TB.Name = "APIGATEPATH_AUTH_TB";
            this.APIGATEPATH_AUTH_TB.PasswordChar = '\0';
            this.APIGATEPATH_AUTH_TB.SelectedText = "";
            this.APIGATEPATH_AUTH_TB.SelectionLength = 0;
            this.APIGATEPATH_AUTH_TB.SelectionStart = 0;
            this.APIGATEPATH_AUTH_TB.Size = new System.Drawing.Size(337, 23);
            this.APIGATEPATH_AUTH_TB.TabIndex = 5;
            this.APIGATEPATH_AUTH_TB.Text = "/api/functions/gateway/auth/";
            this.APIGATEPATH_AUTH_TB.UseSystemPasswordChar = false;
            // 
            // LANGUAGE_TB
            // 
            this.LANGUAGE_TB.Depth = 0;
            this.LANGUAGE_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LANGUAGE_TB.Hint = "";
            this.LANGUAGE_TB.Location = new System.Drawing.Point(142, 305);
            this.LANGUAGE_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.LANGUAGE_TB.Name = "LANGUAGE_TB";
            this.LANGUAGE_TB.PasswordChar = '\0';
            this.LANGUAGE_TB.SelectedText = "";
            this.LANGUAGE_TB.SelectionLength = 0;
            this.LANGUAGE_TB.SelectionStart = 0;
            this.LANGUAGE_TB.Size = new System.Drawing.Size(337, 23);
            this.LANGUAGE_TB.TabIndex = 5;
            this.LANGUAGE_TB.Text = "TR";
            this.LANGUAGE_TB.UseSystemPasswordChar = false;
            // 
            // APIPORT
            // 
            this.APIPORT.Depth = 0;
            this.APIPORT.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIPORT.Hint = "";
            this.APIPORT.Location = new System.Drawing.Point(143, 131);
            this.APIPORT.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIPORT.Name = "APIPORT";
            this.APIPORT.PasswordChar = '\0';
            this.APIPORT.SelectedText = "";
            this.APIPORT.SelectionLength = 0;
            this.APIPORT.SelectionStart = 0;
            this.APIPORT.Size = new System.Drawing.Size(337, 23);
            this.APIPORT.TabIndex = 5;
            this.APIPORT.Text = "8000";
            this.APIPORT.UseSystemPasswordChar = false;
            // 
            // APIHOST_TB
            // 
            this.APIHOST_TB.Depth = 0;
            this.APIHOST_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.APIHOST_TB.Hint = "";
            this.APIHOST_TB.Location = new System.Drawing.Point(142, 102);
            this.APIHOST_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.APIHOST_TB.Name = "APIHOST_TB";
            this.APIHOST_TB.PasswordChar = '\0';
            this.APIHOST_TB.SelectedText = "";
            this.APIHOST_TB.SelectionLength = 0;
            this.APIHOST_TB.SelectionStart = 0;
            this.APIHOST_TB.Size = new System.Drawing.Size(337, 23);
            this.APIHOST_TB.TabIndex = 5;
            this.APIHOST_TB.Text = "localhost";
            this.APIHOST_TB.UseSystemPasswordChar = false;
            // 
            // Path_Node_TB
            // 
            this.Path_Node_TB.Depth = 0;
            this.Path_Node_TB.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Path_Node_TB.Hint = "";
            this.Path_Node_TB.Location = new System.Drawing.Point(142, 46);
            this.Path_Node_TB.MouseState = MaterialSkin.MouseState.HOVER;
            this.Path_Node_TB.Name = "Path_Node_TB";
            this.Path_Node_TB.PasswordChar = '\0';
            this.Path_Node_TB.SelectedText = "";
            this.Path_Node_TB.SelectionLength = 0;
            this.Path_Node_TB.SelectionStart = 0;
            this.Path_Node_TB.Size = new System.Drawing.Size(337, 23);
            this.Path_Node_TB.TabIndex = 5;
            this.Path_Node_TB.Text = "C:\\Program Files\\nodejs\\nodeAkatron.exe";
            this.Path_Node_TB.UseSystemPasswordChar = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.ConsoleTB);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(488, 399);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Konsol";
            // 
            // ConsoleTB
            // 
            this.ConsoleTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConsoleTB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConsoleTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ConsoleTB.DetectUrls = false;
            this.ConsoleTB.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleTB.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsoleTB.Location = new System.Drawing.Point(10, 9);
            this.ConsoleTB.Margin = new System.Windows.Forms.Padding(10);
            this.ConsoleTB.Name = "ConsoleTB";
            this.ConsoleTB.ReadOnly = true;
            this.ConsoleTB.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ConsoleTB.Size = new System.Drawing.Size(470, 380);
            this.ConsoleTB.TabIndex = 0;
            this.ConsoleTB.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DebiGateManager.Properties.Resources.ico;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(187, 41);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(305, 23);
            this.materialTabSelector1.TabIndex = 3;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // ServiceRunCTRL
            // 
            this.ServiceRunCTRL.Tick += new System.EventHandler(this.ServiceRunCTRL_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Service is working in background.\r\n\r\nStop service first to exit program.";
            this.notifyIcon1.BalloonTipTitle = "Service working!";
            this.notifyIcon1.ContextMenuStrip = this.NotifyMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Debi GateWay Manager";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // NotifyMenuStrip
            // 
            this.NotifyMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NotifyMenuStrip.Depth = 0;
            this.NotifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Exit});
            this.NotifyMenuStrip.MouseState = MaterialSkin.MouseState.HOVER;
            this.NotifyMenuStrip.Name = "materialContextMenuStrip1";
            this.NotifyMenuStrip.Size = new System.Drawing.Size(104, 64);
            this.NotifyMenuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.NotifyMenuStrip_ItemClicked);
            // 
            // Open
            // 
            this.Open.AutoSize = false;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(120, 30);
            this.Open.Text = "Open";
            // 
            // Exit
            // 
            this.Exit.AutoSize = false;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(120, 30);
            this.Exit.Text = "Exit";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::DebiGateManager.Properties.Resources.icon2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(4, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 29);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // autostarter
            // 
            this.autostarter.Interval = 5000;
            this.autostarter.Tick += new System.EventHandler(this.autostarter_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 484);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "       GateWay Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.mainpage.ResumeLayout(false);
            this.mainpage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.settingspage.ResumeLayout(false);
            this.settingspage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NotifyMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage mainpage;
        private System.Windows.Forms.TabPage settingspage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox ConsoleTB;
        private System.Windows.Forms.Timer ServiceRunCTRL;
        private MaterialSkin.Controls.MaterialSingleLineTextField Path_Gateway_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField Path_Node_TB;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private MaterialSkin.Controls.MaterialCheckBox Auto_Start_CB;
        private MaterialSkin.Controls.MaterialLabel Service_State_TB;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MaterialSkin.Controls.MaterialContextMenuStrip NotifyMenuStrip;
        private MaterialSkin.Controls.MaterialToolStripMenuItem Open;
        private MaterialSkin.Controls.MaterialToolStripMenuItem Exit;
        private MaterialSkin.Controls.MaterialFlatButton Logout_BTN;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MaterialSkin.Controls.MaterialSingleLineTextField password_TB;
        private MaterialSkin.Controls.MaterialSingleLineTextField username_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialFlatButton Login_BTN;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIPORT;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIHOST_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIGATEPATH_DBTRANSLATE_TB;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIGATEPATH_CONNECTOR_TB;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIGATEPATH_AUTH_TB;
        private System.Windows.Forms.Timer autostarter;
        private MaterialSkin.Controls.MaterialRaisedButton Run_BTN;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialSingleLineTextField LANGUAGE_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIGATEPATH_COLLECTIONS_TB;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialSingleLineTextField APIGATEPATH_DBSCHEME_TB;
    }
}

