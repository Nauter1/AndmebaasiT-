using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public enum Type
    {
        Main, Sub
    }
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public int ChildCount { get; set; }
        public string GroupName { get; set; }
        public Type GroupType { get; set; }
        public int RoomNumber { get; set; }
    }
}
