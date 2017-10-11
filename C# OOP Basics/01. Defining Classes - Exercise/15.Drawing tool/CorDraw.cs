namespace _15.Drawing_tool
{
    using System;

    public abstract class CorDraw
    {
        private int width;

        public CorDraw(int width)
        {
            this.width = width;
        }

        public int Width
        {
            get { return this.width; }
        }

        public virtual void DrawFigure()
        {
            Console.Write("|");

            for (int i = 0; i < this.width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");

            for (int i = 0; i < this.width - 2; i++)
            {
                Console.Write("|");

                for (int j = 0; j < this.width; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("|");
            }

            Console.Write("|");

            for (int i = 0; i < this.width; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("|");
        }
    }
}
