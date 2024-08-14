using static System.Console;

namespace LittleSquare2
{
    class Square
    {
        public readonly int SIZE;
        private int x;
        private int y;

        public Square(int initialX, int initialY, int size)
        {
            x = initialX;
            y = initialY;
            SIZE = size;
        }

        public void Draw()
        {
            Clear();

            for (int i = 0; i < y; i++)
            {
                WriteLine();
            }

            for (int i = 0; i < SIZE; i++)
            {
                for (int j = 0; j < x; j++)
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
                Console.WriteLine();
            }
        }

        public void Move(char inputKey)
        {
            switch (inputKey)
            {
                case 'a':
                    if (x > 0)
                    {
                        x--;
                    }
                    break;
                case 'd':
                    if (x < 80 - SIZE)
                    {
                        x++;
                    }
                    break;
                case 'w':
                    if (y > 0)
                    {
                        y--;
                    }
                    break;
                case 's':
                    if (y < 24 - SIZE)
                    {
                        y++;
                    }
                    break;
                default:
                    break;
            }
        }
    }

}