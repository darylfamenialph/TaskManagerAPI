using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagerAPI.Models
{
    public class Tasks
    {
        [Key]
        public int TaskId { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string Description { get; set; }

        public Users User { get; set; }

        public bool isCompleted { get; set; }
    }
}
