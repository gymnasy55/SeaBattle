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
    public partial class User2Form : Form
    {
        public User2Form()
        {
            InitializeComponent();
        }

        private void User2_Load(object sender, EventArgs e)
        {
            this.Width = 351; this.Height = 420;
            Fields.field2.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            int x = 13, y = 42;
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    Fields.field2.cells[i, j] = new Label
                    {
                        Top = y,
                        Left = x,
                        Width = Data.CellWidth,
                        Height = Data.CellWidth,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold)
                    };
                    Fields.field2.cells[i, j].MouseEnter += new EventHandler(Label_MouseEnter);
                    Fields.field2.cells[i, j].MouseLeave += new EventHandler(Label_MouseLeave);
                    Fields.field2.cells[i, j].MouseClick += Label_MouseClick;
                    this.Controls.Add(Fields.field2.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 13;
                y += Data.CellWidth + 1;
            }
        }

        private void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BorderStyle = BorderStyle.FixedSingle;
        }

        private void Label_MouseClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            if (label.Name == "X")
            {
                label.Text = String.Empty;
                label.Name = "";
            }
            else
            {
                label.Text = "X";
                label.Name = "X";
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    if (Fields.field2.cells[i, j].Name == "X") { Fields.field2.Count++; }
                }
            }
            this.Controls.Clear();
            Form form = new BattleForm();
            form.Show();
            this.Close();
        }

        private void катерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.GetNum(21);
        }

        private void горизонтальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.GetNum(221);
        }

        private void вертикальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Functions.GetNum(222);
        }

        private void горизонтальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Functions.GetNum(231);
        }

        private void вертикальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Functions.GetNum(232);
        }

        private void горизонтальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Functions.GetNum(241);
        }

        private void вертикальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Functions.GetNum(242);
        }
    }
}
