namespace MVCHomeWork_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶銀行資訊MetaData))]
    public partial class 客戶銀行資訊
    {
    }
    
    public partial class 客戶銀行資訊MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required(ErrorMessage = "銀行名稱必填")]
        public string 銀行名稱 { get; set;
        }
        [Required(ErrorMessage = "銀行代碼必填")]
        public int 銀行代碼 { get; set; }

        public int? 分行代碼 { get; set; }

        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required(ErrorMessage = "帳戶名稱必填")]
        public string 帳戶名稱 { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required(ErrorMessage = "帳戶號碼必填")]
        public string 帳戶號碼 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
