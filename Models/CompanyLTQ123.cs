using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeThuyQuynh123.Models
{
    [Table("Company")]
    public class Company
    {
        [Key]
        [Display(Name="ID")]
        public String CompanyId { get; set; }
        [Display(Name="Họ và tên")]
        public string CompanyName { get; set; }
    }
}
