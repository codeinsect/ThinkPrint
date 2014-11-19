using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webdiyer.WebControls.Mvc;

namespace NSIS.Web.Models
{
    public class BaseListViewModel<T> where T : class
    {
        public virtual string PageTitle { get; set; }
        public virtual string PageIcon { get; set; }

        public virtual string NavigationTitle { get; set; }

        public virtual PagedList<T> ViewList { get; set; }
        public virtual string searchKey { get; set; }


    }
}