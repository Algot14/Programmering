using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureShapes
{
    public partial class PictureForm : Form
    {
        private Dice[] dice;
        

        public PictureForm()
        {
            InitializeComponent();
            //this.SetStyle(ControlStyles.UserPaint, true);
            //this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dice = new Dice[5];
            dice[0] = new Dice();

            for (int nrDice = 0; nrDice < 5; ++nrDice)
            {
                dice[nrDice] = new Dice();
            }
            
            dice[0] = new Dice();
            dice[0].ChangeSize(450);
            dice[0].XPosition = 120;
            dice[0].YPosition = 60;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            canvas.Clear();
            //dice.Roll();
            for (int nrDice = 0; nrDice < 5; ++nrDice)
            {
                dice[nrDice].Roll();
            }



        }
    }
}
