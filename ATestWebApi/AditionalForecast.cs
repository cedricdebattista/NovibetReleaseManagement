﻿using System;

namespace ATestWebApi
{
    public class AditionalForecast:WeatherForecast
    {
        public string New { get; set; } = "NEW";
        public string New2 { get; set; } = "NEW2";
        public string Hello { get; set; } = "Hello";
        public DateTime ExpiryDate { get; set; }
    }
}
