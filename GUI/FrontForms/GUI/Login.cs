using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontForms.GUI
{
    public partial class Login : Form
    {
        public bool Loginflag;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        public void btnEnterLogin_Click(object sender, EventArgs e)
        {
            Loginflag = true;

            this.Close();
        }
    }
}
