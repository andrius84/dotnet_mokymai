using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_doomsday_warehouse
{
    internal class Warehouse<T>
    {
        
        public void AddItem(T item)
        {
            Console.WriteLine($"Adding {item} to the warehouse");
            string filePath = "C:/dotnet_mokymai/c#_advanced/project_doomsday_warehouse/food.csv";
            File.WriteAllText(filePath, item.ToString());

        }
        public List<T> GetItems()
        {
            return new List<T>();
        }
        public void GetItem<T>(string name)
        {
            Console.WriteLine($"Getting {name} from the warehouse");
        }
    }

    internal abstract class InventoryItem 
    {
        public string Name { get; set; }
        public double Weight { get; set; }
    }
    internal class FoodItem : InventoryItem
    {
        public DateOnly ExpiringDate { get; set; }
        public int Calories { get; set; }
    }
    internal class WeaponItem : InventoryItem
    {
        public string WeaponDamage { get; set; }
    }
    internal class MedicalItem : InventoryItem
    {
        public DateOnly ExpiringDate { get; set; }
        public string MedicalUse { get; set; }
    }
}
