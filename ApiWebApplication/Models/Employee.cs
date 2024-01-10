using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebApplication.Models
{
    [Table("tblEmployee")]
    public class Employee
    {
        [Key]
        public Guid EmpId { get; set; } = Guid.NewGuid();
        [Required]
        [StringLength(150,MinimumLength = 5)]
        public string EmpName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(150)]
        public string? Email { get; set; }
        public string? EmpImage { get; set; }
        public bool Active { get; set; }
        public int DesignationId { get; set; }
        public virtual Designation? Designation { get; set; }

        public virtual IList<Experience>? Experiences { get; set; }
    }
}
