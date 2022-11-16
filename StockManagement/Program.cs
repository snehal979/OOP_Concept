namespace StockManagement
{
    class Program
    {
        static string filepath = "C:\\Users\\hp\\Desktop\\Batch-217\\InventoryDataGrain\\StockManagement\\StockManagement\\StockList.json";
        public static void Main(string[] args)
        {
            // stock management problem 

            ManageOfStockList manageOfStockList = new ManageOfStockList();
            manageOfStockList.ReadJsonFile(filepath);

        }
    }
}