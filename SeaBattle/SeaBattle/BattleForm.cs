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

        Field UserField1 = new Field();
        Field UserField2 = new Field();
        bool User = true; //true - User1; false - User2
        int count1 = 0, count2 = 0;
        bool isWin = false;
        int time = 0;

        private void BattleForm_Load(object sender, EventArgs e)
        {
            this.Width = 752; this.Height = 395;
            int x = 13, y = 13;
            UserField1.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    UserField1.cells[i, j] = new Label()
                    {
                        Left = x,
                        Top = y,
                        Width = Data.CellWidth,
                        Height = Data.CellWidth,
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                        Name = Fields.field1.cells[i, j].Name,
                        Text = "",
                        Enabled = false
                    };
                    UserField1.cells[i, j].MouseEnter += new EventHandler(Label_MouseEnter);
                    UserField1.cells[i, j].MouseLeave += new EventHandler(Label_MouseLeave);
                    UserField1.cells[i, j].MouseClick += User_Click;
                    this.Controls.Add(UserField1.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 13; y += Data.CellWidth + 1;
            }

            y = 13; x = 401;
            UserField2.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for (int j = 0; j < Data.FieldWidth; j++)
                {
                    UserField2.cells[i, j] = new Label()
                    {
                        Left = x,
                        Top = y,
                        Width = Data.CellWidth,
                        Height = Data.CellWidth,
                        BorderStyle = BorderStyle.FixedSingle,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold),
                        Name = Fields.field2.cells[i, j].Name,
                        Text = ""
                    };
                    UserField2.cells[i, j].MouseEnter += new EventHandler(Label_MouseEnter);
                    UserField2.cells[i, j].MouseLeave += new EventHandler(Label_MouseLeave);
                    UserField2.cells[i, j].MouseClick += User_Click;
                    this.Controls.Add(UserField2.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 401; y += Data.CellWidth + 1;
            }
            lblUser.Text = "Ход: Первый";
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = time.ToString();
            time++;
        }

        private void User_Click(object sender, EventArgs e)
        {
            Label cell = (Label)sender;
            if(cell.Name == "X")
            {
                cell.Text = "X";
                cell.ForeColor = Color.Red;
                if(User) { count2++; } else { count1++; }
                if(count1 == Fields.field1.Count) { tmTime.Enabled = false; isWin = true; Functions.Message("Второй выиграл!!! Время игры: " + lblTime.Text + " секунд."); }
                else if (count2 == Fields.field2.Count) { tmTime.Enabled = false; isWin = true; Functions.Message("Первый выиграл!!! Время игры: " + lblTime.Text + " секунд."); }
                if (isWin)
                {
                    foreach(var item in UserField1.cells) { item.Enabled = false; }
                    foreach (var item in UserField2.cells) { item.Enabled = false; }
                }
                cell.MouseClick -= User_Click;
            }
            else
            {
                cell.Text = "N";
                cell.MouseClick -= User_Click;
                if(User)
                {
                    foreach (var item in UserField2.cells) { item.Enabled = false; }
                    foreach (var item in UserField1.cells) { item.Enabled = true; }
                    User = false;
                    lblUser.Text = "Ход: Второй";
                }
                else
                {
                    foreach (var item in UserField2.cells) { item.Enabled = true; }
                    foreach (var item in UserField1.cells) { item.Enabled = false; }
                    User = true;
                    lblUser.Text = "Ход: Первый";
                }
            }
        }
    }
}