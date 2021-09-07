using System;

namespace PictureShapes
{
    class Dice
    {
        private Square dice;
        private static Random numberGenerator;
        private int number = 5;
        private Circle[] prickar;


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
            dice.MoveHorizontal(70);
            dice.MoveVertical(-150);

            prickar[0] = new Circle();
            prickar[0].MakeVisible();
            prickar[0].ChangeColor("red");
            prickar[0].ChangeSize(85);
            prickar[0].MoveHorizontal(360);
            prickar[0].MoveVertical(40);

            prickar[1] = new Circle();
            prickar[1].MakeVisible();
            prickar[1].ChangeColor("red");
            prickar[1].ChangeSize(85);
            prickar[1].MoveHorizontal(360);
            prickar[1].MoveVertical(180);

            prickar[2] = new Circle();
            prickar[2].MakeVisible();
            prickar[2].ChangeColor("red");
            prickar[2].ChangeSize(85);
            prickar[2].MoveHorizontal(360);
            prickar[2].MoveVertical(320);

            prickar[3] = new Circle();
            prickar[3].MakeVisible();
            prickar[3].ChangeColor("red");
            prickar[3].ChangeSize(85);
            prickar[3].MoveHorizontal(220);
            prickar[3].MoveVertical(180);

            prickar[4] = new Circle();
            prickar[4].MakeVisible();
            prickar[4].ChangeColor("red");
            prickar[4].ChangeSize(85);
            prickar[4].MoveHorizontal(80);
            prickar[4].MoveVertical(180);

            prickar[5] = new Circle();
            prickar[5].MakeVisible();
            prickar[5].ChangeColor("red");
            prickar[5].ChangeSize(85);
            prickar[5].MoveHorizontal(80);
            prickar[5].MoveVertical(320);

            prickar[6] = new Circle();
            prickar[6].MakeVisible();
            prickar[6].ChangeColor("red");
            prickar[6].ChangeSize(85);
            prickar[6].MoveHorizontal(80);
            prickar[6].MoveVertical(40);

            



        }
    }
}
