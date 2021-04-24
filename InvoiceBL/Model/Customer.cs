using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceBL.Model
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
