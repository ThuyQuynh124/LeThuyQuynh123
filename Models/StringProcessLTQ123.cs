using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace LeThuyQuynh123.Models
{
    public class StringProcessLTQ123
    {
        public string LowerToUpper (string strInput)
        {
            return strInput.ToUpper();
        }
      
    }
}