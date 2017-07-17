namespace _15.Drawing_tool
{
    using System;

    public class Rectangle : CorDraw
    {
        private int height;

        public Rectangle(int width, int height)
            : base(width)
        {
            this.height = height;
        }

        public override void DrawFigure()
        {
            Console.Write("|");
            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");

            for (int i = 0; i < this.height - 2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < this.Width; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.Write("|");
            for (int i = 0; i < this.Width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");
        }
    }
}
