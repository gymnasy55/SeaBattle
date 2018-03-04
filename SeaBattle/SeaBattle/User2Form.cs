﻿using System;
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

        Field2 field = new Field2();

        private void User2_Load(object sender, EventArgs e)
        {
            this.Width = 351; this.Height = 395;
            field.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            int x = 13, y = 42;
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    field.cells[i, j] = new Label
                    {
                        Top = y,
                        Left = x,
                        Width = Data.CellWidth,
                        Height = Data.CellWidth,
                        TextAlign = ContentAlignment.MiddleCenter,
                        BorderStyle = BorderStyle.FixedSingle,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold)
                    };
                    field.cells[i, j].MouseEnter += new EventHandler(Label_MouseEnter);
                    field.cells[i, j].MouseLeave += new EventHandler(Label_MouseLeave);
                    field.cells[i, j].MouseClick += Label_MouseClick;
                    this.Controls.Add(field.cells[i, j]);
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
            Form form = new User2Form();
            form.Show();
            this.Close();
        }
    }
}
