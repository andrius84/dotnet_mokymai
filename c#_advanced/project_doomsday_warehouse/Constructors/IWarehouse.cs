namespace project_doomsday_warehouse.Constructors
{
    public interface IWarehouse<T> where T : InventoryItem
    {
        void AddItem(T item);
        T? GetItem(string name);
        List<T?> GetItems();
        void RemoveItem(string name);
    }
}
