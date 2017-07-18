using BuilderPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Classes
{
    public class Meal
    {
        private List<IItem> items = new List<IItem>();

        public void AddItem(IItem item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;
            foreach (IItem item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (IItem item in items)
            {
                Console.WriteLine(String.Format("Item : {0}", item.Name()));
                Console.WriteLine(String.Format("Packing : {0}", item.Packing().Pack()));
                Console.WriteLine(String.Format("Price : {0}", item.Price()));
                Console.WriteLine("\n");
            }
        }
    }
}
