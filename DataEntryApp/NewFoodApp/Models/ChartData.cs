using NewFoodApp.Models;

namespace NewFoodApp.Models
{
    public class ChartData
    {
        public string Label { get; set; }
        public int Value { get; set; }

        public static List<ChartData> GetData()
        { 
            List<ChartData> charData = new List<ChartData>();
               { 
                    charData.Add(new ChartData { Label = "Swami's Kitchen", Value = 55 });
                    charData.Add(new ChartData { Label = "Vithu Mauli", Value = 46 });
                    charData.Add(new ChartData { Label = "Gurukrupa", Value = 64 });
                    charData.Add(new ChartData { Label = "Aashapura", Value = 29 });
                    charData.Add(new ChartData { Label = "Dhanusha", Value = 35 });
               }
            return charData;    
        }
    }
}
