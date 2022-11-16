using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManagement
{
    public class ManageOfStockList
    {
        public void ReadJsonFile(string filepath)
        {
            var json = File.ReadAllText(filepath);

            List<StockList> stocklist = JsonConvert.DeserializeObject<List<StockList>>(json);

            foreach(var data in stocklist)
            {
                Console.WriteLine(data.Name+"\n"+data.NumberOfShare+"\n"+data.PriceOfPerShare+"\n total ammount :"+data.NumberOfShare*data.PriceOfPerShare);
            }
        }
    }
}
