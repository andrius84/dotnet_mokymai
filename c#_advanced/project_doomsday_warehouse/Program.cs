using System.Xml.Linq;

namespace project_doomsday_warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse<FoodItem>();
            var foodItem = new FoodItem("Apple", 0.5, new DateOnly(2022, 12, 31), 100);
            var foodItem2 = new FoodItem("Banana", 0.3, new DateOnly(2022, 12, 31), 200);
            var foodItem3 = new FoodItem("Orange", 0.4, new DateOnly(2022, 12, 31), 150);
            warehouse.AddItem(foodItem);
            warehouse.AddItem(foodItem2);
            warehouse.AddItem(foodItem3);

            var warehouse2 = new Warehouse<WeaponItem>();
            var weaponItem = new WeaponItem("Sword", 2.0, "10");
            var weaponItem2 = new WeaponItem("Axe", 3.0, "15");
            var weaponItem3 = new WeaponItem("Bow", 1.0, "5");
            warehouse2.AddItem(weaponItem);
            warehouse2.AddItem(weaponItem2);
            warehouse2.AddItem(weaponItem3);

            var foodItems = warehouse.GetItems();
            var weaponItems = warehouse2.GetItems();


            var item = warehouse.GetItem("Banana");






        }
    }
}
