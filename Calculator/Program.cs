using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            bool ok = true;
            double age;
            double weight;
            double height;
            string gender;
            string activity;
            double phys = 0;
            double form;
            Console.WriteLine("Welcome to the Calories Calculator!"); // Добро пожаловать в калькулятор калорий!          
            do
            {
                Console.WriteLine("Enter gender (M-Man, W-Woman)"); // Введите пол (М-Мужской, Ж-Женский)
                gender = Console.ReadLine();
                if (gender != "M" && gender != "W")
                {
                    ok = false;
                    Console.WriteLine();
                    Console.WriteLine("Gender should be M or W");
                    Console.WriteLine();
                    continue;
                }
                else ok = true;
            }
            while (ok == false);
            do
            {
                Console.WriteLine();
                Console.WriteLine("Choose the type of physical activity that suits you: min(no physical activity), low(physical activity 1 - 3 times a week), medium(3 - 5 days a week), high(6 - 7 times a week), max(workout more than once a day)"); //Выберите тип физической нагрузки который подходит вам: минимальный (никаких физических нагрузок), низкий (физические нагрузки 1-3 раза в неделю), средний (3-5 дней в неделю), высокий (6-7 раз в неделю), максимальный (тренировки чаще, чем раз в день)
                activity = Console.ReadLine();
                if (activity != "min" && activity != "low" && activity != "medium" && activity != "high" && activity != "max")
                {
                    ok = false;
                    Console.WriteLine("Incorrect data entered. Enter 1 of the proposed options: min, low, medium, high, max."); //Введены неверные данные. Введите 1 из предложенных вариантов: минимальный, низкий, средний, высокий, максимальный.
                    Console.WriteLine();
                    Console.WriteLine();
                    continue;
                }
                else ok = true;

                if (activity == "min")
                    phys = 1.2;
                else if (activity == "low")
                    phys = 1.375;
                else if (activity == "medium")
                    phys = 1.55;
                else if (activity == "high")
                    phys = 1.725;
                else if (activity == "max")
                    phys = 1.9;
                Console.WriteLine();
                Console.WriteLine();
            }
            while (ok == false);
            age = Read("Enter age(full years)", 1, 100);
            weight = Read("Enter weight (kg)", 2, 350);
            height = Read("Enter height (cm)", 30, 250);
            form = BMR(gender, age, height, weight, phys);
            Console.WriteLine();

            Console.WriteLine("Daily norm kcal: " + form);
            Console.ReadKey();
        }
        public static double Read(string message, double min, double max)
        {
            double result = 0;
            bool ok = true;
            do
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(message); // сообщение которое будет выводиться
                    string strResult = Console.ReadLine();
                    result = Convert.ToDouble(strResult);
                }
                catch
                {
                    ok = false;
                    Console.WriteLine("The value is not a number.Please enter a numeric value."); // Значение не является числом. Пожалуйста, введите числовое значение
                    Console.WriteLine();
                    continue;
                }
                if (min > result || result > max)
                {
                    ok = false;
                    Console.WriteLine("Value must be between " + min + " and " + max); // Значение должно быть от min до max
                    Console.WriteLine();

                }
                else ok = true;
            }
            while (ok == false);
            return result;
        }
        public static double BMR(string gender, double age, double height, double weight, double phys)
        {
            double form = 0;
            if (gender == "M")
                form = Math.Round((88.36 + (13.4 * weight) + (4.8 * height) - (5.7 * age)) * phys, 2); // Формула для подсчета суточной нормы ккал для мужчин
            else
                form = Math.Round((447.6 + (9.2 * weight) + (3.1 * height) - (4.3 * age)) * phys, 2); // Формула для подсчета суточной нормы ккал для женщин 
            return form;
        }

    }
}