﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApplication.Interface
{
    public interface IPagination
    {
        public List<Weather.Common.Weather> GetCurrentPage(); // isto kao Execute

    }
}