namespace PictureShapes
{
    class Picture
    {
        private Square wall;
        private Triangle roof;
        private Square window;
        private Circle sol;
        public Picture()
        {
            DrawImage();
        }
        public void DrawImage()
        {
            wall = new Square();
            wall.MakeVisible();
            wall.ChangeColor("red");
            wall.ChangeSize(200);
            wall.MoveHorizontal(70);
            wall.MoveVertical(20);

            roof = new Triangle();
            roof.MakeVisible();
            roof.ChangeColor("black");
            roof.ChangeSize(260);
            roof.MoveHorizontal(-13);
            roof.MoveVertical(-10);

            window = new Square();
            window.MakeVisible();
            window.ChangeColor("black");
            window.ChangeSize(60);
            window.MoveHorizontal(80);
            window.MoveVertical(60);

            sol = new Circle();
            sol.MakeVisible();
            sol.ChangeColor("yellow");
            sol.ChangeSize(100);
            sol.MoveHorizontal(475);
            sol.MoveVertical(30);



        }
    }
}
