using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDbyAjaxinASP.NETCoreMVC.Models
{
    public class employeemodel
    {
        [Key]
        public int id { get; set; }
        [MaxLength(15)]
        [Required(ErrorMessage ="This Field is required.")]
        public string name { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        public int age { get; set; }
        [Required(ErrorMessage = "This Field is required.")]
        public double salary { get; set; }
        [MaxLength(11)]
        [Required(ErrorMessage = "This Field is required.")]
        public string moblie { get; set; }
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}")]
        public DateTime Date { get; set; }
    }
}
