using BuilderPattern.Demo.Interfaces;
using System;
using System.Collections.Generic;
namespace BuilderPattern.Demo.Models
{
    public class Meal
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public float GetCost()
        {
            float cost = 0.0f;

            foreach (var item in items)
            {
                cost += item.Price();
            }
            return cost;
        }

        public void ShowItems()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item : " + item.Name());
                Console.WriteLine(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
