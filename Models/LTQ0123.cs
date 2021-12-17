using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeThuyQuynh123.Models
{
    [Table("LTQ")]
    public class LTQ
    {
        [Key]
        [Display(Name="ID")]
        public String LTQId { get; set; }
        [Display(Name="Họ và tên")]
        public string LTQName { get; set; }
        public string LTQGender { get; set; }
    }
}
