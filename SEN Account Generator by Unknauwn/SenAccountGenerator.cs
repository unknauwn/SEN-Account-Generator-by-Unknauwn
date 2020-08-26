using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace SEN_Account_Generator_by_Unknauwn
{
    public partial class SenAccountGenerator : Form
    {
        public SenAccountGenerator()
        {
            InitializeComponent();
        }

        private string Mail;
        private string MailUser;
        private string Domain;
        private string[] Errors = new string[4];
        private Form ValidateMail;

        private void ButtonClick(object sender, EventArgs e)
        {
            ValidateMail.Close();
            base.Show();
            EmailLbl.Text = MailUser;
            PasswordLbl.Text = PasswordTxt.Text;
            UsernameLbl.Text = UsernameTxt.Text + RandomCharUser.Text;
            webBrowser1.Document.GetElementById("emailVerificationSaveBtn").InvokeMember("click");
            OutlogTxt.AppendText(DateTime.Now.ToString() + " : Verifying Confirmation... Please Wait...", Color.DimGray);
            Waitil(5);
            if (webBrowser1.Url.ToString() == "https://account.sonyentertainmentnetwork.com/liquid/security/unverified-user!input.action?e=emailVerification.error.notVerified")
            {
                OutlogTxt.AppendText(DateTime.Now.ToString() + " : Error, " + webBrowser1.Document.GetElementById("errorDivMessage").InnerText, Color.Red);
            }
            else
            {
                iTalk_Button_21.Enabled = false;
                iTalk_Button_21.Text = "Status : OK!";
                iTalk_HeaderLabel7.Visible = true;
                OutlogTxt.AppendText(DateTime.Now.ToString() + " : Done! Your Account has been successfully Generated!", Color.Green);
                OutlogTxt.AppendText(DateTime.Now.ToString() + " : Visit All of our other Apps on http://unknowndevteam.org !", Color.Green);
                EmailLbl.Text = MailUser;
                PasswordLbl.Text = PasswordTxt.Text;
                UsernameLbl.Text = UsernameTxt.Text + RandomCharUser.Text;
                GeneratorPanel.SelectedTab = AboutPage;
            }
        }

        private void ClickOnButton(string ID)
        {
            webBrowser1.Document.GetElementById(ID).InvokeMember("click");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int BrowserVer, RegVal;
            // get the installed IE version
            using (WebBrowser Wb = new WebBrowser())
                BrowserVer = Wb.Version.Major;

            // set the appropriate IE version
            if (BrowserVer >= 11)
                RegVal = 11001;
            else if (BrowserVer == 10)
                RegVal = 10001;
            else if (BrowserVer == 9)
                RegVal = 9999;
            else if (BrowserVer == 8)
                RegVal = 8888;
            else
                RegVal = 7000;

            // set the actual key
            RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true);
            Key.SetValue(System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe", RegVal, RegistryValueKind.DWord);
            Key.Close();

            webBrowser1.Navigate("https://account.sonyentertainmentnetwork.com/liquid/external/create-account!input.action?service-entity=psn&returnURL=https://secure.eu.playstation.com/psnauth/PSNPdcResponse/pdc/?returnURL%3Dhttps://secure.eu.playstation.com/psn/mypsn/competelanding/");
            webBrowser2.Navigate("http://email-fake.com");

            RandomCharUser.Text = "-" + Randomizer.RandomNumber(1, 9).ToString() + Randomizer.RandomString(2).ToLower();
            PasswordTxt.Text = "azerty12";
            OutlogTxt.AppendText(DateTime.Now.ToString() + " : SEN Account Generator by Unknauwn Successfully Initialized!", Color.Green);
            GeneratorPanel.SelectedTab = SettingGenerator;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                try
                {
                    Mail = webBrowser2.Document.GetElementById("userName").GetAttribute("value");
                    //Domain = webBrowser2.Document.GetElementById("domainName").GetAttribute("selected value");
                    HtmlElement SelectedValue = webBrowser2.Document.GetElementById("domainName");
                    foreach (HtmlElement child in SelectedValue.All)
                    {
                        if (child.GetAttribute("tagName").Equals("OPTION") && child.GetAttribute("selected").Equals("True"))
                        {
                            Domain = child.GetAttribute("text");
                            break;
                        }
                    }

                    MailUser = Mail + Domain;
                    webBrowser1.Document.GetElementById("account_loginNameFieldInput").SetAttribute("value", MailUser);
                    webBrowser1.Document.GetElementById("dayDropDown").SetAttribute("value", Randomizer.RandomNumber(1, 0x1f).ToString());
                    webBrowser1.Document.GetElementById("monthDropDown").SetAttribute("value", Randomizer.RandomNumber(1, 12).ToString());
                    webBrowser1.Document.GetElementById("yearDropDown").SetAttribute("value", Randomizer.RandomNumber(0x79e, 0x7ca).ToString());
                    webBrowser1.Document.GetElementById("regInput_Country").SetAttribute("value", "FR");
                    webBrowser1.Document.GetElementById("account_loginNameFieldInput").SetAttribute("value", MailUser);
                    foreach (HtmlElement element in webBrowser1.Document.GetElementsByTagName("input"))
                    {
                        if (((element.GetAttribute("name") != string.Empty) && (element.GetAttribute("name").Length != 0)) && (element.GetAttribute("name") == "account.password"))
                        {
                            element.SetAttribute("value", PasswordTxt.Text);
                        }
                    }
                    webBrowser1.Document.GetElementById("confirmPasswordField").SetAttribute("value", PasswordTxt.Text);
                    object[] args = new object[] { MailUser, "account_loginNameFieldInput", PasswordTxt.Text, "account_password" };
                    webBrowser1.Document.InvokeScript("validatePasswordAJAX", args);

                    if (UsernameTxt.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Username Empty", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (PasswordTxt.Text.Equals(String.Empty))
                    {
                        MessageBox.Show("Password Empty", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else if (PasswordTxt.Lenght() < 8)
                    {
                        MessageBox.Show("Password lenght minimum is 8", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        webBrowser1.Document.GetElementById("createAccountButton").InvokeMember("click");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Step 1... Please Wait...", Color.DimGray);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.ToString());
                    OutlogTxt.AppendText(DateTime.Now.ToString() + " : Error with Sony Website or GeneratorWebsite, Please wait few minutes and try again.", Color.Red);
                }
            }
            Waitil(5);
            if (Errors[0] != null)
            {
                OutlogTxt.AppendText(Errors[0], Color.Red);
            }
            else if (Errors[1] != null)
            {
                OutlogTxt.AppendText(Errors[1], Color.Red);
            }
            else if (Errors[2] != null)
            {
                OutlogTxt.AppendText(Errors[2], Color.Red);
            }
            else if (Errors[3] != null)
            {
                OutlogTxt.AppendText(Errors[3], Color.Red);
            }
        }

        private void GenerateButtonAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        
        private void HidePass_CheckedChanged(object sender)
        {
            if (HidePass.Checked)
            {
                PasswordTxt.UseSystemPasswordChar = true;
            }
            else
            {
                PasswordTxt.UseSystemPasswordChar = false;
            }
        }

        private void iTalk_Button_21_Click(object sender, EventArgs e)
        {
            ValidateMail = new Form();
            iTalk_ThemeContainer container = new iTalk_ThemeContainer();
            WebBrowser browser = new WebBrowser();
            iTalk_Button_2 ButtonRefresh = new iTalk_Button_2();
            iTalk_Button_2 ButtonBack = new iTalk_Button_2();
            MessageBox.Show("If you dont Receive Mail, Maybe Sony Website got some trouble, wait few minutes to few hours...", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            browser.ScriptErrorsSuppressed = true;
            browser.Url = new Uri("http://email-fake.com/" + Domain.Replace("@", "") + "/" + Mail);
            browser.SetBounds(3, 0x1c, 580, 0x155);
            ButtonBack.Text = "Back and Confirm!";
            ButtonBack.SetBounds(300, 377, 166, 40);
            ButtonRefresh.Text = "Refresh";
            ButtonRefresh.Location = new Point(ButtonBack.Location.X - (ButtonBack.Size.Width + 5), ButtonBack.Location.Y);
            ValidateMail.TopMost = true;
            ValidateMail.ShowInTaskbar = false;
            ValidateMail.StartPosition = FormStartPosition.CenterScreen;
            ValidateMail.Size = new Size(0x25d, 0x1e8);
            ValidateMail.Controls.AddRange(new Control[] { container });
            ValidateMail.SizeGripStyle = SizeGripStyle.Hide;
            container.Controls.Add(browser);
            container.Controls.Add(ButtonRefresh);
            container.Controls.Add(ButtonBack);
            container.Sizable = false;
            ValidateMail.FormBorderStyle = FormBorderStyle.None;
            ValidateMail.StartPosition = FormStartPosition.CenterScreen;
            ButtonBack.Click += new EventHandler(ButtonClick);
            ButtonRefresh.Click += (send, ei) =>
            {
                browser.Refresh();
            };
            base.Hide();
            ValidateMail.Show();
        }

        private void iTalk_LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://realitygaming.fr");
        }

        private void iTalk_LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://hackandmodz.net");
        }

        private void iTalk_LinkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://unknowndevteam.org/");
        }
        
        private void SelectLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectLanguage.SelectedIndex == 1)
            {
                iTalk_HeaderLabel1.Text = "Pseudo :";
                iTalk_HeaderLabel10.Text = "Pseudo :";
                iTalk_HeaderLabel2.Text = "Mdp :";
                iTalk_HeaderLabel6.Text = "Mdp :";
                GenerateButton.Text = "Generer le Compte";
                GenerateAgainButton.Text = "Generer Encore?";
                SettingPage.Text = "Parametres Compte";
                AboutPage.Text = "Infos Compte";
                SettingGenerator.Text = "Parametres";
                iTalk_Button_21.Text = "Verifier l'Email?";
                iTalk_HeaderLabel7.Text = "Succesfully Generated!";
                iTalk_HeaderLabel12.Text = "Note : CFW 4.65 et Plus ont besoin de verifier l'Email.";
                HidePass.Text = "Cacher?";
            }
            else
            {
                iTalk_HeaderLabel1.Text = "Username :";
                iTalk_HeaderLabel10.Text = "Username :";
                iTalk_HeaderLabel2.Text = "Password :";
                iTalk_HeaderLabel6.Text = "Password :";
                GenerateButton.Text = "Generate Account";
                GenerateAgainButton.Text = "Generate Again?";
                SettingPage.Text = "Settings Account";
                AboutPage.Text = "About Account";
                SettingGenerator.Text = "Settings";
                iTalk_Button_21.Text = "Verify Email?";
                iTalk_HeaderLabel7.Text = "Generer avec Succes!";
                iTalk_HeaderLabel12.Text = "Note : CFW 4.65 and More need to Verify Email.";
                HidePass.Text = "Hide?";
            }
            OutlogTxt.AppendText(DateTime.Now.ToString() + " : Language UI Changed!", Color.Green);
        }

        private void SetValue(string ID, string Value)
        {
            webBrowser1.Document.GetElementById(ID).SetAttribute("value", Value);
        }

        private void Waitil(int Time)
        {
            DateTime now = DateTime.Now;
            do
            {
                Application.DoEvents();
            }
            while (now.AddSeconds((double)Time) > DateTime.Now);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState == WebBrowserReadyState.Complete)
            {
                if (webBrowser1.Document.GetElementById("account_loginNameFieldError") != null)
                {
                    Errors[0] = DateTime.Now.ToString() + " : Error, " + webBrowser1.Document.GetElementById("account_loginNameFieldError").InnerText;
                }
                else if (webBrowser1.Document.GetElementById("confirmPasswordFieldError") != null)
                {
                    Errors[1] = DateTime.Now.ToString() + " : Error, " + webBrowser1.Document.GetElementById("confirmPasswordFieldError").InnerText;
                }
                else if (webBrowser1.Document.GetElementById("g-recaptcha-responseFieldError") != null)
                {
                    Errors[2] = DateTime.Now.ToString() + " : Error, " + webBrowser1.Document.GetElementById("g-recaptcha-responseFieldError").InnerText;
                }
                else if (webBrowser1.Document.GetElementById("errorDivMessage") != null)
                {
                    Errors[3] = DateTime.Now.ToString() + " : Error, " + webBrowser1.Document.GetElementById("errorDivMessage").InnerText;
                }
                if (webBrowser1.Url.ToString() != "https://account.sonyentertainmentnetwork.com/liquid/external/create-account!input.action?service-entity=psn&returnURL=https://secure.eu.playstation.com/psnauth/PSNPdcResponse/pdc/?returnURL%3Dhttps://secure.eu.playstation.com/psn/mypsn/competelanding/&cancelURL")
                {
                    if (webBrowser1.Url.ToString().Contains("edit-profile"))
                    {
                        this.Width = 494;
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Step 1 => OK!", Color.Green);
                        SetValue("handleFieldInput", UsernameTxt.Text + RandomCharUser.Text);
                        ClickOnButton("saveIdentityButton");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Step 2... Please Wait...", Color.DimGray);
                    }
                    else if (webBrowser1.Url.ToString().Contains("identity-security"))
                    {
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Step 2 => OK!", Color.Green);
                        SetValue("firstNameField", Randomizer.RandomString(Randomizer.RandomNumber(5, 12)));
                        SetValue("lastNameField", Randomizer.RandomString(Randomizer.RandomNumber(5, 12)));
                        SetValue("securityQuestionListField", "Quel est votre lieu de naissance ?");
                        SetValue("securityAnswerField", Randomizer.RandomString(Randomizer.RandomNumber(5, 0x11)));
                        ClickOnButton("saveIdentityButton");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Step 3... Please Wait...", Color.DimGray);
                    }
                    else if (webBrowser1.Url.ToString().Contains("edit-location"))
                    {
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Step 3 => OK!", Color.Green);
                        SetValue("address_address1Field_input", Randomizer.RandomString(Randomizer.RandomNumber(10, 0x13)));
                        SetValue("address_cityField_input", Randomizer.RandomString(Randomizer.RandomNumber(8, 14)));
                        SetValue("address_provinceField_input", Randomizer.RandomString(Randomizer.RandomNumber(5, 9)));
                        SetValue("address_zipCodeField_input", Randomizer.RandomNumber(0x2710, 0x16378).ToString());
                        ClickOnButton("saveLocationButton");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Step 4... Please Wait...", Color.DimGray);
                    }
                    else if (webBrowser1.Url.ToString().Contains("connect-billing!input.action"))
                    {
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Step 4 => OK!", Color.Green);
                        webBrowser1.Document.InvokeScript("doNo");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Step 5... Please Wait...", Color.DimGray);
                    }
                    else if (webBrowser1.Url.ToString().Contains("connect-billing!no-billing.action"))
                    {
                        webBrowser1.Navigate("https://account.sonyentertainmentnetwork.com/cam/devices/playstation/notify-settings!input.action");
                    }
                    else if (webBrowser1.Url.ToString().Contains("notify-settings"))
                    {
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Step 5 => OK!", Color.Green);
                        ClickOnButton("notificationSettingsSaveBtn");
                        OutlogTxt.AppendText(DateTime.Now.ToString() + " : Processing Final Step... Please Wait...", Color.DimGray);
                    }
                    else if (webBrowser1.Url.ToString().Contains("unverified-user!input.action?m=psnUpgradeSuccess"))
                    {
                        if (CFWQuestion.SelectedIndex == 0)
                        {
                            OutlogTxt.AppendText(DateTime.Now.ToString() + " : Done! Your Account has been successfully Generated!", Color.Green);
                            OutlogTxt.AppendText(DateTime.Now.ToString() + " : CFW 4.65+ => You have selected 'No', You don't need to Verify the Email : )", Color.Green);
                            EmailLbl.Text = MailUser;
                            iTalk_HeaderLabel7.Visible = true;
                            iTalk_Button_21.Enabled = true;
                            PasswordLbl.Text = PasswordTxt.Text;
                            UsernameLbl.Text = UsernameTxt.Text + RandomCharUser.Text;
                            GeneratorPanel.SelectedTab = AboutPage;
                        }
                        else
                        {
                            iTalk_HeaderLabel7.Visible = true;
                            iTalk_Button_21.Enabled = true;
                            EmailLbl.Text = MailUser;
                            PasswordLbl.Text = PasswordTxt.Text;
                            UsernameLbl.Text = UsernameTxt.Text + RandomCharUser.Text;
                            GeneratorPanel.SelectedTab = AboutPage;
                            OutlogTxt.AppendText(DateTime.Now.ToString() + " : Alerte, CFW 4.65+ => You have selected 'Yes',  Please verify Email and Confirm it!", Color.Red);
                        }
                    }
                    else
                    {
                        String[] ItemtoHide = new string[] { "blackHeaderBar", "topLogo", "marketingAreaSection", "signInLinkSection", "messageTargetDiv", "errorDiv", "createNewAccountHeaderTitle", "regLabel_SignInID", "account_loginNameFieldInput", "signInIdContextualHelp", "labelSignInIDExample", "regLabel_DateOfBirth", "div_dayDropDown", "div_monthDropDown", "div_yearDropDown", "regLabel_Gender", "genderMaleSection", "genderFemaleSection", "regLabel_Country", "regInput_Country", "regLabel_Language", "regInput_Language", "accountLanguage", "regLabel_CreatePassword", "account_password", "passwordContextualHelp", "passwordStrengthText", "passwordStrengthMeter", "account_passwordField", "regLabel_ConfirmPassword", "confirmPasswordField", "notificationSettingsWrapper", "termsOfServiceButton", "privacyButton", "dataWillBeChangeForAllLinkedServices", "regLabel_EULALegalBlurbMobile", "createAccountButtonSection", "footerContainer" };
                        foreach (String divstring in ItemtoHide)
                            webBrowser1.Document.GetElementById(divstring).Style = "display:none";
                    }
                }
            }
        }

       
    }
}
