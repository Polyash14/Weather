using System;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int cloudy = 8;
            
            decimal precipitation = 2.4m;
             
            decimal windDirection = 78.6m;

            Weather weather = new Weather();

            Console.WriteLine(weather.ToString());
        }

        
    }
}
