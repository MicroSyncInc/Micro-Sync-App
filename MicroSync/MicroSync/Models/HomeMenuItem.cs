﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MicroSync.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        Build
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
