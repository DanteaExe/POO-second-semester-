using static System.Console;

namespace LittleSquare2
{
    class Square
    {
        public readonly int SIZE;
        private int X { get; set;}
        private int Y{ get; set;}

        public Square(int initialX, int initialY, int size)
        {
            X = initialX;
            Y = initialY;
            SIZE = size;
        }

        public void Draw()
        {
            Clear();

            for (int i = 0; i < Y; i++)
            {
                WriteLine();
            }

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < X; j++)
                {
                    Write(" ");
                }

                for (int j = 0; j < SIZE; j++)
                {
                    if (i == 0 || i == SIZE - 1 || j == 0 || j == SIZE - 1)
                    {
                        Write("* ");
                    }
                    else
                    {
                        Write("  ");
                    }
                }
                WriteLine();
            }
        }

        public void Move(char inputKey)
        {
            switch (inputKey)
            {
                case 'a':
                    if (X > 0)
                    {
                        X--;
                    }
                    break;
                case 'd':
                    if (X < 80 - SIZE)
                    {
                        X++;
                    }
                    break;
                case 'w':
                    if (Y > 0)
                    {
                        Y--;
                    }
                    break;
                case 's':
                    if (Y < 24 - SIZE)
                    {
                        Y++;
                    }
                    break;
                default:
                    break;
            }
        }
    }

}