﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NSIS.Web.Models
{
    public class BaseViewModel
    {
        public virtual int Id { get; set; }
        public virtual string NavigationTitle { get; set; }
        public bool IsEdit { get; set; }
    }
}