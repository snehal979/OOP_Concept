using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GrainInventoryJson
{
    public class ManageGrainFile
    {
        public void ReadFile(string filepath)
        {
            var json =File.ReadAllText(filepath);

            List<GrainDataFile> grainDataFiles = JsonConvert.DeserializeObject<List<GrainDataFile>>(json); 
            foreach( var data in grainDataFiles)
            {
                Console.WriteLine(data.Name+"\n"+data.Weight+"\n"+data.PricePerKg+"\n"+ "total ammount"+data.PricePerKg*data.Weight);
            }
        }
    }
}
