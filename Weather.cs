using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather
{
    public enum Cloudy : byte
    {
        undefined,
        clear,
        little_cloudy,
        cloudy,
        storm_clouds
    }

    public enum Precipitation : byte
    {
        undefined,
        rain,
        snow,
        sleet,
        hail,
        snow_pellets,
        dew,
        hoarfrost,
        rime,
        ice,
        ice_needles
    }

    public enum Direction : byte
    {
        undefined,
        north,
        northeast,
        east,
        southwest,
        west,
        northwest
    }

    public class Weather
    {
        private DateTime _date = DateTime.Now;

        private double _tempMin = -273;

        private double _tempMax = 56.7;

        private Cloudy _cloudy = Cloudy.storm_clouds;

        private Precipitation _precipitation = Precipitation.sleet;

        private double _humidity = 6.8;

        private double _windPower = 7;

        private Direction _windDirection = Direction.southwest;

        public DateTime Date { get => _date; set => _date = value; }
        public double TempMin { get => _tempMin; set => _tempMin = value; }
        public double TempMax { get => _tempMax; set => _tempMax = value; }
        public Cloudy Cloudy { get => _cloudy; set => _cloudy = value; }
        public Precipitation Precipitation { get => _precipitation; set => _precipitation = value; }
        public double Humidity { get => _humidity; set => _humidity = value; }
        public double WindPower { get => _windPower; set => _windPower = value; }
        public Direction WindDirection { get => _windDirection; set => _windDirection = value; }

        public override string ToString()
        {
            return $"Date - {DateTime.Now}, Cloudy - {Cloudy}, Precipitation - {Precipitation}, Wind direction - {WindDirection} ";
        }

       
        
       
       

    }
}
