﻿using System;
using System.Drawing;
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
            lblShip.Text = Functions.Focused();
            Fields.field2.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            int x = 13, y = 42;
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    Fields.field2.cells[i, j] = new Label()
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
                    Fields.field2.Amount1 = 0;
                    Fields.field2.Amount2 = 0;
                    Fields.field2.Amount3 = 0;
                    Fields.field2.Amount4 = 0;
                    Fields.field2.cells[i, j].MouseEnter += new EventHandler(Functions.Label_MouseEnter);
                    Fields.field2.cells[i, j].MouseLeave += new EventHandler(Functions.Label_MouseLeave);
                    Fields.field2.cells[i, j].MouseClick += Label_MouseClick;
                    this.Controls.Add(Fields.field2.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 13;
                y += Data.CellWidth + 1;
            }
        }

        public static void Label_MouseClick(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            Point point = new Point();
            point.X = label.Location.X;
            point.Y = label.Location.Y;
            point.X = Convert.ToInt32(Math.Truncate((point.X - 13) / Convert.ToDouble(Data.CellWidth)));
            point.Y = Convert.ToInt32(Math.Truncate((point.Y - 42) / Convert.ToDouble(Data.CellWidth)));
            Functions.GetNum(point.X, point.Y);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            foreach (var item in Fields.field2.cells) { if (item.Text == "X") { Fields.field2.Count++; } }
            if (Fields.field2.Count != 20)
            {
                Functions.Error("Поле не заполнено!!!");
            }
            else
            {
                this.Controls.Clear();
                Form form = new BattleForm();
                form.Show();
                this.Close();
            }
        }

        #region Передача корабля
        private void катерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 21;
            lblShip.Text = Functions.Focused();
        }

        private void горизонтальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 221;
            lblShip.Text = Functions.Focused();
        }

        private void вертикальныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Mod = 222;
            lblShip.Text = Functions.Focused();
        }

        private void горизонтальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.Mod = 231;
            lblShip.Text = Functions.Focused();
        }

        private void вертикальныйToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Data.Mod = 232;
            lblShip.Text = Functions.Focused();
        }

        private void горизонтальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Data.Mod = 241;
            lblShip.Text = Functions.Focused();
        }

        private void вертикальныйToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Data.Mod = 242;
            lblShip.Text = Functions.Focused();
        }
        #endregion
    }
}
