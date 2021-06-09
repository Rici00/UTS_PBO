using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuitarCachier
{
    public partial class LoginVerif : Form
    {
        public LoginVerif()
        {
            InitializeComponent();
        }

        private void LoginVerif_Load(object sender, EventArgs e)
        {

        }

        private void btnExitLgn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOkLgn_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.LGNUsername = tbUname.Text;
            admin.LGNPassword = tbPassw.Text;
            if (admin.Verif(admin.LGNUsername, admin.LGNPassword))
            {
                Kasir Store = new Kasir();
                Store.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Verifikasi Gagal");
            }
        }
    }
}
