using System;
using System.Collections.Generic;

namespace TP.EntityFramework.Models
{
    public partial class SYS_Unit
    {
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string UnitType { get; set; }
        public System.DateTime ModifiedDate { get; set; }
        public string Description { get; set; }
        public bool IsDelete { get; set; }
    }
}
