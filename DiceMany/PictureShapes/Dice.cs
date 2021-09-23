using System;

namespace PictureShapes
{
    class Dice
    {
        private Square dice;
        private static Random numberGenerator;
        private int number = 5;
        private Circle[] prickar;
        private int xPosition;
        private int yPosition;
        private int width; 


        public void Roll()
        {
            numberGenerator.Next(1, 7);
            number = numberGenerator.Next(1, 7);

            prickar[0].MakeInVisible();
            prickar[1].MakeInVisible();
            prickar[2].MakeInVisible();
            prickar[3].MakeInVisible();
            prickar[4].MakeInVisible();
            prickar[5].MakeInVisible();
            prickar[6].MakeInVisible();
            dice.MakeVisible();


            if (number %2 == 1)
            {
                prickar[0].MakeVisible();
            }

            if (number >= 2)
            {
                prickar[1].MakeVisible();
                prickar[2].MakeVisible();
            }

            if (number >= 4)
            {
                prickar[3].MakeVisible();
                prickar[4].MakeVisible();

            }
            if (number == 6)
            {
                prickar[5].MakeVisible();
                prickar[6].MakeVisible();
            }
        }
        
        public Dice()
        {
            numberGenerator = new Random();
        
            prickar = new Circle[7];
            prickar[0] = new Circle(); 
            prickar[1] = new Circle();
            prickar[2] = new Circle();
            prickar[3] = new Circle();
            prickar[4] = new Circle();
            prickar[5] = new Circle();
            prickar[6] = new Circle();


            DrawImage();
        }
        public void DrawImage()
        {
            dice = new Square();
            dice.MakeVisible();
            dice.ChangeColor("white");
            dice.ChangeSize(450);
            dice.XPosition = 120;
            dice.YPosition = 60;
            


            prickar[0] = new Circle();
            prickar[0].MakeVisible();
            prickar[0].ChangeColor("red");
            prickar[0].ChangeSize(85);
            prickar[0].XPosition = 460;
            prickar[0].YPosition = 70;
            

            prickar[1] = new Circle();
            prickar[1].MakeVisible();
            prickar[1].ChangeColor("red");
            prickar[1].ChangeSize(85);
            prickar[1].XPosition = 460;
            prickar[1].YPosition = 210;
            

            prickar[2] = new Circle();
            prickar[2].MakeVisible();
            prickar[2].ChangeColor("red");
            prickar[2].ChangeSize(85);
            prickar[2].XPosition = 460;
            prickar[2].YPosition = 350;
            

            prickar[3] = new Circle();
            prickar[3].MakeVisible();
            prickar[3].ChangeColor("red");
            prickar[3].ChangeSize(85);
            prickar[3].XPosition = 320;
            prickar[3].YPosition = 210;
            
            

            prickar[4] = new Circle();
            prickar[4].MakeVisible();
            prickar[4].ChangeColor("red");
            prickar[4].ChangeSize(85);
            prickar[4].XPosition= 180;
            prickar[4].YPosition = 210;

            prickar[5] = new Circle();
            prickar[5].MakeVisible();
            prickar[5].ChangeColor("red");
            prickar[5].ChangeSize(85);
            prickar[5].XPosition= 180;
            prickar[5].YPosition = 350;

            prickar[6] = new Circle();
            prickar[6].MakeVisible();
            prickar[6].ChangeColor("red");
            prickar[6].ChangeSize(85);
            prickar[6].XPosition= 180;
            prickar[6].YPosition = 70;

            



        }
        public int XPosition
        {
            get
            {
                return xPosition;
            }
            set
            {
                xPosition = value;
            }
        }
        public int YPosition
        {
            get
            {
                return yPosition;

            }
            set
            {
                yPosition = value;
            }
        }
        public void ChangeSize(int size)
        {
            if (size > 0)
            {
                width = size;
            }
            Roll();
        }
    }
}
