namespace MVCHomeWork_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶聯絡人MetaData))]
    public partial class 客戶聯絡人
    {
    }
    
    public partial class 客戶聯絡人MetaData
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int 客戶Id { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required(ErrorMessage = "職稱必填")]
        public string 職稱 { get; set; }
        
        [StringLength(8, ErrorMessage="欄位長度不得大於 8 個字元")]
        [Required(ErrorMessage = "姓名必填")]
        public string 姓名 { get; set; }
        
        [StringLength(25, ErrorMessage="欄位長度不得大於 25 個字元")]
        [Required(ErrorMessage = "E-mail必填")]
        public string Email { get; set; }
        
        [StringLength(15, ErrorMessage="欄位長度不得大於 15 個字元")]
        [Required(ErrorMessage = "手機必填")]
        [RegularExpression(@"\d{4}-\d{6}", ErrorMessage = "手機格式不符")]
        public string 手機 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage = "電話必填")]
        public string 電話 { get; set; }
    
        public virtual 客戶資料 客戶資料 { get; set; }
    }
}
