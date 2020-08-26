using System.Windows.Forms;

namespace SEN_Account_Generator_by_Unknauwn
{
    partial class SenAccountGenerator
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenAccountGenerator));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.iTalk_ThemeContainer1 = new iTalk_ThemeContainer();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.GeneratorPanel = new iTalk_TabControl();
            this.SettingPage = new System.Windows.Forms.TabPage();
            this.HidePass = new iTalk_CheckBox();
            this.iTalk_HeaderLabel4 = new iTalk_HeaderLabel();
            this.RandomCharUser = new iTalk_TextBox_Small();
            this.GenerateButton = new iTalk_Button_2();
            this.iTalk_HeaderLabel2 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel1 = new iTalk_HeaderLabel();
            this.PasswordTxt = new iTalk_TextBox_Small();
            this.UsernameTxt = new iTalk_TextBox_Small();
            this.AboutPage = new System.Windows.Forms.TabPage();
            this.iTalk_HeaderLabel13 = new iTalk_HeaderLabel();
            this.iTalk_Button_21 = new iTalk_Button_2();
            this.EmailLbl = new iTalk_TextBox_Small();
            this.iTalk_HeaderLabel7 = new iTalk_HeaderLabel();
            this.GenerateAgainButton = new iTalk_Button_1();
            this.UsernameLbl = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel10 = new iTalk_HeaderLabel();
            this.PasswordLbl = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel6 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel5 = new iTalk_HeaderLabel();
            this.Credits = new System.Windows.Forms.TabPage();
            this.iTalk_LinkLabel3 = new iTalk_LinkLabel();
            this.iTalk_LinkLabel2 = new iTalk_LinkLabel();
            this.iTalk_LinkLabel1 = new iTalk_LinkLabel();
            this.iTalk_HeaderLabel16 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel17 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel8 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel9 = new iTalk_HeaderLabel();
            this.iTalk_HeaderLabel11 = new iTalk_HeaderLabel();
            this.SettingGenerator = new System.Windows.Forms.TabPage();
            this.iTalk_HeaderLabel12 = new iTalk_HeaderLabel();
            this.iTalk_Label3 = new iTalk_Label();
            this.SelectLanguage = new iTalk_ComboBox();
            this.CFWQuestion = new iTalk_ComboBox();
            this.iTalk_Label2 = new iTalk_Label();
            this.OutlogTxt = new iTalk_RichTextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.iTalk_Label1 = new iTalk_Label();
            this.iTalk_ControlBox1 = new iTalk_ControlBox();
            this.iTalk_ThemeContainer1.SuspendLayout();
            this.GeneratorPanel.SuspendLayout();
            this.SettingPage.SuspendLayout();
            this.AboutPage.SuspendLayout();
            this.Credits.SuspendLayout();
            this.SettingGenerator.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "006-pencil.png");
            this.imageList1.Images.SetKeyName(1, "146-wrench.png");
            this.imageList1.Images.SetKeyName(2, "269-info.png");
            this.imageList1.Images.SetKeyName(3, "185-clipboard.png");
            // 
            // iTalk_ThemeContainer1
            // 
            this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.iTalk_ThemeContainer1.Controls.Add(this.webBrowser2);
            this.iTalk_ThemeContainer1.Controls.Add(this.GeneratorPanel);
            this.iTalk_ThemeContainer1.Controls.Add(this.OutlogTxt);
            this.iTalk_ThemeContainer1.Controls.Add(this.webBrowser1);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Label1);
            this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_ControlBox1);
            this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
            this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.iTalk_ThemeContainer1.RoundCorners = true;
            this.iTalk_ThemeContainer1.Sizable = false;
            this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(940, 443);
            this.iTalk_ThemeContainer1.SmartBounds = true;
            this.iTalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.iTalk_ThemeContainer1.TabIndex = 1;
            this.iTalk_ThemeContainer1.Text = "SEN Account Generator by Unknauwn 3.0";
            // 
            // webBrowser2
            // 
            this.webBrowser2.AllowWebBrowserDrop = false;
            this.webBrowser2.Location = new System.Drawing.Point(950, 31);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScriptErrorsSuppressed = true;
            this.webBrowser2.Size = new System.Drawing.Size(432, 29);
            this.webBrowser2.TabIndex = 49;
            this.webBrowser2.Url = new System.Uri("", System.UriKind.Relative);
            this.webBrowser2.WebBrowserShortcutsEnabled = false;
            // 
            // GeneratorPanel
            // 
            this.GeneratorPanel.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.GeneratorPanel.ColorTabSelected = System.Drawing.Color.Empty;
            this.GeneratorPanel.Controls.Add(this.SettingPage);
            this.GeneratorPanel.Controls.Add(this.AboutPage);
            this.GeneratorPanel.Controls.Add(this.Credits);
            this.GeneratorPanel.Controls.Add(this.SettingGenerator);
            this.GeneratorPanel.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.GeneratorPanel.ImageList = this.imageList1;
            this.GeneratorPanel.ItemSize = new System.Drawing.Size(44, 135);
            this.GeneratorPanel.Location = new System.Drawing.Point(3, 24);
            this.GeneratorPanel.Multiline = true;
            this.GeneratorPanel.Name = "GeneratorPanel";
            this.GeneratorPanel.SelectedIndex = 0;
            this.GeneratorPanel.Size = new System.Drawing.Size(487, 249);
            this.GeneratorPanel.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.GeneratorPanel.SymbolColor = System.Drawing.SystemColors.Highlight;
            this.GeneratorPanel.TabIndex = 48;
            // 
            // SettingPage
            // 
            this.SettingPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.SettingPage.Controls.Add(this.HidePass);
            this.SettingPage.Controls.Add(this.iTalk_HeaderLabel4);
            this.SettingPage.Controls.Add(this.RandomCharUser);
            this.SettingPage.Controls.Add(this.GenerateButton);
            this.SettingPage.Controls.Add(this.iTalk_HeaderLabel2);
            this.SettingPage.Controls.Add(this.iTalk_HeaderLabel1);
            this.SettingPage.Controls.Add(this.PasswordTxt);
            this.SettingPage.Controls.Add(this.UsernameTxt);
            this.SettingPage.ImageIndex = 0;
            this.SettingPage.Location = new System.Drawing.Point(139, 4);
            this.SettingPage.Name = "SettingPage";
            this.SettingPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingPage.Size = new System.Drawing.Size(344, 241);
            this.SettingPage.TabIndex = 0;
            this.SettingPage.Text = "Settings Account";
            // 
            // HidePass
            // 
            this.HidePass.BackColor = System.Drawing.Color.Transparent;
            this.HidePass.Checked = false;
            this.HidePass.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.HidePass.Location = new System.Drawing.Point(244, 114);
            this.HidePass.Name = "HidePass";
            this.HidePass.Size = new System.Drawing.Size(64, 15);
            this.HidePass.TabIndex = 27;
            this.HidePass.Text = "Hide ?";
            this.HidePass.CheckedChanged += new iTalk_CheckBox.CheckedChangedEventHandler(this.HidePass_CheckedChanged);
            // 
            // iTalk_HeaderLabel4
            // 
            this.iTalk_HeaderLabel4.AutoSize = true;
            this.iTalk_HeaderLabel4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel4.Location = new System.Drawing.Point(240, 57);
            this.iTalk_HeaderLabel4.Name = "iTalk_HeaderLabel4";
            this.iTalk_HeaderLabel4.Size = new System.Drawing.Size(19, 19);
            this.iTalk_HeaderLabel4.TabIndex = 25;
            this.iTalk_HeaderLabel4.Text = "+";
            // 
            // RandomCharUser
            // 
            this.RandomCharUser.BackColor = System.Drawing.Color.Transparent;
            this.RandomCharUser.Font = new System.Drawing.Font("Tahoma", 11F);
            this.RandomCharUser.ForeColor = System.Drawing.Color.DimGray;
            this.RandomCharUser.Location = new System.Drawing.Point(261, 53);
            this.RandomCharUser.MaxLength = 32767;
            this.RandomCharUser.Multiline = false;
            this.RandomCharUser.Name = "RandomCharUser";
            this.RandomCharUser.ReadOnly = true;
            this.RandomCharUser.Size = new System.Drawing.Size(65, 28);
            this.RandomCharUser.TabIndex = 24;
            this.RandomCharUser.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.RandomCharUser.UseSystemPasswordChar = false;
            // 
            // GenerateButton
            // 
            this.GenerateButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateButton.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.GenerateButton.ForeColor = System.Drawing.Color.White;
            this.GenerateButton.Image = null;
            this.GenerateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateButton.Location = new System.Drawing.Point(68, 174);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(196, 36);
            this.GenerateButton.TabIndex = 23;
            this.GenerateButton.Text = "Generate Account";
            this.GenerateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // iTalk_HeaderLabel2
            // 
            this.iTalk_HeaderLabel2.AutoSize = true;
            this.iTalk_HeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel2.Location = new System.Drawing.Point(9, 112);
            this.iTalk_HeaderLabel2.Name = "iTalk_HeaderLabel2";
            this.iTalk_HeaderLabel2.Size = new System.Drawing.Size(74, 19);
            this.iTalk_HeaderLabel2.TabIndex = 4;
            this.iTalk_HeaderLabel2.Text = "Password :";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(9, 56);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(78, 19);
            this.iTalk_HeaderLabel1.TabIndex = 3;
            this.iTalk_HeaderLabel1.Text = "Username :";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.PasswordTxt.ForeColor = System.Drawing.Color.DimGray;
            this.PasswordTxt.Location = new System.Drawing.Point(102, 107);
            this.PasswordTxt.MaxLength = 32;
            this.PasswordTxt.Multiline = false;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.ReadOnly = false;
            this.PasswordTxt.Size = new System.Drawing.Size(135, 28);
            this.PasswordTxt.TabIndex = 1;
            this.PasswordTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTxt.UseSystemPasswordChar = false;
            // 
            // UsernameTxt
            // 
            this.UsernameTxt.BackColor = System.Drawing.Color.Transparent;
            this.UsernameTxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.UsernameTxt.ForeColor = System.Drawing.Color.DimGray;
            this.UsernameTxt.Location = new System.Drawing.Point(102, 53);
            this.UsernameTxt.MaxLength = 10;
            this.UsernameTxt.Multiline = false;
            this.UsernameTxt.Name = "UsernameTxt";
            this.UsernameTxt.ReadOnly = false;
            this.UsernameTxt.Size = new System.Drawing.Size(135, 28);
            this.UsernameTxt.TabIndex = 0;
            this.UsernameTxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameTxt.UseSystemPasswordChar = false;
            // 
            // AboutPage
            // 
            this.AboutPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.AboutPage.Controls.Add(this.iTalk_HeaderLabel13);
            this.AboutPage.Controls.Add(this.iTalk_Button_21);
            this.AboutPage.Controls.Add(this.EmailLbl);
            this.AboutPage.Controls.Add(this.iTalk_HeaderLabel7);
            this.AboutPage.Controls.Add(this.GenerateAgainButton);
            this.AboutPage.Controls.Add(this.UsernameLbl);
            this.AboutPage.Controls.Add(this.iTalk_HeaderLabel10);
            this.AboutPage.Controls.Add(this.PasswordLbl);
            this.AboutPage.Controls.Add(this.iTalk_HeaderLabel6);
            this.AboutPage.Controls.Add(this.iTalk_HeaderLabel5);
            this.AboutPage.ImageIndex = 3;
            this.AboutPage.Location = new System.Drawing.Point(139, 4);
            this.AboutPage.Name = "AboutPage";
            this.AboutPage.Padding = new System.Windows.Forms.Padding(3);
            this.AboutPage.Size = new System.Drawing.Size(344, 241);
            this.AboutPage.TabIndex = 1;
            this.AboutPage.Text = "About Account";
            // 
            // iTalk_HeaderLabel13
            // 
            this.iTalk_HeaderLabel13.AutoSize = true;
            this.iTalk_HeaderLabel13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel13.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_HeaderLabel13.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iTalk_HeaderLabel13.Location = new System.Drawing.Point(240, 225);
            this.iTalk_HeaderLabel13.Name = "iTalk_HeaderLabel13";
            this.iTalk_HeaderLabel13.Size = new System.Drawing.Size(90, 13);
            this.iTalk_HeaderLabel13.TabIndex = 50;
            this.iTalk_HeaderLabel13.Text = "Only CFW 4.65+";
            // 
            // iTalk_Button_21
            // 
            this.iTalk_Button_21.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_21.Enabled = false;
            this.iTalk_Button_21.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.iTalk_Button_21.ForeColor = System.Drawing.Color.White;
            this.iTalk_Button_21.Image = null;
            this.iTalk_Button_21.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_21.Location = new System.Drawing.Point(164, 183);
            this.iTalk_Button_21.Name = "iTalk_Button_21";
            this.iTalk_Button_21.Size = new System.Drawing.Size(166, 40);
            this.iTalk_Button_21.TabIndex = 49;
            this.iTalk_Button_21.Text = "Verify Email?";
            this.iTalk_Button_21.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_21.Click += new System.EventHandler(this.iTalk_Button_21_Click);
            // 
            // EmailLbl
            // 
            this.EmailLbl.BackColor = System.Drawing.Color.Transparent;
            this.EmailLbl.Font = new System.Drawing.Font("Tahoma", 11F);
            this.EmailLbl.ForeColor = System.Drawing.Color.DimGray;
            this.EmailLbl.Location = new System.Drawing.Point(104, 103);
            this.EmailLbl.MaxLength = 32767;
            this.EmailLbl.Multiline = false;
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.ReadOnly = true;
            this.EmailLbl.Size = new System.Drawing.Size(196, 28);
            this.EmailLbl.TabIndex = 48;
            this.EmailLbl.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailLbl.UseSystemPasswordChar = false;
            // 
            // iTalk_HeaderLabel7
            // 
            this.iTalk_HeaderLabel7.AutoSize = true;
            this.iTalk_HeaderLabel7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel7.Font = new System.Drawing.Font("Segoe UI", 23F);
            this.iTalk_HeaderLabel7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iTalk_HeaderLabel7.Location = new System.Drawing.Point(2, 3);
            this.iTalk_HeaderLabel7.Name = "iTalk_HeaderLabel7";
            this.iTalk_HeaderLabel7.Size = new System.Drawing.Size(328, 42);
            this.iTalk_HeaderLabel7.TabIndex = 47;
            this.iTalk_HeaderLabel7.Text = "Succesfully Generated!";
            this.iTalk_HeaderLabel7.Visible = false;
            // 
            // GenerateAgainButton
            // 
            this.GenerateAgainButton.BackColor = System.Drawing.Color.Transparent;
            this.GenerateAgainButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GenerateAgainButton.Image = null;
            this.GenerateAgainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GenerateAgainButton.Location = new System.Drawing.Point(9, 183);
            this.GenerateAgainButton.Name = "GenerateAgainButton";
            this.GenerateAgainButton.Size = new System.Drawing.Size(140, 40);
            this.GenerateAgainButton.TabIndex = 46;
            this.GenerateAgainButton.Text = "Generate Again?";
            this.GenerateAgainButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GenerateAgainButton.Click += new System.EventHandler(this.GenerateButtonAgain_Click);
            // 
            // UsernameLbl
            // 
            this.UsernameLbl.AutoSize = true;
            this.UsernameLbl.BackColor = System.Drawing.Color.Transparent;
            this.UsernameLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.UsernameLbl.Location = new System.Drawing.Point(113, 74);
            this.UsernameLbl.Name = "UsernameLbl";
            this.UsernameLbl.Size = new System.Drawing.Size(14, 17);
            this.UsernameLbl.TabIndex = 9;
            this.UsernameLbl.Text = "?";
            // 
            // iTalk_HeaderLabel10
            // 
            this.iTalk_HeaderLabel10.AutoSize = true;
            this.iTalk_HeaderLabel10.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel10.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel10.Location = new System.Drawing.Point(32, 74);
            this.iTalk_HeaderLabel10.Name = "iTalk_HeaderLabel10";
            this.iTalk_HeaderLabel10.Size = new System.Drawing.Size(78, 19);
            this.iTalk_HeaderLabel10.TabIndex = 8;
            this.iTalk_HeaderLabel10.Text = "Username :";
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLbl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PasswordLbl.Location = new System.Drawing.Point(113, 138);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(14, 17);
            this.PasswordLbl.TabIndex = 7;
            this.PasswordLbl.Text = "?";
            // 
            // iTalk_HeaderLabel6
            // 
            this.iTalk_HeaderLabel6.AutoSize = true;
            this.iTalk_HeaderLabel6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel6.Location = new System.Drawing.Point(32, 138);
            this.iTalk_HeaderLabel6.Name = "iTalk_HeaderLabel6";
            this.iTalk_HeaderLabel6.Size = new System.Drawing.Size(74, 19);
            this.iTalk_HeaderLabel6.TabIndex = 5;
            this.iTalk_HeaderLabel6.Text = "Password :";
            // 
            // iTalk_HeaderLabel5
            // 
            this.iTalk_HeaderLabel5.AutoSize = true;
            this.iTalk_HeaderLabel5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel5.Location = new System.Drawing.Point(32, 107);
            this.iTalk_HeaderLabel5.Name = "iTalk_HeaderLabel5";
            this.iTalk_HeaderLabel5.Size = new System.Drawing.Size(52, 19);
            this.iTalk_HeaderLabel5.TabIndex = 4;
            this.iTalk_HeaderLabel5.Text = "Email : ";
            // 
            // Credits
            // 
            this.Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.Credits.Controls.Add(this.iTalk_LinkLabel3);
            this.Credits.Controls.Add(this.iTalk_LinkLabel2);
            this.Credits.Controls.Add(this.iTalk_LinkLabel1);
            this.Credits.Controls.Add(this.iTalk_HeaderLabel16);
            this.Credits.Controls.Add(this.iTalk_HeaderLabel17);
            this.Credits.Controls.Add(this.iTalk_HeaderLabel8);
            this.Credits.Controls.Add(this.iTalk_HeaderLabel9);
            this.Credits.Controls.Add(this.iTalk_HeaderLabel11);
            this.Credits.ImageIndex = 2;
            this.Credits.Location = new System.Drawing.Point(139, 4);
            this.Credits.Name = "Credits";
            this.Credits.Size = new System.Drawing.Size(344, 241);
            this.Credits.TabIndex = 2;
            this.Credits.Text = "Credit";
            // 
            // iTalk_LinkLabel3
            // 
            this.iTalk_LinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel3.AutoSize = true;
            this.iTalk_LinkLabel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel3.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel3.Location = new System.Drawing.Point(45, 179);
            this.iTalk_LinkLabel3.Name = "iTalk_LinkLabel3";
            this.iTalk_LinkLabel3.Size = new System.Drawing.Size(123, 13);
            this.iTalk_LinkLabel3.TabIndex = 17;
            this.iTalk_LinkLabel3.TabStop = true;
            this.iTalk_LinkLabel3.Text = "UnknownDevTeam.org";
            this.iTalk_LinkLabel3.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel3_LinkClicked);
            // 
            // iTalk_LinkLabel2
            // 
            this.iTalk_LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel2.AutoSize = true;
            this.iTalk_LinkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel2.Location = new System.Drawing.Point(45, 220);
            this.iTalk_LinkLabel2.Name = "iTalk_LinkLabel2";
            this.iTalk_LinkLabel2.Size = new System.Drawing.Size(99, 13);
            this.iTalk_LinkLabel2.TabIndex = 16;
            this.iTalk_LinkLabel2.TabStop = true;
            this.iTalk_LinkLabel2.Text = "hackandmodz.net";
            this.iTalk_LinkLabel2.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel2_LinkClicked);
            // 
            // iTalk_LinkLabel1
            // 
            this.iTalk_LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.AutoSize = true;
            this.iTalk_LinkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_LinkLabel1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.iTalk_LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(225)))));
            this.iTalk_LinkLabel1.Location = new System.Drawing.Point(45, 200);
            this.iTalk_LinkLabel1.Name = "iTalk_LinkLabel1";
            this.iTalk_LinkLabel1.Size = new System.Drawing.Size(92, 13);
            this.iTalk_LinkLabel1.TabIndex = 15;
            this.iTalk_LinkLabel1.TabStop = true;
            this.iTalk_LinkLabel1.Text = "RealityGaming.fr";
            this.iTalk_LinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(101)))), ((int)(((byte)(202)))));
            this.iTalk_LinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iTalk_LinkLabel1_LinkClicked);
            // 
            // iTalk_HeaderLabel16
            // 
            this.iTalk_HeaderLabel16.AutoSize = true;
            this.iTalk_HeaderLabel16.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel16.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iTalk_HeaderLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel16.Location = new System.Drawing.Point(18, 9);
            this.iTalk_HeaderLabel16.Name = "iTalk_HeaderLabel16";
            this.iTalk_HeaderLabel16.Size = new System.Drawing.Size(105, 28);
            this.iTalk_HeaderLabel16.TabIndex = 14;
            this.iTalk_HeaderLabel16.Text = "Thanks to :";
            // 
            // iTalk_HeaderLabel17
            // 
            this.iTalk_HeaderLabel17.AutoSize = true;
            this.iTalk_HeaderLabel17.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel17.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.iTalk_HeaderLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel17.Location = new System.Drawing.Point(18, 142);
            this.iTalk_HeaderLabel17.Name = "iTalk_HeaderLabel17";
            this.iTalk_HeaderLabel17.Size = new System.Drawing.Size(85, 28);
            this.iTalk_HeaderLabel17.TabIndex = 13;
            this.iTalk_HeaderLabel17.Text = "Visit Us :";
            // 
            // iTalk_HeaderLabel8
            // 
            this.iTalk_HeaderLabel8.AutoSize = true;
            this.iTalk_HeaderLabel8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel8.Location = new System.Drawing.Point(44, 47);
            this.iTalk_HeaderLabel8.Name = "iTalk_HeaderLabel8";
            this.iTalk_HeaderLabel8.Size = new System.Drawing.Size(278, 19);
            this.iTalk_HeaderLabel8.TabIndex = 11;
            this.iTalk_HeaderLabel8.Text = "Unknauwn (Code and Creator of Generator)";
            // 
            // iTalk_HeaderLabel9
            // 
            this.iTalk_HeaderLabel9.AutoSize = true;
            this.iTalk_HeaderLabel9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel9.Location = new System.Drawing.Point(44, 111);
            this.iTalk_HeaderLabel9.Name = "iTalk_HeaderLabel9";
            this.iTalk_HeaderLabel9.Size = new System.Drawing.Size(173, 19);
            this.iTalk_HeaderLabel9.TabIndex = 10;
            this.iTalk_HeaderLabel9.Text = "??? (iTalk Template Creator)";
            // 
            // iTalk_HeaderLabel11
            // 
            this.iTalk_HeaderLabel11.AutoSize = true;
            this.iTalk_HeaderLabel11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel11.Location = new System.Drawing.Point(44, 80);
            this.iTalk_HeaderLabel11.Name = "iTalk_HeaderLabel11";
            this.iTalk_HeaderLabel11.Size = new System.Drawing.Size(180, 19);
            this.iTalk_HeaderLabel11.TabIndex = 9;
            this.iTalk_HeaderLabel11.Text = "Krytox (Idea and some help)";
            // 
            // SettingGenerator
            // 
            this.SettingGenerator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.SettingGenerator.Controls.Add(this.iTalk_HeaderLabel12);
            this.SettingGenerator.Controls.Add(this.iTalk_Label3);
            this.SettingGenerator.Controls.Add(this.SelectLanguage);
            this.SettingGenerator.Controls.Add(this.CFWQuestion);
            this.SettingGenerator.Controls.Add(this.iTalk_Label2);
            this.SettingGenerator.ImageIndex = 1;
            this.SettingGenerator.Location = new System.Drawing.Point(139, 4);
            this.SettingGenerator.Name = "SettingGenerator";
            this.SettingGenerator.Size = new System.Drawing.Size(344, 241);
            this.SettingGenerator.TabIndex = 4;
            this.SettingGenerator.Text = "Settings";
            // 
            // iTalk_HeaderLabel12
            // 
            this.iTalk_HeaderLabel12.AutoSize = true;
            this.iTalk_HeaderLabel12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_HeaderLabel12.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iTalk_HeaderLabel12.Location = new System.Drawing.Point(3, 212);
            this.iTalk_HeaderLabel12.Name = "iTalk_HeaderLabel12";
            this.iTalk_HeaderLabel12.Size = new System.Drawing.Size(285, 19);
            this.iTalk_HeaderLabel12.TabIndex = 11;
            this.iTalk_HeaderLabel12.Text = "Note : CFW 4.65 and More need Verify Email.";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(108, 112);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(100, 13);
            this.iTalk_Label3.TabIndex = 3;
            this.iTalk_Label3.Text = "Select Language...";
            // 
            // SelectLanguage
            // 
            this.SelectLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.SelectLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SelectLanguage.DropDownHeight = 100;
            this.SelectLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectLanguage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectLanguage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.SelectLanguage.FormattingEnabled = true;
            this.SelectLanguage.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.SelectLanguage.IntegralHeight = false;
            this.SelectLanguage.ItemHeight = 20;
            this.SelectLanguage.Items.AddRange(new object[] {
            "English",
            "Francais"});
            this.SelectLanguage.Location = new System.Drawing.Point(90, 128);
            this.SelectLanguage.Name = "SelectLanguage";
            this.SelectLanguage.Size = new System.Drawing.Size(135, 26);
            this.SelectLanguage.StartIndex = 0;
            this.SelectLanguage.TabIndex = 2;
            this.SelectLanguage.SelectedIndexChanged += new System.EventHandler(this.SelectLanguage_SelectedIndexChanged);
            // 
            // CFWQuestion
            // 
            this.CFWQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.CFWQuestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CFWQuestion.DropDownHeight = 100;
            this.CFWQuestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CFWQuestion.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CFWQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.CFWQuestion.FormattingEnabled = true;
            this.CFWQuestion.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.CFWQuestion.IntegralHeight = false;
            this.CFWQuestion.ItemHeight = 20;
            this.CFWQuestion.Items.AddRange(new object[] {
            "Non",
            "Oui"});
            this.CFWQuestion.Location = new System.Drawing.Point(90, 63);
            this.CFWQuestion.Name = "CFWQuestion";
            this.CFWQuestion.Size = new System.Drawing.Size(135, 26);
            this.CFWQuestion.StartIndex = 0;
            this.CFWQuestion.TabIndex = 0;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(118, 47);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(71, 13);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "CFW 4.65+ ?";
            // 
            // OutlogTxt
            // 
            this.OutlogTxt.AutoWordSelection = false;
            this.OutlogTxt.BackColor = System.Drawing.Color.Transparent;
            this.OutlogTxt.Font = new System.Drawing.Font("Tahoma", 10F);
            this.OutlogTxt.ForeColor = System.Drawing.Color.DimGray;
            this.OutlogTxt.Location = new System.Drawing.Point(8, 275);
            this.OutlogTxt.Name = "OutlogTxt";
            this.OutlogTxt.ReadOnly = false;
            this.OutlogTxt.Size = new System.Drawing.Size(479, 138);
            this.OutlogTxt.TabIndex = 47;
            this.OutlogTxt.Text = "Output Log :";
            this.OutlogTxt.WordWrap = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(496, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(432, 385);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(197, 424);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(126, 13);
            this.iTalk_Label1.TabIndex = 46;
            this.iTalk_Label1.Text = "Coded by Unknauwn©";
            // 
            // iTalk_ControlBox1
            // 
            this.iTalk_ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iTalk_ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ControlBox1.Location = new System.Drawing.Point(859, 2);
            this.iTalk_ControlBox1.Name = "iTalk_ControlBox1";
            this.iTalk_ControlBox1.Size = new System.Drawing.Size(77, 19);
            this.iTalk_ControlBox1.TabIndex = 3;
            this.iTalk_ControlBox1.Text = "iTalk_ControlBox1";
            // 
            // SenAccountGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 443);
            this.Controls.Add(this.iTalk_ThemeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(261, 65);
            this.Name = "SenAccountGenerator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "SEN Account Generator by Unknauwn";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.iTalk_ThemeContainer1.ResumeLayout(false);
            this.iTalk_ThemeContainer1.PerformLayout();
            this.GeneratorPanel.ResumeLayout(false);
            this.SettingPage.ResumeLayout(false);
            this.SettingPage.PerformLayout();
            this.AboutPage.ResumeLayout(false);
            this.AboutPage.PerformLayout();
            this.Credits.ResumeLayout(false);
            this.Credits.PerformLayout();
            this.SettingGenerator.ResumeLayout(false);
            this.SettingGenerator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        
        private iTalk_Label iTalk_Label1;
        private iTalk_ControlBox iTalk_ControlBox1;
        private iTalk_ThemeContainer iTalk_ThemeContainer1;
        private iTalk_TabControl GeneratorPanel;
        private TabPage SettingPage;
        private iTalk_CheckBox HidePass;
        private iTalk_HeaderLabel iTalk_HeaderLabel4;
        private iTalk_TextBox_Small RandomCharUser;
        private iTalk_Button_2 GenerateButton;
        private iTalk_HeaderLabel iTalk_HeaderLabel2;
        private iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk_TextBox_Small PasswordTxt;
        private iTalk_TextBox_Small UsernameTxt;
        private TabPage AboutPage;
        private iTalk_HeaderLabel iTalk_HeaderLabel13;
        private iTalk_Button_2 iTalk_Button_21;
        private iTalk_TextBox_Small EmailLbl;
        private iTalk_HeaderLabel iTalk_HeaderLabel7;
        private iTalk_Button_1 GenerateAgainButton;
        private iTalk_HeaderLabel UsernameLbl;
        private iTalk_HeaderLabel iTalk_HeaderLabel10;
        private iTalk_HeaderLabel PasswordLbl;
        private iTalk_HeaderLabel iTalk_HeaderLabel6;
        private iTalk_HeaderLabel iTalk_HeaderLabel5;
        private TabPage Credits;
        private iTalk_LinkLabel iTalk_LinkLabel2;
        private iTalk_LinkLabel iTalk_LinkLabel1;
        private iTalk_HeaderLabel iTalk_HeaderLabel16;
        private iTalk_HeaderLabel iTalk_HeaderLabel17;
        private iTalk_HeaderLabel iTalk_HeaderLabel8;
        private iTalk_HeaderLabel iTalk_HeaderLabel9;
        private iTalk_HeaderLabel iTalk_HeaderLabel11;
        private TabPage SettingGenerator;
        private iTalk_HeaderLabel iTalk_HeaderLabel12;
        private iTalk_Label iTalk_Label3;
        private iTalk_ComboBox SelectLanguage;
        private iTalk_ComboBox CFWQuestion;
        private iTalk_Label iTalk_Label2;
        private iTalk_RichTextBox OutlogTxt;
        private WebBrowser webBrowser1;
        private WebBrowser webBrowser2;
        private ImageList imageList1;
        private iTalk_LinkLabel iTalk_LinkLabel3;
    }
}

