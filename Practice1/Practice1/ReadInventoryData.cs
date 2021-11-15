using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Practice1
{
    public class ReadInventoryData
    {

        public InventoryManagementModel Read(string Path)
        {
            using(StreamReader file=new StreamReader(Path))
            {
                try
                {
                    string json = file.ReadToEnd();

                    return JsonConvert.DeserializeObject<InventoryManagementModel>(json);
                }catch(Exception e)
                {
                    Console.WriteLine("Problem in getting Data {0}",e);
                    return null;
                }
            }
        }
    }
}
