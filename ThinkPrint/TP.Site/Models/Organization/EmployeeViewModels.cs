using NSIS.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TP.EntityFramework.Models;

namespace TP.Site.Models.Organization
{
    public class EmployeeListModel : BaseListViewModel<ORG_Employee>
    {
        public EmployeeListModel()
        {
            StatusList = new List<SYS_SysSetting>();
        }
        public IList<SYS_SysSetting> StatusList { get; set; }
    }
}