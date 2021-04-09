using System;
using System.Collections.Generic;
using System.Linq;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Inventory
{
    public abstract class Bag:IBag
    {
        private int capacity = 100;
        private List<Item> items;

        protected Bag(int capacity)
        {
            Capacity = capacity;
            items = new List<Item>();
        }

        public int Capacity { get; set; }
        public int Load => items.Sum(i => i.Weight);
        public IReadOnlyCollection<Item> Items => items.AsReadOnly();
        public void AddItem(Item item)
        {
            if (item.Weight+Load>Capacity)
            {
                throw new InvalidOperationException("Bag is full!");
            }

            items.Add(item);
        }

        public Item GetItem(string name)
        {
            if (items.Count==0)
            {
                throw new InvalidOperationException("Bag is empty!");
            }

            Item item = items.FirstOrDefault(i => i.GetType().Name == name);

            if (item==null)
            {
                throw new ArgumentException($"No item with name {item.GetType().Name} in bag!");
            }

            items.Remove(item);
            return item;
        }
    }
}