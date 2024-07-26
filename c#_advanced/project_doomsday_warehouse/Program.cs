using project_doomsday_warehouse.Constructors;
using System.Xml.Linq;

namespace project_doomsday_warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyLogger logger = new FileMyLogger();

            IWarehouse<FoodItem> maistasWarehouse = new Warehouse<FoodItem>("../../../maistas.csv", logger);
            IWarehouse<WeaponItem> ginklaiWarehouse = new Warehouse<WeaponItem>("../../../ginklai.csv", logger);
            IWarehouse<MedicalItem> vaistaiWarehouse = new Warehouse<MedicalItem>("../../../vaistai.csv", logger);

            var foodItem = new FoodItem("Apple", 0.5, new DateOnly(2022, 12, 31), 100);
            var foodItem2 = new FoodItem("Banana", 0.3, new DateOnly(2022, 12, 31), 200);
            var foodItem3 = new FoodItem("Orange", 0.4, new DateOnly(2022, 12, 31), 150);

            var weaponItem = new WeaponItem("Sword", 2.0, "10");
            var weaponItem2 = new WeaponItem("Axe", 3.0, "15");
            var weaponItem3 = new WeaponItem("Bow", 1.0, "5");

            var medicalItem = new MedicalItem("Painkiller", 0.1, new DateOnly(2022, 12, 31), "Pain relief");
            var medicalItem2 = new MedicalItem("Bandage", 0.2, new DateOnly(2022, 12, 31), "Wound care");
            var medicalItem3 = new MedicalItem("Antibiotics", 0.3, new DateOnly(2022, 12, 31), "Infection treatment");

            maistasWarehouse.AddItem(foodItem);
            maistasWarehouse.AddItem(foodItem2);
            maistasWarehouse.AddItem(foodItem3);

            ginklaiWarehouse.AddItem(weaponItem);
            ginklaiWarehouse.AddItem(weaponItem2);
            ginklaiWarehouse.AddItem(weaponItem3);

            vaistaiWarehouse.AddItem(medicalItem);
            vaistaiWarehouse.AddItem(medicalItem2);
            vaistaiWarehouse.AddItem(medicalItem3);




        }
    }
}
