using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiWebApplication.Models
{
    [Table("tblExperince")]
    public class Experience
    {
        [Key]
        public int ExperienceId { get; set; }
        [Required]
        public string Company { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Guid EmployeeId { get; set; }

        public virtual Employee? Employee { get; set; }
    }
}
