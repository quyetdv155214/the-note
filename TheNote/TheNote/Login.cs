using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNote.DB;

namespace TheNote
{
    public partial class Login : Form
    {
        private DBContext dbContext;
        public Login()
        {
            InitializeComponent();
             dbContext = new DBContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            check();
        }

        private void check()
        {
            string username = tbUserName.Text;
            string password = tbPassword.Text;
            bool checkAccount = dbContext.checkAccount(username, password);
            if (checkAccount)
            {
                TheNote theNote = new TheNote();
                this.Hide();
                theNote.ShowDialog();
                this.Show();

            }
        }
    }
}
