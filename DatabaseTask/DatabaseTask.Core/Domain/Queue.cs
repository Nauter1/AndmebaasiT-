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
        public ICollection<Child> ChildId { get; set; }
        public ICollection<Group> GroupId { get; set; }
        
    }
}
