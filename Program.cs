using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            double temp_max = 56.7;
            double temp_min = -273;
            double humidity = 6.8;
            double windPower = 7;

            ArrayList List = new ArrayList();

            double[] temp = {temp_max, temp_min };

            DateTime[] dates = { DateTime.Now };

            List<Cloudy> cloudy = new List<Cloudy>();
            List<Precipitation> precipitation = new List<Precipitation>();
            List<Direction> directions = new List<Direction>();

            List.Add(dates);
            List.AddRange(temp);
            List.AddRange(cloudy);
            List.AddRange(precipitation);
            List.AddRange(directions);
            List.Add(humidity);
            List.Add(windPower);

            Dictionary<string, double> Temp = new Dictionary<string, double>();
            Temp.Add("Temp min ", -273);
            Temp.Add("Temp max ", 56.7);
            Temp.Add("Humidity ",  6.8);
            Temp.Add("Wind Power ", 7);


            foreach (var item in Temp)
            {
                Console.WriteLine(item.Key + item.Value);
            }


           // foreach ( var item in List)
           // {
           //     Console.WriteLine(item);
           // }

           

            Weather weather = new Weather();

            Console.WriteLine(weather.ToString());
        }

        
    }
}
