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
        public static void GetNum(int num)
        {
            switch(num)
            {
                case 11:
                    //code
                    break;
                case 121:
                    //code
                    break;
                case 122:
                    //code
                    break;
                case 131:
                    //code
                    break;
                case 132:
                    //code
                    break;
                case 141:
                    //code
                    break;
                case 142:
                    //code
                    break;
                case 21:
                    //code
                    break;
                case 221:
                    //code
                    break;
                case 222:
                    //code
                    break;
                case 231:
                    //code
                    break;
                case 232:
                    //code
                    break;
                case 241:
                    //code
                    break;
                case 242:
                    //code
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
