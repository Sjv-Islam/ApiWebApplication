using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebApplication.Models
{
    [Table("tblDesignation")]
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }
        [Required]
        public required string DesignationName { get; set; }

        public virtual IList<Employee>? Employees { get; set; }
    }
}
