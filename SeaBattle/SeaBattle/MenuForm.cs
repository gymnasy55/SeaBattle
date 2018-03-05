using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form form = new User1Form();
            form.Show();
        }

        private void btnShips_Click(object sender, EventArgs e)
        {
            Form form = new ShipsForm();
            form.ShowDialog();
        }
    }
}
