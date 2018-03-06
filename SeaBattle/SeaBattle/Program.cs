﻿using System;
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
        public static void unavaible(int X, int Y)
        {
            Fields.field1.cells[X, Y].MouseClick -= User1Form.Label_MouseClick;
            if (X > 0) { Fields.field1.cells[X-1, Y].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y].Name = "0"; }
            if (Y > 0) { Fields.field1.cells[X, Y-1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X, Y - 1].Name = "0"; }
            if ((X > 0) && (Y > 0)) { Fields.field1.cells[X-1, Y-1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y - 1].Name = "0"; }
            if (Y < 9) { Fields.field1.cells[X, Y+1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X, Y + 1].Name = "0"; }
            if (X < 9) { Fields.field1.cells[X+1, Y].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y].Name = "0"; }
            if ((X < 9)&&(Y < 9)) { Fields.field1.cells[X+1, Y+1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y + 1].Name = "0"; }
            if ((X < 9) && (Y > 0)) { Fields.field1.cells[X + 1, Y - 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X + 1, Y - 1].Name = "0"; }
            if ((X > 0) && (Y < 9)) { Fields.field1.cells[X - 1, Y + 1].MouseClick -= User1Form.Label_MouseClick; Fields.field1.cells[X - 1, Y + 1].Name = "0"; }
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
