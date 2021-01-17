using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSalad
{
    class Program
    {
        static void Main(string[] args)
        {
            Apple redApple = new Apple("red", true)
            {
                _name = "Pink Lady",
                _calories = 95
            };

            Apple greenApple = new Apple("green", false)
            {
                _name = "Granny Smith",
                _calories = 70
            };

            Apple yellowApple = new Apple("yellow", false)
            {
                _name = "Golden Delicioius",
                _calories = 105
            };

            Banana cavendish = new Banana(false, false, 200)
            {
                _name = "Cavendish Banana",
                _calories = 180,
            };

            Banana manzano = new Banana(false, true, 150)
            {
                _name = "Manzano Banana",
                _calories = 100,
            };

            Banana ladyFinger = new Banana(true, false, 180)
            {
                _name = "Lady Finger Banana",
                _calories = 150,
            };

            Pear syrian = new Pear()
            {
                _name = "Syrian Pear",
                _calories = 150,
            };

            Lemon eureka = new Lemon()
            {
                _name = "Eureka Lemon",
                _calories = 80,
            };


            Apple[] apples = new Apple[] { redApple, greenApple, yellowApple };
            PrintAppleColor(apples);

            Console.WriteLine();

            Banana[] bananas = new Banana[] { cavendish, manzano, ladyFinger };
            PrintBananaSize(bananas);

            FruitSalad myLunch = new FruitSalad()
            {
                _fruits = new FruitBase[] { redApple, ladyFinger, syrian }
            };
            ContainsMyFavoriteFruit(myLunch);
            GetTotalCalories(myLunch);
        }


        public static void ContainsMyFavoriteFruit(FruitSalad fruits)
        {
            if (fruits.ContainsMyFavoriteFruit()) 
            {
                Console.WriteLine("Contains my favorite");
            }
            else
            {
                Console.WriteLine("Not contains my favorite");
            }
        }

        public static void GetTotalCalories(FruitSalad fruits)
        {
            Console.WriteLine($"\n Total calories of my fruit salad is {fruits.GetTotalCalories()} cal");
        }

        private static void PrintAppleColor(Apple[] apples)
        {
            for (int i = 0; i < apples.Length; i++)
            {
                Console.WriteLine($" Apple {apples[i]._name} is {apples[i]._color}");
            }
        }

        private static void PrintBananaSize(Banana[] bananas)
        {
            for (int i = 0; i < bananas.Length; i++)
            {
                Console.WriteLine($" The {bananas[i]._name} weighs {bananas[i]._size} grams");
            }
        }


    }
}
