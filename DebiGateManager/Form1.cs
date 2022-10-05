using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MaterialSkin;
using MaterialSkin.Controls;
using System.Net.Http;

namespace DebiGateManager
{
    public partial class Form1 : MaterialForm
    {
        DebiGateManager.IniFile ini = new DebiGateManager.IniFile(@"settings.ini");
        public Form1()
        {
            Process[] processes = Process.GetProcessesByName("DebiGateManager");
            if (processes.Length > 1) { MessageBox.Show("Duplicated Manager. Open from taskbar."); this.Close(); }


            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Green900, Primary.Grey900, Primary.Green500, Accent.LightGreen400, TextShade.WHITE);


            // Manager Settings
            if (ini.KeyExists("Path_Node")) { Path_Node_TB.Text = ini.Read("Path_Node"); }
            else { ini.Write("Path_Node", Path_Node_TB.Text); }
            if (ini.KeyExists("Path_GateWay")) { Path_Gateway_TB.Text = ini.Read("Path_GateWay"); }
            else { ini.Write("Path_GateWay", Path_Gateway_TB.Text); }
            if (ini.KeyExists("Auto_Start")) { Auto_Start_CB.Checked = Convert.ToBoolean(ini.Read("Auto_Start")); }
            else { ini.Write("Auto_Start", Convert.ToString(Auto_Start_CB.Checked)); }
            // Service Settings
            if (ini.KeyExists("APIHOST", "ServiceSettings")) { APIHOST_TB.Text = ini.Read("APIHOST", "ServiceSettings"); }
            else { ini.Write("APIHOST", APIHOST_TB.Text, "ServiceSettings"); }
            if (ini.KeyExists("APIPORT", "ServiceSettings")) { APIPORT.Text = ini.Read("APIPORT", "ServiceSettings"); }
            else { ini.Write("APIPORT", APIPORT.Text, "ServiceSettings"); }
            if (ini.KeyExists("APIGATEPATH_AUTH", "ServiceSettings")) { APIGATEPATH_AUTH_TB.Text = ini.Read("APIGATEPATH_AUTH", "ServiceSettings"); }
            else { ini.Write("APIGATEPATH_AUTH", APIGATEPATH_AUTH_TB.Text, "ServiceSettings"); }
            if (ini.KeyExists("APIGATEPATH_CONNECTOR", "ServiceSettings")) { APIGATEPATH_CONNECTOR_TB.Text = ini.Read("APIGATEPATH_CONNECTOR", "ServiceSettings"); }
            else { ini.Write("APIGATEPATH_CONNECTOR", APIGATEPATH_CONNECTOR_TB.Text, "ServiceSettings"); }
            if (ini.KeyExists("APIGATEPATH_DBTRANSLATE", "ServiceSettings")) { APIGATEPATH_DBTRANSLATE_TB.Text = ini.Read("APIGATEPATH_DBTRANSLATE", "ServiceSettings"); }
            else { ini.Write("APIGATEPATH_DBTRANSLATE", APIGATEPATH_DBTRANSLATE_TB.Text, "ServiceSettings"); }
            if (ini.KeyExists("LANGUAGE", "ServiceSettings")) { LANGUAGE_TB.Text = ini.Read("LANGUAGE", "ServiceSettings"); }
            else { ini.Write("LANGUAGE", LANGUAGE_TB.Text, "ServiceSettings"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConsoleTB.BackColor = ColorTranslator.FromHtml("#333333");

            DebiGateManager.IniFile userini = new DebiGateManager.IniFile(@"user.ini");
            if (userini.KeyExists("username", "DebiGateWay") && userini.KeyExists("password", "DebiGateWay")) { 
                username_TB.Text = userini.Read("username", "DebiGateWay");
                password_TB.Text = userini.Read("password", "DebiGateWay");


                if (Auto_Start_CB.Checked) { Run_BTN.Enabled = false; Run_BTN.Text = "LOADING.."; autostarter.Enabled = true; }
            }
            else {
                username_TB.Enabled = true;
                username_TB.Focus();
                password_TB.Enabled = true;
                Login_BTN.Enabled = true;
                Logout_BTN.Enabled = false;
                Run_BTN.Enabled = false;
            }



        }

        private void runService()
        {
            Process[] processes = Process.GetProcessesByName("nodeAkatron");

            foreach (Process p in processes)
            {
                p.Kill();
            }

            new Task(ServiceRunner).Start();
            ConsoleTB.Text += Environment.NewLine + "--- Service started.";
        }

        private void stopService()
        {
            proc.Kill();
            ConsoleTB.Text += Environment.NewLine + "--- Service stopped.";
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (Run_BTN.Text == "RUN SERVICE") {

                runService();

                materialTabControl1.SelectedIndex = 2;
            }
            else {

                stopService();

                ConsoleTB.SelectionStart = ConsoleTB.TextLength;
                ConsoleTB.ScrollToCaret();
            }
            ServiceRunCTRL.Enabled = true;
        }

        Process proc = new Process();

        private void ServiceRunner()
        {

            proc = new Process {
                StartInfo = new ProcessStartInfo {
                    FileName = Path_Node_TB.Text,
                    Arguments = "\"" + Path_Gateway_TB.Text + "index.js" + "\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            while (!proc.StandardOutput.EndOfStream) {
                string line = proc.StandardOutput.ReadLine();
                line = line.Replace("[33m", "").Replace("[2m", "").Replace("[0m", "").Replace("[37m", "").Replace("[31m", "");
                ConsoleTB.Text += Environment.NewLine + line;
                ConsoleTB.SelectionStart = ConsoleTB.TextLength;
                ConsoleTB.ScrollToCaret();
            }
        }

        private void ServiceRunCTRL_Tick(object sender, EventArgs e)
        {
            if (!proc.HasExited) {
                Run_BTN.Text = "STOP SERVICE";
                Service_State_TB.Text = "Service: Active!";
            }
            else {
                Run_BTN.Text = "RUN SERVICE";
                Service_State_TB.Text = "Service: Deactive!";
            }

            Run_BTN.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (proc.StartInfo.FileName == "") { Application.Exit(); }
            else if (proc.HasExited) { Application.Exit(); }
            else { e.Cancel = true; this.Hide(); notifyIcon1.ShowBalloonTip(3000); }
        }

        // Save Settings
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            ini.Write("Path_Node", Path_Node_TB.Text);
            ini.Write("Path_GateWay", Path_Gateway_TB.Text);
            ini.Write("Auto_Start", Convert.ToString(Auto_Start_CB.Checked));
            ini.Write("APIHOST", APIHOST_TB.Text, "ServiceSettings");
            ini.Write("APIPORT", APIPORT.Text, "ServiceSettings");
            ini.Write("APIGATEPATH_AUTH", APIGATEPATH_AUTH_TB.Text, "ServiceSettings");
            ini.Write("APIGATEPATH_CONNECTOR", APIGATEPATH_CONNECTOR_TB.Text, "ServiceSettings");
            ini.Write("APIGATEPATH_DBTRANSLATE", APIGATEPATH_DBTRANSLATE_TB.Text, "ServiceSettings");
            ini.Write("LANGUAGE", LANGUAGE_TB.Text, "ServiceSettings");

            MessageBox.Show("Saved succesfully");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) { this.Show(); }

        private void NotifyMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "Open") { this.Show(); }
            if (e.ClickedItem.Name == "Exit") { try { proc.Kill(); } catch {} Application.Exit(); }
        }

