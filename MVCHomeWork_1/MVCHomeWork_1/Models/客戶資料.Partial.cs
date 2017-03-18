namespace MVCHomeWork_1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶資料MetaData))]
    public partial class 客戶資料
    {
    }
    
    public partial class 客戶資料MetaData
    {
        [Required]
        public int Id { get; set; }
        
        [StringLength(20, ErrorMessage = "欄位長度不得大於 20 個字元")]
        [Required(ErrorMessage = "請填入客戶名稱")]
        public string 客戶名稱 { get; set; }
        
        [MinLength(8, ErrorMessage="統一編號至少 8 碼")]
        [MaxLength(8, ErrorMessage = "統一編號至多 8 碼")]
        [RegularExpression(@"\d{8}", ErrorMessage = "統一編號格式錯誤")]
        [Required(ErrorMessage = "請填入統一編號")]
        public string 統一編號 { get; set; }
        
        [StringLength(10, ErrorMessage="電話號碼格式錯誤")]
        [Required(ErrorMessage = "請填入連絡電話")]
        [RegularExpression(@"[0-9]{2}\-[0-9]{7}", ErrorMessage = "電話號碼格式錯誤")]
        public string 電話 { get; set; }
        
        [StringLength(10, ErrorMessage="傳真號碼格式錯誤")]
        [RegularExpression(@"[0-9]{2}\-[0-9]{7}", ErrorMessage = "電話號碼格式錯誤")]
        [Required]
        public string 傳真 { get; set; }
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        [Required(ErrorMessage = "請填入地址")]
        public string 地址 { get; set; }
        
        [StringLength(25, ErrorMessage="欄位長度不得大於 25 個字元")]
        [Required(ErrorMessage = "請填入E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "電子郵件格式錯誤")]
        public string Email { get; set; }
    
        public virtual ICollection<客戶銀行資訊> 客戶銀行資訊 { get; set; }
        public virtual ICollection<客戶聯絡人> 客戶聯絡人 { get; set; }
    }
}
