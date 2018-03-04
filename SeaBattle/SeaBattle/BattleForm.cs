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

        private void BattleForm_Load(object sender, EventArgs e)
        {
            this.Width = 1000; this.Height = 395;
            int x = 13, y = 13;
            UserField1.cells = new Label[Data.FieldWidth, Data.FieldWidth];
            for (int i = 0; i < Data.FieldWidth; i++)
            {
                for(int j = 0; j < Data.FieldWidth; j++)
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
                        Name = Fields.field1.cells[i,j].Name,
                        Text = Fields.field1.cells[i, j].Name
                    };
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
                        Text = Fields.field2.cells[i, j].Name
                    };
                    this.Controls.Add(UserField2.cells[i, j]);
                    x += Data.CellWidth + 1;
                }
                x = 13; y += Data.CellWidth + 1;
            }
        }
    }
}
