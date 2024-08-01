namespace project_doomsday_warehouse
{
    public abstract class InventoryItem 
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public abstract void Parse(string line);
        public abstract string ConvertToCsvLine();
    }
}
