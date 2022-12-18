using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDNEVNIK
{
    public partial class Glavni_meni : Form
    {
        public Glavni_meni()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba form_Osoba = new Osoba();
            form_Osoba.Show(); 
        }

        private void Glavni_meni_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Glavni_meni_Load(object sender, EventArgs e)
        {
            string user = Program.user_ime + " " + Program.user_prezime;
            l_user.Text = user;
        }
    }
}
