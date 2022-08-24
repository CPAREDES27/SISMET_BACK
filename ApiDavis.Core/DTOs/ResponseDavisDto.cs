﻿using ApiDavis.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDavis.Core.DTOs
{
    public class ResponseDavisDto
    {
        public List<DataDavisEntiti> Estacion { get; set; }
        public List<DataDavisEntiti> SecondEstacion { get; set; }
        public string message { get; set; }
    }
}
