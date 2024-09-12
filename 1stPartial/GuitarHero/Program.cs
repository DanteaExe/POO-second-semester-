using static System.Console;
using GuitarHero.Controllers;

Map map = new();
Game game = new();

Clear();

bool validOption = false;

do
{
    Clear();
    Game.ShowMainMenu();
    WriteLine("Select an option from the Main Menu: ");
    string? MainMenu = ReadLine();

    switch (MainMenu)
    {
        case "1":
            Clear();
            Game.ShowIstructions();
            bool validDifficulty = false;
            do
            {
                map.Score = 0;
                Clear();
                Game.ShowDifficultyMenu();
                WriteLine("Write the difficulty's number you want to play: ");
                string? difficulty = ReadLine();
                switch (difficulty)
                {
                    case "1":
                        WriteLine("Easy");
                        Clear();
                        game.PlaySong(50);
                        map.Guitar();
                        map.AreaDelimiter();
                        WriteLine();
                        WriteLine("Thanks for playing, Press any key to exit:");
                        ReadLine();
                        validDifficulty = true;
                        break;

                    case "2":
                        WriteLine("Medium");
                        Clear();
                        game.PlaySong(25);
                        map.Guitar();
                        map.AreaDelimiter();
                        WriteLine();
                        WriteLine("Thanks for playing, Press any key to exit:");
                        ReadLine();
                        validDifficulty = true;
                        break;

                    case "3":
                        WriteLine("Hard");
                        Clear();
                        game.PlaySong(10);
                        map.Guitar();
                        map.AreaDelimiter();
                        WriteLine();
                        WriteLine("Thanks for playing, Press any key to exit:");
                        ReadLine();
                        validDifficulty = true;
                        break;
                }
            } while (!validDifficulty);
            validOption = true;
            break;

        case "2":
            WriteLine("Byeee :D");
            validOption = true;
            break;
    }
} while (!validOption);