        private void Logout_BTN_Click(object sender, EventArgs e)
        {
            username_TB.Enabled = true;
            password_TB.Enabled = true;
            Login_BTN.Enabled = true;
            Logout_BTN.Enabled = false;

            try { proc.Kill(); } catch { }
            Run_BTN.Enabled = false;
            ServiceRunCTRL.Enabled = false;

        }
        
        private static readonly HttpClient client = new HttpClient();
        
        private void Login_BTN_Click(object sender, EventArgs e)
        {
            if (username_TB.Text.Length > 0 && password_TB.Text.Length > 0)
            {
                login(username_TB.Text, password_TB.Text);
            }
            else
            {
                MessageBox.Show("Please fill the inputs first.");
            }
        }

        private async void login(string username, string password)
        {
            var ans = await client.GetAsync("http://localhost:8000/api/functions/gateway/auth/?username=" + username + "&password=" + password);
            string res = await ans.Content.ReadAsStringAsync();

            bool success = (res.Substring(11, 4) == "true");

            if (!success) { MessageBox.Show("Login failed. \n\n" + res); return; }

            int keypassi = res.IndexOf("\"password\":") + 12;
            string stcut = res.Substring(keypassi);

            int quotei = stcut.IndexOf("\"");
            string hashpass = stcut.Substring(0, quotei);


            DebiGateManager.IniFile userini = new DebiGateManager.IniFile(@"user.ini");
            userini.Write("username", username, "DebiGateWay");
            userini.Write("password", hashpass, "DebiGateWay");

            MessageBox.Show("Welcome!");


            username_TB.Enabled = false;
            password_TB.Enabled = false;
            Login_BTN.Enabled = false;
            Logout_BTN.Enabled = true;
            Run_BTN.Enabled = true;

        }

        private void autostarter_Tick(object sender, EventArgs e)
        {
            materialTabControl1.SelectedIndex = 2;
            runService();
            autostarter.Enabled = false;
            ServiceRunCTRL.Enabled = true;
        }


        // Text coloring in rich text box
        private void AppendText(string text, Color color, bool bold)
        {
            ConsoleTB.SelectionStart = ConsoleTB.TextLength;
            ConsoleTB.SelectionColor = color;
            ConsoleTB.SelectionFont = new Font(ConsoleTB.Font, bold ? FontStyle.Bold : FontStyle.Regular);
            ConsoleTB.SelectedText = text;
        }
    }
}
