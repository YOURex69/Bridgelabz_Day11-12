using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            string Path = "C:/Users/USER/Desktop/Inventory.json";
            Console.WriteLine("Welcome to InventoryManageMent");
            ReadInventoryData readInventoryData = new ReadInventoryData();
            InventoryManagementModel data = readInventoryData.Read(Path);
            Console.WriteLine("Rice Details");
            for (int i=0;i<data.Rice.Count;i++)
            {
                
                
                Console.Write(" Name: "+data.Rice[i].name+"  "+ " Weight (kg): "+data.Rice[i].weight+"  " +" Price: "+ data.Rice[i].price );
                int cost = data.Rice[i].price * data.Rice[i].weight;
                Console.WriteLine("       Net-Cost (Rs):" + cost);

            }
            Console.WriteLine("Pulses Details");
            for (int i = 0; i < data.Pulses.Count; i++)
            {
                
              
                Console.Write(" Name: " + data.Pulses[i].name+"  "+ " weight (kg): " + data.Pulses[i].weight+" "+" Price :" + data.Pulses[i].price);
                int cost = data.Pulses[i].price * data.Pulses[i].weight;
                Console.WriteLine("       Net-Cost (Rs):" + cost);
            }
            Console.WriteLine("Wheat Details");
            for (int i = 0; i < data.Wheat.Count; i++)
            {
               
                
                Console.Write(" Name: " + data.Wheat[i].name+" "+ " Weight (kg): " + data.Wheat[i].weight+" "+ " Price: " + data.Wheat[i].price);
                int cost = data.Wheat[i].price * data.Wheat[i].weight;
                Console.WriteLine("       Net-Cost (Rs):"+cost);
            }
        }
    }
}
