using System;

namespace Lesson4
{
    class Program
    {
        //Крестики-нолики в процедурном стиле
        static int[,] fieldMatrix;
        const int FIELD_SIZE = 3;
        const char X = 'X';
        const char O = 'O';
        const char EMPTY = '*';
        static char playerSymbol;
        static char aISymbol;
        static int stepsCountDown;
        static bool isWin;
        static bool tryAgain;
        static void Main(string[] args)
        {
            do
            {
                stepsCountDown = FIELD_SIZE * FIELD_SIZE;
                isWin = false;
                tryAgain = false;
                InitField();
                ChooseCharacter();
                PrintField();

                while (!isWin)
                {
                    PlayerStep();
                    PrintField();
                    CheckWin();
                    if (!isWin)
                    {
                        AIStep();
                        PrintField();
                        CheckWin();
                    }

                }
                Console.WriteLine("Игра окончена, сыграть еще раз? 1 - да, любая другая кнопка - нет");
                string userInput = Console.ReadLine();
                tryAgain = userInput == "1";
            } while (tryAgain);
            
        }
        static void CheckWin()
        {
            CheckHorizontals();
            CheckVerticals();
            CheckDiagonals();
            if (!isWin && stepsCountDown == 0)
            {
                isWin = true;
                Console.WriteLine("Победила дружба!");
            }
        }
        static void CheckDiagonals()
        {
            if (fieldMatrix[0, 0] != 0 && fieldMatrix[1, 1] == fieldMatrix[0, 0] && fieldMatrix[1, 1] == fieldMatrix[2, 2] ||
            fieldMatrix[2, 0] != 0 && fieldMatrix[2, 0] == fieldMatrix[1, 1] && fieldMatrix[0, 2] == fieldMatrix[1, 1]
            )
            {
                isWin = true;
                if (fieldMatrix[1, 1] == 1)
                {
                    Console.WriteLine("Вы победили!");
                }
                else if (fieldMatrix[1, 1] == 2)
                {
                    Console.WriteLine("Победил компьютер!");
                }
            }

        }
        static void CheckVerticals()
        {
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                if (fieldMatrix[0, i] != 0 && fieldMatrix[0, i] == fieldMatrix[1, i] && fieldMatrix[1, i] == fieldMatrix[2, i])
                {
                    isWin = true;
                    if (fieldMatrix[0, i] == 1)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                    else if (fieldMatrix[0, i] == 2)
                    {
                        Console.WriteLine("Победил компьютер!");
                    }
                }
            }
        }
        static void CheckHorizontals()
        {
            for (int i = 0; i < FIELD_SIZE; i++)
            {
                if (fieldMatrix[i, 0] != 0 && fieldMatrix[i, 0] == fieldMatrix[i, 1] && fieldMatrix[i, 1] == fieldMatrix[i, 2])
                {
                    isWin = true;
                    if (fieldMatrix[i, 0] == 1)
                    {
                        Console.WriteLine("Вы победили!");
                    }
                    else if (fieldMatrix[i, 0] == 2)
                    {
                        Console.WriteLine("Победил компьютер!");
                    }
                }
            }
        }
        static void AIStep()
        {
            Console.WriteLine("Ход компьютера.");
            bool isCellEmpty;
            do
            {
                int x;
                int y;

                Random random = new Random();
                x = random.Next(FIELD_SIZE);
                y = random.Next(FIELD_SIZE);
                isCellEmpty = FillCell(x, y, 2);
            } while (!isCellEmpty);
        }
        static bool FillCell(int x, int y, int value)
        {
            bool isCellEmpty = fieldMatrix[y, x] == 0;
            if (isCellEmpty)
            {
                fieldMatrix[y, x] = value;
                stepsCountDown--;
            }
            return isCellEmpty;
        }
        static void PlayerStep()
        {
            Console.WriteLine("Ваш ход.");
            bool isCellEmpty;
            do
            {
                Console.WriteLine("Введите занчение координаты X: ");
                int x = Convert.ToInt32(Console.ReadLine()) - 1;
                Console.WriteLine("Введите занчение координаты Y: ");
                int y = Convert.ToInt32(Console.ReadLine()) - 1;
                isCellEmpty = FillCell(x, y, 1);
                if (!isCellEmpty)
                {
                    Console.WriteLine("Ячейка занята, выберите другую.");
                }
            } while (!isCellEmpty);
        }
        static void PrintField()
        {
            for (int i = 0; i < fieldMatrix.GetLength(0); i++)
            {

                for (int j = 0; j < fieldMatrix.GetLength(1); j++)
                {
                    Console.Write("|");
                    switch (fieldMatrix[i, j])
                    {
                        case 0:
                            PrintSymbolOnField(EMPTY, ConsoleColor.White);
                            break;
                        case 1:
                            PrintSymbolOnField(playerSymbol, ConsoleColor.Cyan);
                            break;
                        case 2:
                            PrintSymbolOnField(aISymbol, ConsoleColor.Magenta);
                            break;
                    }
                }
                Console.WriteLine("|");
            }
        }
        static void PrintSymbolOnField(char symbol, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(symbol);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        static void InitField()
        {
            fieldMatrix = new int[FIELD_SIZE, FIELD_SIZE];
            for (int i = 0; i < fieldMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < fieldMatrix.GetLength(1); j++)
                {
                    fieldMatrix[i, j] = 0;
                }
            }
        }

        static void ChooseCharacter()
        {
            Console.WriteLine("Вы за крестики или нолики?(нажмите \"0\", чтобы играть за нолики, нажмите любую кнопку, чтобы ирать за крестики)");
            string playerChoise = Console.ReadLine();
            playerSymbol = playerChoise == "0" ? O : X;
            aISymbol = playerSymbol == X ? O : X;
        }
    }
}

