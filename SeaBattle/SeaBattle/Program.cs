using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeaBattle
{
    class Data
    {
        public static int FieldWidth { get; set; }
        public static int CellWidth { get; set; }
    }

    public struct Field1
    {
        public Label[,] cells { get; set; }
    };

    public struct Field2
    {
        public Label[,] cells { get; set; }
    };

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
