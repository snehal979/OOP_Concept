using Newtonsoft.Json;

namespace DataInventory2
{
    public class MultiManagrData
    {
        List<Grain> RiceList { get; set; } 
        List<Grain> WheatList { get; set; }
        List<Grain> PulsesList { get; set; }
        
         MultiManagrData inventories;
        public void ReadFile(string path)
        {
            var json = File.ReadAllText(path);

            List<MultiManagrData> Files = JsonConvert.DeserializeObject<List<MultiManagrData>>(json);

            inventories.RiceList = RiceList;
            Print(RiceList);
            inventories.WheatList = WheatList;
            Print(PulsesList);
            inventories.PulsesList = PulsesList;
            Print(PulsesList);



        }
        public void Print(List<Grain> inventories)
        {
            foreach (var data in inventories)
            {
                Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
            }
        }
        public void ToDisplay(int choice)
        {
            switch (choice)
            {
                case 1:
                    Print(RiceList);
                    break;
                case 2:
                    Print(WheatList);
                    break;
                case 3:
                    Print(PulsesList);
                    break;
                case 4:
                    Print(RiceList);
                    Print(WheatList);
                    Print(PulsesList);
                    break;
            }

        }

        public void AddInventory()
        {
            Grain multi = new Grain();
            Console.WriteLine("hint 1.rice 2:wheat 3:pulses");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    foreach (var data in inventories.RiceList)
                    {
                        data.Name = Console.ReadLine();
                        data.Weight =Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        inventories.RiceList.Add(data);
                    }
                    break;
                case 2:
                    foreach (var data in inventories.WheatList)
                    {
                        data.Name = Console.ReadLine();
                        data.Weight =Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        inventories.WheatList.Add(data);
                    }
                    break;
                case 3:
                    foreach (var data in inventories.PulsesList)
                    {
                        data.Name = Console.ReadLine();
                        data.Weight =Convert.ToInt32(Console.ReadLine());
                        data.PricePerKg =Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        inventories.PulsesList.Add(data);
                    }
                    break;

            }

        }
        public void EditInventory()
        {
            string EditName = "A";
            Console.WriteLine("hint 1.rice 2:wheat 3:pulses");

            int choice1 = Convert.ToInt32(Console.ReadLine());
            switch (choice1)
            {
                case 1:
                    foreach (var data in inventories.RiceList)
                    {
                        if (data.Name == EditName)
                        {
                            data.Name = Console.ReadLine();
                            data.Weight=Convert.ToInt32(Console.ReadLine());
                            data.PricePerKg =Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        }
                    }
                    break;
                case 2:
                    foreach (var data in inventories.WheatList)
                    {
                        if (data.Name == EditName)
                        {
                            data.Name = Console.ReadLine();
                            data.Weight=Convert.ToInt32(Console.ReadLine());
                            data.PricePerKg =Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        }
                    }
                    break;
                case 3:
                    foreach (var data in inventories.PulsesList)
                    {
                        if (data.Name == EditName)
                        {
                            data.Name = Console.ReadLine();
                            data.Weight=Convert.ToInt32(Console.ReadLine());
                            data.PricePerKg =Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg);
                        }
                    }
                    break;
            }
              
        }
        public void DelectInventory()
        {
            Console.WriteLine("enter the number which list is delect");
            Console.WriteLine("hint 1.rice 2:wheat 3:pulses");
            int c = Convert.ToInt32(Console.ReadLine());
            if(c == 1)
            inventories.RiceList.Clear();
            else if(c == 2)
            inventories.WheatList.Clear();
            else
            inventories.PulsesList.Clear();
        }
        public void JsonFileSerialization()
        {
            Grain factor = new Grain();
            string data = JsonConvert.SerializeObject(factor);
            Console.WriteLine(data);
        }
       
    }
    public class Grain
    {
        public string Name { get; set; } = "rice1";
        public int Weight { get; set; } = 3;
        public double PricePerKg { get; set; } = 35.7;
    }
}
   
