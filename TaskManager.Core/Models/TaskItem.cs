using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Core.Models
{
    public class TaskItem
    {
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public string Priority { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; } // "Pending", "In Progress", or "Complete"
        public int UserId { get; set; }
        public string Note { get; set; }

    }
}
