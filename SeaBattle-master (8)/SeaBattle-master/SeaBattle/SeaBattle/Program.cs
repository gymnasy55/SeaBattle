using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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
    };


    class Fields
    {
        public static Field field1 = new Field();
        public static Field field2 = new Field();
    }

    public class Functions
    {
        public static void unavaible(int X, int Y, int q=1)
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
                    Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                    Fields.field1.cells[X, Y].Text = "X";
                    unavaible(X, Y);
                    break;
                case 121:
                    try
                    {
                        if (Fields.field1.cells[X, Y + 1].Name != "0")
                        {
                            Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field1.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                            Fields.field1.cells[X, Y].Text = "X";
                            Fields.field1.cells[X, Y + 1].Text = "X";
                            unavaible(X, Y);
                            unavaible(X, Y+1);
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                        
                    break;
                case 122:
                    try
                    {
                        if (Fields.field1.cells[X + 1, Y].Name != "0")
                        {
                            Fields.field1.cells[X, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field1.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field1.cells[X, Y].Text = "X";
                            Fields.field1.cells[X + 1, Y].Text = "X";
                            unavaible(X, Y);
                            unavaible(X + 1, Y);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 131:
                    try
                    {
                        if ((Fields.field1.cells[X, Y + 1].Name != "0")&&
                           (Fields.field1.cells[X, Y + 2].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 132:
                    try
                    {
                        if ((Fields.field1.cells[X + 1, Y].Name != "0") &&
                           (Fields.field1.cells[X + 2, Y].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 141:
                    try
                    {
                        if ((Fields.field1.cells[X, Y + 1].Name != "0") &&
                           (Fields.field1.cells[X, Y + 2].Name != "0")&&
                           (Fields.field1.cells[X, Y + 3].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 142:
                    try
                    {
                        if ((Fields.field1.cells[X + 1, Y].Name != "0") &&
                           (Fields.field1.cells[X + 2, Y].Name != "0") &&
                           (Fields.field1.cells[X + 3, Y].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 21:
                    Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                    Fields.field2.cells[X, Y].Text = "X";
                    unavaible(X, Y, 2);
                    break;
                case 221:
                    try
                    {
                        if (Fields.field2.cells[X, Y + 1].Name != "0")
                        {
                            Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field2.cells[X, Y + 1].Anchor = AnchorStyles.Bottom;
                            Fields.field2.cells[X, Y].Text = "X";
                            Fields.field2.cells[X, Y + 1].Text = "X";
                            unavaible(X, Y, 2);
                            unavaible(X, Y + 1, 2);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 222:
                    try
                    {
                        if (Fields.field2.cells[X + 1, Y].Name != "0")
                        {
                            Fields.field2.cells[X, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field2.cells[X + 1, Y].Anchor = AnchorStyles.Bottom;
                            Fields.field2.cells[X, Y].Text = "X";
                            Fields.field2.cells[X + 1, Y].Text = "X";
                            unavaible(X, Y, 2);
                            unavaible(X + 1, Y, 2);
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 231:
                    try
                    {
                        if ((Fields.field2.cells[X, Y + 1].Name != "0") &&
                           (Fields.field2.cells[X, Y + 2].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 232:
                    try
                    {
                        if ((Fields.field2.cells[X + 1, Y].Name != "0") &&
                           (Fields.field2.cells[X + 2, Y].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 241:
                    try
                    {
                        if ((Fields.field2.cells[X, Y + 1].Name != "0") &&
                           (Fields.field2.cells[X, Y + 2].Name != "0") &&
                           (Fields.field2.cells[X, Y + 3].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                case 242:
                    try
                    {
                        if ((Fields.field2.cells[X + 1, Y].Name != "0") &&
                           (Fields.field2.cells[X + 2, Y].Name != "0") &&
                           (Fields.field2.cells[X + 3, Y].Name != "0"))
                        {
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
                    }
                    catch (Exception ex)
                    {

                    }
                    break;
                default:
                    //все остальное
                    break;
            }
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
