using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Queue
    {
        [Key]
        public int Id { get; set; }
        public DateTime RegDate { get; set; }
        [ForeignKey(nameof(Child.Id))]
        public Guid ChildId { get; set; }
        [ForeignKey(nameof(Group.Id))]
        public Guid GroupId { get; set; }
        
    }
}
