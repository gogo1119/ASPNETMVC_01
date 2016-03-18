using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVC_homework_01.Models.ViewModel
{
    public class vmCustomerIndex
    {
        public IEnumerable<客戶資料> 客戶資料List { get; set; }

        public 客戶資料 Query { get; set; }
    }
}