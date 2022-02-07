using System;

namespace Lesson6
{
    class Program
    {
/*        1. Создать классы Собака и Кот с наследованием от класса Животное.
2. Животные могут выполнять действия: бежать, плыть, перепрыгивать препятствие. 
В качестве параметра каждому методу передается величина, 
означающая или длину препятствия (для бега и плавания), или высоту(для прыжков).
3. У каждого животного есть ограничения на действия(бег: кот 200 м., собака 500 м.; прыжок: кот 2 м., собака 0.5 м.; плавание: кот не умеет плавать, собака 10 м.).
4. При попытке животного выполнить одно из этих действий, оно должно сообщить результат в консоль. (Например, dog1.run(150); -> результат: run: true)
5. * Добавить подсчет созданных котов, собак и животных.*/

        static void Main(string[] args)
        {
            Cat barsik = new Cat();
            Console.WriteLine($"Animal count:{Animal.Count}, Cat count{Cat.Count}, Dog Count: {Dog.Count}");
            Cat murka = new Cat();
            Console.WriteLine($"Animal count:{Animal.Count}, Cat count{Cat.Count}, Dog Count: {Dog.Count}");
            Dog polkan = new Dog();
            Console.WriteLine($"Animal count:{Animal.Count}, Cat count{Cat.Count}, Dog Count: {Dog.Count}");
            polkan.Run(400);
            barsik.Swim(200);
        }
    }
}
