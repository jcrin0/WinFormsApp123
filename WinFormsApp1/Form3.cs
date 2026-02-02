using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sveKnjige = Admin.GetAllAsStrings();
            lstKnjige.Items.Clear();
            foreach (string knjiga in sveKnjige)
            {
                lstKnjige.Items.Add(knjiga);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kriterij = txtOdabir.Text;
            List<string> rezultati = Admin.SearchByTitleOrAuthor(kriterij);
            lstKnjige.Items.Clear();
            foreach (string knjiga in rezultati)
            {
                lstKnjige.Items.Add(knjiga);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
