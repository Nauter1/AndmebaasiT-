using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Absense
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Child.Id))]
        public Guid ChildId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        [ForeignKey(nameof(Group.Id))]
        public Guid GroupId { get; set; }
    }
}
