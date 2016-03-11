namespace ASPMVC_homework_01.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶總覽MetaData))]
    public partial class 客戶總覽
    {
    }
    
    public partial class 客戶總覽MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required]
        public string 客戶名稱 { get; set; }
        [Required]
        public int 聯絡人數量 { get; set; }
        [Required]
        public int 銀行數量 { get; set; }
    }
}
