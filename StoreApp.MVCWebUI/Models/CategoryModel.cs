﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StoreApp.MVCWebUI.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }
    }
}