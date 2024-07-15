using System.Diagnostics;

namespace project_doomsday_warehouse
{
    internal class FoodItem : InventoryItem
    {
        public FoodItem()
        {
        }
        public FoodItem(string name, double weight, DateOnly expiringDate, int calories)
        {
            Name = name;
            Weight = weight;
            ExpiringDate = expiringDate;
            Calories = calories;
        }
        public DateOnly ExpiringDate { get; set; }
        public int Calories { get; set; }
        public override void Parse(string line)
        {
            var values = line.Split(',');
            if (values.Length >= 3)
            {
                Name = values[0];
                Weight = double.Parse(values[1]);
                ExpiringDate = DateOnly.Parse(values[2]);
                Calories = int.Parse(values[3]);
            }
            else
            {
                throw new System.Exception("Invalid number of values in the line");
            }
        }
        public override string ConvertToCsvLine()
        {
            return $"{Name},{Weight},{ExpiringDate},{Calories}";
        }

    }
}
