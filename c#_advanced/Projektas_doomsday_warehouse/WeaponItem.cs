namespace project_doomsday_warehouse
{
    internal class WeaponItem : InventoryItem
    {
        public WeaponItem()
        {
        }
        public WeaponItem(string name, double weight, string weaponDamage)
        {
            Name = name;
            Weight = weight;
            WeaponDamage = weaponDamage;
        }
        public string WeaponDamage { get; set; }

        public override void Parse(string line)
        {
            var values = line.Split(',');
            if (values.Length >= 3)
            {
                Name = values[0];
                Weight = double.Parse(values[1]);
                WeaponDamage = values[2];
            }
            else
            {
                throw new System.Exception("Invalid number of values in the line");
            }
        }
        public override string ConvertToCsvLine()
        {
            return $"{Name},{Weight},{WeaponDamage}";
        }
    }
}
