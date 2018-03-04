using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    public partial class BattleForm : Form
    {
        public BattleForm()
        {
            InitializeComponent();
        }

        private void BattleForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < Data.FieldWidth; i++)
            {
                for(int j = 0; j < 0; j++)
                {
                    this.Controls.Add(Fields.field1.cells[i, j]);
                }
            }
        }
    }
}
