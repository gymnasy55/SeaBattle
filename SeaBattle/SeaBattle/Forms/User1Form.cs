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
    public partial class User1Form : Form
    {
        public User1Form()
        {
            InitializeComponent();
        }

        private void User1_Load(object sender, EventArgs e)
        {
            this.Width = 351; this.Height = 420;
            Fields.field1.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            int x = 13, y = 42;
            for(int i = 0; i < Data.FieldWidth; i++)
            {
                for(int j = 0; j < Data.FieldWidth; j++)
                {
                    Fields.field1.cells[i, j] = new Label()
                    {
                        Top = y,
                        Left = x,
                        Width = Data.CellWidth,
                        Height = Data.CellWidth,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                        Name = "",
                        Anchor = AnchorStyles.None
                    };
                    Fields.field1.cells[i, j].MouseEnter += new EventHandler(Label_MouseEnter);
                    Fields.field1.cells[i, j].MouseLeave += new EventHandler(Label_MouseLeave);
                    Fields.field1.cells[i, j].MouseClick += Functions.Label_MouseClick;
                    this.Controls.Add(Fields.field1.cells[i, j]);
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

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach(var item in Fields.field1.cells)
            {
                if(item.Anchor == AnchorStyles.Bottom) { Fields.field1.Count++; }
            }
            if(Fields.field1.Count == 0)
            {
                Functions.Error("Поле не может быть пустым!!!");
            }
            else
            {
                this.Controls.Clear();
                Form form = new User2Form();
                form.Show();
                this.Close();
            }
        }

        #region Передача корабля
        private void катерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 11;
        }

        private void горизонтальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 121;
        }

        private void вертикальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 122;
        }

        private void горизонтальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.Mod = 131;
        }

        private void вертикальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.Mod = 132;
        }

        private void горизонтальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Data.Mod = 141;
        }

        private void вертикальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Data.Mod = 142;
        }
        #endregion
    }
}
