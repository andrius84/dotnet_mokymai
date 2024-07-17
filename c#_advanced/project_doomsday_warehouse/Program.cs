using System.Xml.Linq;

namespace project_doomsday_warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse<FoodItem>();
            var warehouse2 = new Warehouse<WeaponItem>();
            var warehouse3 = new Warehouse<MedicalItem>();

            var foodItem = new FoodItem("Apple", 0.5, new DateOnly(2022, 12, 31), 100);
            var foodItem2 = new FoodItem("Banana", 0.3, new DateOnly(2022, 12, 31), 200);
            var foodItem3 = new FoodItem("Orange", 0.4, new DateOnly(2022, 12, 31), 150);

            var weaponItem = new WeaponItem("Sword", 2.0, "10");
            var weaponItem2 = new WeaponItem("Axe", 3.0, "15");
            var weaponItem3 = new WeaponItem("Bow", 1.0, "5");

            var medicalItem = new MedicalItem("Painkiller", 0.1, new DateOnly(2022, 12, 31), "Pain relief");
            var medicalItem2 = new MedicalItem("Bandage", 0.2, new DateOnly(2022, 12, 31), "Wound care");
            var medicalItem3 = new MedicalItem("Antibiotics", 0.3, new DateOnly(2022, 12, 31), "Infection treatment");

            warehouse.AddItem(foodItem);
            warehouse.AddItem(foodItem2);
            warehouse.AddItem(foodItem3);

            warehouse2.AddItem(weaponItem);
            warehouse2.AddItem(weaponItem2);
            warehouse2.AddItem(weaponItem3);

            warehouse3.AddItem(medicalItem);
            warehouse3.AddItem(medicalItem2);
            warehouse3.AddItem(medicalItem3);

            var Items = warehouse.GetItems();
            var Items2 = warehouse2.GetItems();
            var Items3 = warehouse3.GetItems();

            var item = warehouse.GetItem("Apple");
            var item2 = warehouse2.GetItem("Sword");
            var item3 = warehouse3.GetItem("Painkiller");


        }
    }
}
