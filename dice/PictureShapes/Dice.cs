using System;

namespace PictureShapes
{
    class Dice
    {
        private Square dice;
        private Circle prick;
        private Circle prick2;
        private Circle prick3;
        private Circle prick4;
        private Circle prick5;
        private Circle prick6;
        private Circle prick7;
        private static Random numberGenerator;
        private int number = 5;
        

        public void Roll()
        {
            numberGenerator.Next(1, 7);
            number = numberGenerator.Next(1, 7);

            prick.MakeInVisible();
            prick2.MakeInVisible();
            prick3.MakeInVisible();
            prick4.MakeInVisible();
            prick5.MakeInVisible();
            prick6.MakeInVisible();
            prick7.MakeInVisible();


            if (number %2 == 1)
            {
                prick.MakeVisible();
            }

            if (number >= 2)
            {
                prick2.MakeVisible();
                prick3.MakeVisible();
            }

            if (number >= 4)
            {
                prick4.MakeVisible();
                prick5.MakeVisible();

            }
            if (number == 6)
            {
                prick6.MakeVisible();
                prick7.MakeVisible();
            }
        }
        
        public Dice()
        {
            numberGenerator = new Random();
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

            prick = new Circle();
            prick.MakeVisible();
            prick.ChangeColor("red");
            prick.ChangeSize(85);
            prick.MoveHorizontal(360);
            prick.MoveVertical(40);

            prick2 = new Circle();
            prick2.MakeVisible();
            prick2.ChangeColor("red");
            prick2.ChangeSize(85);
            prick2.MoveHorizontal(360);
            prick2.MoveVertical(180);

            prick3 = new Circle();
            prick3.MakeVisible();
            prick3.ChangeColor("red");
            prick3.ChangeSize(85);
            prick3.MoveHorizontal(360);
            prick3.MoveVertical(320);

            prick4 = new Circle();
            prick4.MakeVisible();
            prick4.ChangeColor("red");
            prick4.ChangeSize(85);
            prick4.MoveHorizontal(220);
            prick4.MoveVertical(180);

            prick5 = new Circle();
            prick5.MakeVisible();
            prick5.ChangeColor("red");
            prick5.ChangeSize(85);
            prick5.MoveHorizontal(80);
            prick5.MoveVertical(180);

            prick6 = new Circle();
            prick6.MakeVisible();
            prick6.ChangeColor("red");
            prick6.ChangeSize(85);
            prick6.MoveHorizontal(80);
            prick6.MoveVertical(320);

            prick7 = new Circle();
            prick7.MakeVisible();
            prick7.ChangeColor("red");
            prick7.ChangeSize(85);
            prick7.MoveHorizontal(80);
            prick7.MoveVertical(40);

            



        }
    }
}
