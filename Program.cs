namespace GrainInventoryJson
{
    class Program
    {
        public static string filepath = "C:\\Users\\hp\\Desktop\\NewBatch\\GrainInventoryJson\\GrainInventoryJson\\GrainDataFile.json";
        public static void Main(string[] args)
        {
            ManageGrainFile manageGrainFile = new ManageGrainFile();
            manageGrainFile.ReadFile(filepath);
        }
    }
}