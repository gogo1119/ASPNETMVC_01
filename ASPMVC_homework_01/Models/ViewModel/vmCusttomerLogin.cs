using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASPMVC_homework_01.Models.ViewModel
{
    public class vmCusttomerLogin
    {
        [Required]
        public string 帳號 { get; set; }
        [Required]
        public string 密碼 { get; set; }
    }
}