namespace project_doomsday_warehouse
{
    internal class MedicalItem : InventoryItem
    {
        public MedicalItem()
        {
        }
        public MedicalItem(string name, double weight, DateOnly expiringDate, string medicalUse)
        {
            Name = name;
            Weight = weight;
            ExpiringDate = expiringDate;
            MedicalUse = medicalUse;
        }
        public DateOnly ExpiringDate { get; set; }
        public string MedicalUse { get; set; }
        public override void Parse(string line)
        {
            var values = line.Split(',');
            if (values.Length >= 3)
            {
                Name = values[0];
                Weight = double.Parse(values[1]);
                ExpiringDate = DateOnly.Parse(values[2]);
                MedicalUse = values[3];
            }
            else
            {
                throw new System.Exception("Invalid number of values in the line");
            }
        }
        public override string ConvertToCsvLine()
        {
            return $"{Name},{Weight},{ExpiringDate},{MedicalUse}";
        }

    }
}
