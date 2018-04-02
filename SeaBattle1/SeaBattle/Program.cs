using System;
using System.Windows.Forms;

namespace SeaBattle
{
    class Data
    {
        public static int FieldWidth { get; set; }
        public static int CellWidth { get; set; }
        public static int Mod { get; set; }
    }

    public struct Field
    {
        public  Label[,] cells { get; set; }
        public int Count { get; set; }
        public int Amount1 { get; set; }
        public int Amount2 { get; set; }
        public int Amount3 { get; set; }
        public int Amount4 { get; set; }
    };

    class Fields
    {
        public static Field field1 = new Field();
        public static Field field2 = new Field();
    }

    public class Functions
    {
        public static void Label_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BorderStyle = BorderStyle.FixedSingle;
        }

        public static void Label_MouseEnter(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.BorderStyle = BorderStyle.Fixed3D;
        }

        public static void unavaible(int X, int Y, int q = 1)
        {
            if (q == 1)
            {
                Fields.field1.cells[X, Y].MouseClick -= User1Form.Label_MouseClick;
                if (X > 0) { Fields.field1.cells[X - 1, Y].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y].Name = "0"; }
                if (Y > 0) { Fields.field1.cells[X, Y - 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X, Y - 1].Name = "0"; }
                if ((X > 0) && (Y > 0)) { Fields.field1.cells[X - 1, Y - 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y - 1].Name = "0"; }
                if (Y < 9) { Fields.field1.cells[X, Y + 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X, Y + 1].Name = "0"; }
                if (X < 9) { Fields.field1.cells[X + 1, Y].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y].Name = "0"; }
                if ((X < 9) && (Y < 9)) { Fields.field1.cells[X + 1, Y + 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y + 1].Name = "0"; }
                if ((X < 9) && (Y > 0)) { Fields.field1.cells[X + 1, Y - 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y - 1].Name = "0"; }
                if ((X > 0) && (Y < 9)) { Fields.field1.cells[X - 1, Y + 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y + 1].Name = "0"; }
            }
            else
            {
                Fields.field2.cells[X, Y].MouseClick -= User2Form.Label_MouseClick;
                if (X > 0) { Fields.field2.cells[X - 1, Y].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X - 1, Y].Name = "0"; }
                if (Y > 0) { Fields.field2.cells[X, Y - 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X, Y - 1].Name = "0"; }
                if ((X > 0) && (Y > 0)) { Fields.field2.cells[X - 1, Y - 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X - 1, Y - 1].Name = "0"; }
                if (Y < 9) { Fields.field2.cells[X, Y + 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X, Y + 1].Name = "0"; }
                if (X < 9) { Fields.field2.cells[X + 1, Y].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X + 1, Y].Name = "0"; }
                if ((X < 9) && (Y < 9)) { Fields.field2.cells[X + 1, Y + 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X + 1, Y + 1].Name = "0"; }
                if ((X < 9) && (Y > 0)) { Fields.field2.cells[X + 1, Y - 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X + 1, Y - 1].Name = "0"; }
                if ((X > 0) && (Y < 9)) { Fields.field2.cells[X - 1, Y + 1].MouseClick -= User2Form.Label_MouseClick; Fields.field2.cells[X - 1, Y + 1].Name = "0"; }
            }
        }

        public static void GetNum(int Y, int X)
        {
            switch(Data.Mod)
            {
                case 11:
                    if (Fields.field1.Amount1 < 4)
                    {
                        Fields.field1.Amount1++;
                        Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                        Fields.field1.cells[X, Y].Text = "X";
                        unavaible(X, Y);
                    }
                    else
                    {
                        Functions.Error("Максимальное количество катеров = 4!!!");
                    }
                    break;
                case 121:
                    try
                    {
                        if (Fields.field1.cells[X, Y + 1].Name != "0")
                        {
                            if (Fields.field1.Amount2 < 3)
                            {
                                Fields.field1.Amount2++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X, Y + 1].Text = "X";
                                unavaible(X, Y);
                                unavaible(X, Y + 1);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество эсминцев = 3!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 122:
                    try
                    {
                        if (Fields.field1.cells[X + 1, Y].Name != "0")
                        {
                            if (Fields.field1.Amount2 < 3)
                            {
                                Fields.field1.Amount2++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X + 1, Y].Text = "X";
                                unavaible(X, Y);
                                unavaible(X + 1, Y);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество эсминцев = 3!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 131:
                    try
                    {
                        if ((Fields.field1.cells[X, Y + 1].Name != "0") && (Fields.field1.cells[X, Y + 2].Name != "0"))
                        {
                            if (Fields.field1.Amount3 < 2)
                            {
                                Fields.field1.Amount3++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 2].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X, Y + 1].Text = "X";
                                Fields.field1.cells[X, Y + 2].Text = "X";
                                unavaible(X, Y);
                                unavaible(X, Y + 1);
                                unavaible(X, Y + 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество крейсеров = 2!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 132:
                    try
                    {
                        if ((Fields.field1.cells[X + 1, Y].Name != "0") && (Fields.field1.cells[X + 2, Y].Name != "0"))
                        {
                            if (Fields.field1.Amount3 < 2)
                            {
                                Fields.field1.Amount3++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 2, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X + 1, Y].Text = "X";
                                Fields.field1.cells[X + 2, Y].Text = "X";
                                unavaible(X, Y);
                                unavaible(X + 1, Y);
                                unavaible(X + 2, Y);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество крейсеров = 2!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 141:
                    try
                    {
                        if ((Fields.field1.cells[X, Y + 1].Name != "0") && (Fields.field1.cells[X, Y + 2].Name != "0") && (Fields.field1.cells[X, Y + 3].Name != "0"))
                        {
                            if (Fields.field1.Amount4 < 1)
                            {
                                Fields.field1.Amount4++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 2].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y + 3].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X, Y + 1].Text = "X";
                                Fields.field1.cells[X, Y + 2].Text = "X";
                                Fields.field1.cells[X, Y + 3].Text = "X";
                                unavaible(X, Y);
                                unavaible(X, Y + 1);
                                unavaible(X, Y + 2);
                                unavaible(X, Y + 3);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество линкоров = 1!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 142:
                    try
                    {
                        if ((Fields.field1.cells[X + 1, Y].Name != "0") && (Fields.field1.cells[X + 2, Y].Name != "0") && (Fields.field1.cells[X + 3, Y].Name != "0"))
                        {
                            if (Fields.field1.Amount4 < 1)
                            {
                                Fields.field1.Amount4++;
                                Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 2, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X + 3, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field1.cells[X, Y].Text = "X";
                                Fields.field1.cells[X + 1, Y].Text = "X";
                                Fields.field1.cells[X + 2, Y].Text = "X";
                                Fields.field1.cells[X + 3, Y].Text = "X";
                                unavaible(X, Y);
                                unavaible(X + 1, Y);
                                unavaible(X + 2, Y);
                                unavaible(X + 3, Y);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество катеров = 1!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;

                case 21:
                    if (Fields.field2.Amount1 < 4)
                    {
                        Fields.field2.Amount1++;
                        Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                        Fields.field2.cells[X, Y].Text = "X";
                        unavaible(X, Y, 2);
                    }
                    else
                    {
                        Functions.Error("Максимальное количество катеров = 4!!!");
                    }
                    break;
                case 221:
                    try
                    {
                        if (Fields.field2.cells[X, Y + 1].Name != "0")
                        {
                            if (Fields.field2.Amount2 < 3)
                            {
                                Fields.field2.Amount2++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X, Y + 1].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X, Y + 1, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество эсминцев = 3!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 222:
                    try
                    {
                        if (Fields.field2.cells[X + 1, Y].Name != "0")
                        {
                            if (Fields.field2.Amount2 < 3)
                            {
                                Fields.field2.Amount2++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X + 1, Y].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X + 1, Y, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество эсминцев = 3!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 231:
                    try
                    {
                        if ((Fields.field2.cells[X, Y + 1].Name != "0") && (Fields.field2.cells[X, Y + 2].Name != "0"))
                        {
                            if (Fields.field2.Amount3 < 2)
                            {
                                Fields.field2.Amount3++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 2].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X, Y + 1].Text = "X";
                                Fields.field2.cells[X, Y + 2].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X, Y + 1, 2);
                                unavaible(X, Y + 2, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество крейсеров = 2!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 232:
                    try
                    {
                        if ((Fields.field2.cells[X + 1, Y].Name != "0") && (Fields.field2.cells[X + 2, Y].Name != "0"))
                        {
                            if (Fields.field2.Amount3 < 2)
                            {
                                Fields.field2.Amount3++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 2, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X + 1, Y].Text = "X";
                                Fields.field2.cells[X + 2, Y].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X + 1, Y, 2);
                                unavaible(X + 2, Y, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество крейсеров = 2!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 241:
                    try
                    {
                        if ((Fields.field2.cells[X, Y + 1].Name != "0") && (Fields.field2.cells[X, Y + 2].Name != "0") && (Fields.field2.cells[X, Y + 3].Name != "0"))
                        {
                            if (Fields.field2.Amount4 < 1)
                            {
                                Fields.field2.Amount4++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 2].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y + 3].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X, Y + 1].Text = "X";
                                Fields.field2.cells[X, Y + 2].Text = "X";
                                Fields.field2.cells[X, Y + 3].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X, Y + 1, 2);
                                unavaible(X, Y + 2, 2);
                                unavaible(X, Y + 3, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество линкоров = 1!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
                case 242:
                    try
                    {
                        if ((Fields.field2.cells[X + 1, Y].Name != "0") && (Fields.field2.cells[X + 2, Y].Name != "0") && (Fields.field2.cells[X + 3, Y].Name != "0"))
                        {
                            if (Fields.field2.Amount4 < 1)
                            {
                                Fields.field2.Amount4++;
                                Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 2, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X + 3, Y].Anchor = AnchorStyles.Bottom;
                                Fields.field2.cells[X, Y].Text = "X";
                                Fields.field2.cells[X + 1, Y].Text = "X";
                                Fields.field2.cells[X + 2, Y].Text = "X";
                                Fields.field2.cells[X + 3, Y].Text = "X";
                                unavaible(X, Y, 2);
                                unavaible(X + 1, Y, 2);
                                unavaible(X + 2, Y, 2);
                                unavaible(X + 3, Y, 2);
                            }
                            else
                            {
                                Functions.Error("Максимальное количество линкоров = 1!!!");
                            }
                        }
                    }
                    catch (Exception ex) { }
                    break;
            }
        }

        public static string Focused()
        {
            string text = "";
            switch(Data.Mod)
            {
                case 11:
                    text = "катер";
                    break;
                case 121:
                    text = "эсминец горизонтальный";
                    break;
                case 122:
                    text = "эсминец вертикальный";
                    break;
                case 131:
                    text = "крейсер горизонтальный";
                    break;
                case 132:
                    text = "крейсер вертикальный";
                    break;
                case 141:
                    text = "линкор горизонтальный";
                    break;
                case 142:
                    text = "линкор вертикальный";
                    break;
                case 21:
                    text = "катер";
                    break;
                case 221:
                    text = "эсминец горизонтальный";
                    break;
                case 222:
                    text = "эсминец вертикальный";
                    break;
                case 231:
                    text = "крейсер горизонтальный";
                    break;
                case 232:
                    text = "крейсер вертикальный";
                    break;
                case 241:
                    text = "линкор горизонтальный";
                    break;
                case 242:
                    text = "линкор вертикальный";
                    break;
                default:
                    text = "ничего";
                    break;
            }
            return text;
        }

        public static void Message(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.FieldWidth = 10;
            Data.CellWidth = 30;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MenuForm());
        }
    }
}