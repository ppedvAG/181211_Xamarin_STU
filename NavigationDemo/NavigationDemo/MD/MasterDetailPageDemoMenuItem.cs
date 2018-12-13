﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDemo.MD
{

    public class MasterDetailPageDemoMenuItem
    {
        public MasterDetailPageDemoMenuItem(Type pageType)
        {
            TargetType = pageType;
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}