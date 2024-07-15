using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_doomsday_warehouse
{
    internal class Warehouse<T> where T : InventoryItem
    {
        public void AddItem(T item)
        {
            Console.WriteLine($"Adding {item.Name} to the warehouse");
            var items = item.ConvertToCsvLine() + Environment.NewLine;
            var path = typeof(T).Name + ".csv";
            File.AppendAllText(path, items);
        }

        public List<T> GetItems()
        {
            Console.WriteLine("Getting items from the warehouse");
            var path = typeof(T).Name + ".csv";
            var lines = File.ReadAllLines(path);
            var items = new List<T>();
            foreach (var line in lines)
            {
                var item = Activator.CreateInstance<T>();
                item.Parse(line);
                items.Add(item);
            }
            return items;
        }

        public T GetItem(string name)
        {
            Console.WriteLine($"Getting items from the warehouse with name {name}");
            var items = GetItems();
            foreach (var item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
