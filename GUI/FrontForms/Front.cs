using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontForms.GUI;

namespace FrontForms
{
    public partial class Front : Form
    {
        public Front()
        {
            InitializeComponent();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
                
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();

        }

        private void Front_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            statusStrip1.Visible = false;
            toolStrip1.Visible = false;

            var lForm = new Login();

            lForm.ShowDialog();

            if (!lForm.Loginflag) Application.Exit();

            menuStrip1.Visible = true;
            statusStrip1.Visible = true;
            toolStrip1.Visible = true;



            lblData.Text = DateTime.Now.ToLongDateString();
            
        }
    }
}
