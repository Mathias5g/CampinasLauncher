using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using fivemLuncher;

namespace CampinasLauncher
{
    public partial class Form1 : Form
    {
        lib rp = new lib();

        //Global variables for Moving a Borderless Form
        Point lastPoint;

        //Variavel sombra
        private const int CS_DropShadown = 0x00020000;

        //Versões Alterações
        readonly string assemblyVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        //readonly string fileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).FileVersion;
        //readonly string productVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).ProductVersion;

        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            LblVersionNumber.Text = assemblyVersion;

            Lang.steamhata = "Abra a Steam primeiro"; //Please firt of open steam.
            Lang.hatalimesajbaslik = "Erro!"; //Error Header Message
            Lang.muzikhata = "Música não encontrada"; //Play Music Not Found Error.
            Lang.panelhata = "Erro no painel"; //Panel System ERROR
            Lang.steam64idgirinhatasi = "Erro na SteamID"; // Steamid errorr
            Lang.cokfazlaistekhatasi = "6"; //To Much Post Request error.
            Lang.uygulamaacmahatasi = "Erro ao abrir"; //Open Command error
            Lang.internethatasi = "Sem conexão com a internet"; //Internet Connection Errror.
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadown;
                return cp;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BtnDiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/KYXPdQ");
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/campinasroleplay");
        }

        private void BtnInstagram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/campinasrp");
        }

        private void BtnYoutube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/");
        }

        private void BtnTeamspeak_Click(object sender, EventArgs e)
        {
            rp.ts3open("localhost:1111");
            //System.Diagnostics.Process.Start("https://www.teamspeak.com/pt/downloads/");
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
