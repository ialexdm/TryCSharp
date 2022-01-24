using System;
using System.Text;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {


            //            1.Написать программу, которая загадывает случайное число от 0 до 9,
            //            и пользователю дается 3 попытки угадать это число.
            //            При каждой попытке компьютер должен сообщить больше ли указанное пользователем число чем загаданное, или меньше.
            //            После победы или проигрыша выводится запрос – «Повторить игру еще раз? 1 – да / 0 – нет»(1 – повторить, 0 – нет).


            GuessNumber(minValue: 0, maxValue: 9, maxTries: 3);

            //2 * Создать массив из слов String[] words = { "apple", "orange", "lemon", "banana",
            //"apricot", "avocado", "broccoli", "carrot", "cherry", "garlic", "grape", "melon",
            //"leak", "kiwi", "mango", "mushroom", "nut", "olive", "pea", "peanut", "pear", "pepper",
            //"pineapple", "pumpkin", "potato"};
            //            При запуске программы компьютер загадывает слово, запрашивает ответ у пользователя,
            //сравнивает его с загаданным словом и сообщает правильно ли ответил пользователь.Если слово не угадано, компьютер показывает буквы которые стоят на своих местах.
            //apple – загаданное
            //apricot - ответ игрока
            //ap############# (15 символов, чтобы пользователь не мог узнать длину слова)
            //Для сравнения двух слов посимвольно, можно пользоваться:
            //String str = "apple";
            //            str.charAt(0); -метод, вернет char, который стоит в слове str на первой позиции
            //           Играем до тех пор, пока игрок не отгадает слово
            //           Используем только маленькие буквы
            GuessString();
        }
        static void GuessString()
        {

            bool tryAgain;
            do
            {
                StringBuilder field = new StringBuilder(new string('#', 15));
                string answer = SelectAnswer();
                Console.Write("Слово загадано.");
                bool isWin = false;

                while (!isWin)
                {
                    Console.Write("Введите ваш вариант ответа:");
                    string userAnswer = Console.ReadLine().ToLower();
                    if (isWin = userAnswer == answer)
                    {
                        Console.WriteLine($"Вы угадали! Загаданное слово {answer}!");
                    }
                    else
                    {
                        Console.WriteLine("Вы не угадали. Ниже поле с угаданными буквами:");
                        field = FillField(answer, userAnswer, field);
                        Console.WriteLine(field);
                    }
                }
            } while (tryAgain = TryAgain());
        }
        static StringBuilder FillField(string answer, string userAnswer, StringBuilder field)
        {
            for (int i = 0; i < answer.Length && i < userAnswer.Length; i++)
            {
                if (answer[i] == userAnswer[i])
                {
                    field[i] = answer[i];
                }
            }
            return field;
        }
            static string SelectAnswer()
        {
            string[] words = { "apple", "orange", "lemon", "banana",
            "apricot", "avocado", "broccoli", "carrot", "cherry",
            "garlic", "grape", "melon", "leak", "kiwi", "mango",
            "mushroom", "nut", "olive", "pea","peanut", "pear",
            "pepper", "pineapple", "pumpkin", "potato" };
            Random random = new Random();
            int answerIndex = random.Next(words.Length);
            string answer = words[answerIndex];
            return answer;
        }
        static void GuessNumber(int minValue, int maxValue, int maxTries)
        {
            
            bool tryAgain;
            do
            {
                int tries = maxTries;
                int number = GetNumber(minValue, maxValue);
                bool isWin = false;
                while (!isWin && tries > 0)
                {
                    Console.WriteLine($"Загадано число от {minValue} до {maxValue}.");
                    Console.WriteLine($"Попыток осталось: {tries}.");
                    Console.Write("Введите число:");
                    int userAnswer = InputUserNumber();
                    tries--;
                    isWin = CheckWin(userAnswer, number, tries);
                }
            } while (tryAgain = TryAgain());
        }

        static bool TryAgain()
        {
            const int YES = 1;
            Console.WriteLine($"Повторить игру еще раз? {YES} – да / другое число – нет");
            string tryAgainUserInput = Console.ReadLine();
            int tryAgainAnswer = Convert.ToInt32(tryAgainUserInput);
            bool tryAgain = tryAgainAnswer == YES;
            return tryAgain;
        }

        static int GetNumber(int minValue, int maxValue)
        {
            Random random = new Random();
            int number = random.Next(minValue, maxValue);
            return number;
        }
        static int InputUserNumber()
        {
            string userAnswerInput = Console.ReadLine();
            int userNumber = Convert.ToInt32(userAnswerInput);
            return userNumber;
        }
        static bool CheckWin(int userAnswer, int number, int tries)
        {
            bool isWin;
            if (isWin = userAnswer == number)
            {
                Console.WriteLine($"Поздравляем, вы угадали! загаданное число {number}!");
            }
            else
            {
                if (tries > 0)
                {
                    Console.WriteLine("Ответ не верный.");
                    bool isNumberBigger = number > userAnswer;
                    if (isNumberBigger)
                    {
                        Console.WriteLine("Загаданное число больше.");
                    }
                    else
                    {
                        Console.WriteLine("Загаданное число меньше.");
                    }
                }
                else
                {
                    Console.WriteLine($"Вы не угадали. Было загадано число {number}");
                }
            }
            return isWin;
        }
    }
}
