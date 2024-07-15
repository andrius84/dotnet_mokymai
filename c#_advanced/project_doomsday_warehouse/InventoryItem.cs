namespace project_doomsday_warehouse
{
    internal abstract class InventoryItem 
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Path { get; set; }
        public abstract void Parse(string line);
        public abstract string ConvertToCsvLine();
    }
}
