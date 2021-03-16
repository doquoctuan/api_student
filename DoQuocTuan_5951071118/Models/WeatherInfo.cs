using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestAPI.Models
{
    public class WeatherInfo
    {
        private string location;
        private float degree;
        private DateTime dateTime;

        public string Location { get => location; set => location = value; }
        public float Degree { get => degree; set => degree = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
    }
}