using project_doomsday_warehouse.Constructors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_doomsday_warehouse
{
    public class Warehouse<T> : IWarehouse<T> where T : InventoryItem, new()
    {
        private readonly List<IMyLogger> _loggers;
        private readonly string _filePath;
        public Warehouse(string filePath, IMyLogger logger)
        {
            _filePath = filePath;
            _loggers = new List<IMyLogger> { logger };
        }
        public void AddItem(T item)
        {
            try
            { 
            var items = item.ConvertToCsvLine() + Environment.NewLine;
            File.AppendAllText(_filePath, items);
            Log($"Item {item.Name} added successfully");
            }
            catch (Exception ex)
            {
                Log("Error occurred while adding item: " + ex.Message);
            }
        }
        public List<T> GetItems()
        {
            try
            {
                var items = new List<T>();
                var lines = File.ReadAllLines(_filePath);
                foreach (var line in lines)
                {
                    var item = Activator.CreateInstance<T>();
                    item.Parse(line);
                    items.Add(item);
                }
                Log("Items retrieved successfully");
                return items;
            }
            catch (Exception ex)
            {
                Log($"Error occurred while getting items: {ex.Message}");
                return new List<T>();
            }
        }
        public T GetItem(string name)
        {
            try
            {
                var items = GetItems();
                foreach (var item in items)
                {
                    if (item.Name == name)
                    {
                        return item;
                    }
                }
                Log($"Item {name} not found");
                return default(T);
            }
            catch (Exception ex)
            {
                Log($"Error occurred while getting item: {ex.Message}");
                return default(T);
            }
        }
        public void RemoveItem(string name)
        {
            var items = GetItems();
            if (items != null)
            {
                items.RemoveAll(x => x!.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                try
                {
                    File.WriteAllText(_filePath, string.Empty);
                    Log($"Item {name} removed successfully");
                }
                catch (FileNotFoundException)
                {
                    Log("File not found");
                }
                if (items.Count > 0)
                {
                    foreach (var item in items)
                    {
                        AddItem(item!);
                    }
                } 
            }
        }
        private void Log(string message) => _loggers.ForEach(logger => logger.Log(message));
    }
}
