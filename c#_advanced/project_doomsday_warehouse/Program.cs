namespace project_doomsday_warehouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var warehouse = new Warehouse<FoodItem>();
            var foodItem = new FoodItem
            {
                Name = "Bread",
                Weight = 0.5,
                ExpiringDate = new DateOnly(2025, 12, 31),
                Calories = 200
            };
            warehouse.AddItem(foodItem);

        }
    }
}
