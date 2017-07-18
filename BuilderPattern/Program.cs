using BuilderPattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("***** Veg meal *****");
            vegMeal.ShowItems();
            Console.WriteLine(String.Format("Total price = {0}", vegMeal.GetCost()));
            Console.ReadLine();

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("***** Non veg meal *****");
            nonVegMeal.ShowItems();
            Console.WriteLine(String.Format("Total price = {0}", nonVegMeal.GetCost()));
            Console.ReadLine();
        }
    }
}
