﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Interfases
{
   public interface IItem
    {
         int Id { get; set; }
         string Name { get; set; }
    }
}
