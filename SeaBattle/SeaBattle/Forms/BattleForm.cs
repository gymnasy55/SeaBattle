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

        static Field UserField1 = new Field();
        static Field UserField2 = new Field();
        static bool User = true; //true - User1; false - User2
        static int count1 = 0, count2 = 0;
        static bool isWin = false;
        static int time = 0;

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
                        Anchor = Fields.field1.cells[i, j].Anchor,
                        Text = "",
                        Enabled = false
                    };
                    UserField1.cells[i, j].MouseEnter += new EventHandler(Functions.Label_MouseEnter);
                    UserField1.cells[i, j].MouseLeave += new EventHandler(Functions.Label_MouseLeave);
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
                        Anchor = Fields.field2.cells[i, j].Anchor,
                        Text = ""
                    };
                    UserField2.cells[i, j].MouseEnter += new EventHandler(Functions.Label_MouseEnter);
                    UserField2.cells[i, j].MouseLeave += new EventHandler(Functions.Label_MouseLeave);
                    UserField2.cells[i, j].MouseClick += User_Click;
                    this.Controls.Add(UserField2.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 401; y += Data.CellWidth + 1;
            }
            lblUser.Text = "Ход: Первый";
        }

        private void btnClose_Click(object sender, EventArgs e) => Application.Exit();

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = time.ToString();
            time++;
        }

        public static void Ship_Unavaible(int X, int Y, int q = 1)
        {
            if (q == 1)
            {
                UserField1.cells[X, Y].MouseClick -= User_Click;
                if (X > 0 && UserField1.cells[X - 1, Y].Text != "X") { UserField1.cells[X - 1, Y].MouseClick -= User_Click; UserField1.cells[X - 1, Y].Name = "0"; }
                if (Y > 0 && UserField1.cells[X, Y - 1].Text != "X") { UserField1.cells[X, Y - 1].MouseClick -= User_Click; UserField1.cells[X, Y - 1].Name = "0"; }
                if ((X > 0 && UserField1.cells[X - 1, Y - 1].Text != "X") && (Y > 0)) { UserField1.cells[X - 1, Y - 1].MouseClick -= User_Click; UserField1.cells[X - 1, Y - 1].Name = "0"; }
                if (Y < 9 && UserField1.cells[X, Y + 1].Text != "X") { UserField1.cells[X, Y + 1].MouseClick -= User_Click; UserField1.cells[X, Y + 1].Name = "0"; }
                if (X < 9 && UserField1.cells[X + 1, Y].Text != "X") { UserField1.cells[X + 1, Y].MouseClick -= User_Click; UserField1.cells[X + 1, Y].Name = "0"; }
                if ((X < 9 && UserField1.cells[X + 1, Y + 1].Text != "X") && (Y < 9)) { UserField1.cells[X + 1, Y + 1].MouseClick -= User_Click; UserField1.cells[X + 1, Y + 1].Name = "0"; }
                if ((X < 9 && UserField1.cells[X + 1, Y - 1].Text != "X") && (Y > 0)) { UserField1.cells[X + 1, Y - 1].MouseClick -= User_Click; UserField1.cells[X + 1, Y - 1].Name = "0"; }
                if ((X > 0 && UserField1.cells[X - 1, Y + 1].Text != "X") && (Y < 9)) { UserField1.cells[X - 1, Y + 1].MouseClick -= User_Click; UserField1.cells[X - 1, Y + 1].Name = "0"; }
            }
            else
            {
                UserField2.cells[X, Y].MouseClick -= User_Click;
                if (X > 0 && UserField2.cells[X - 1, Y].Text != "X") { UserField2.cells[X - 1, Y].MouseClick -= User_Click; UserField2.cells[X - 1, Y].Name = "0"; }
                if (Y > 0 && UserField2.cells[X, Y - 1].Text != "X") { UserField2.cells[X, Y - 1].MouseClick -= User_Click; UserField2.cells[X, Y - 1].Name = "0"; }
                if ((X > 0) && (Y > 0) && UserField2.cells[X - 1, Y - 1].Text != "X") { UserField2.cells[X - 1, Y - 1].MouseClick -= User_Click; UserField2.cells[X - 1, Y - 1].Name = "0"; }
                if (Y < 9 && UserField2.cells[X, Y + 1].Text != "X") { UserField2.cells[X, Y + 1].MouseClick -= User_Click; UserField2.cells[X, Y + 1].Name = "0"; }
                if (X < 9 && UserField2.cells[X + 1, Y].Text != "X") { UserField2.cells[X + 1, Y].MouseClick -= User_Click; UserField2.cells[X + 1, Y].Name = "0"; }
                if ((X < 9) && (Y < 9) && UserField2.cells[X + 1, Y + 1].Text != "X") { UserField2.cells[X + 1, Y + 1].MouseClick -= User_Click; UserField2.cells[X + 1, Y + 1].Name = "0"; }
                if ((X < 9) && (Y > 0) && UserField2.cells[X + 1, Y - 1].Text != "X") { UserField2.cells[X + 1, Y - 1].MouseClick -= User_Click; UserField2.cells[X + 1, Y - 1].Name = "0"; }
                if ((X > 0) && (Y < 9) && UserField2.cells[X - 1, Y + 1].Text != "X") { UserField2.cells[X - 1, Y + 1].MouseClick -= User_Click; UserField2.cells[X - 1, Y + 1].Name = "0"; }
            }
        }

        public void CheckShip(int Mode, int X, int Y, int goX, int goY = 0)
        {
            int goY1 = 1, goX1 = 1;
            if (User) {
                while (UserField1.cells[X + goX*goX1, Y + goY*goY1].Anchor == AnchorStyles.Bottom)
                {

                }
            }
            else
            {

            }
        }

        public static void User_Click(object sender, EventArgs e)
        {
            Label cell = (Label)sender;
            Point point = new Point();
            point.X = cell.Location.X;
            point.Y = cell.Location.Y;
            if (User)
            {
                point.X = Convert.ToInt32(Math.Truncate((point.X - 13) / Convert.ToDouble(Data.CellWidth)));
                point.Y = Convert.ToInt32(Math.Truncate((point.Y - 13) / Convert.ToDouble(Data.CellWidth)));
            }
            else
            {
                point.X = Convert.ToInt32(Math.Truncate((point.X - 401) / Convert.ToDouble(Data.CellWidth)));
                point.Y = Convert.ToInt32(Math.Truncate((point.Y - 13) / Convert.ToDouble(Data.CellWidth)));
            }
            if (cell.Anchor == AnchorStyles.Bottom)
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
                cell.Text = "•";
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