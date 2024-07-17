using System.Collections.Generic;
using System.Reflection;
using System;

internal class Warehouse<T> where T : InventoryItem
{
    public void AddItem(T item)
    {
        var items = item.ConvertToCsvLine() + Environment.NewLine;
        var path = "../../../" + item.GetType().Name + ".csv";
        File.AppendAllText(path, items);
    }
    public List<T> GetItems()
    {
        var items = new List<T>();
        // Get the assembly where the subclasses are defined
        Assembly assembly = Assembly.GetExecutingAssembly();
        // Get all types in the assembly
        Type[] types = assembly.GetTypes();
        // Iterate through the types and check if they are subclasses of InventoryItem
        foreach (Type type in types)
        {
            if (type.IsSubclassOf(typeof(InventoryItem)))
            {
                var path = "../../../" + type.Name + ".csv";
                if (File.Exists(path))
                {
                    var lines = File.ReadAllLines(path);
                    foreach (var line in lines)
                    {
                        var item = (T)Activator.CreateInstance(type);
                        item.Parse(line);
                        items.Add(item);
                    }
                }
            }
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