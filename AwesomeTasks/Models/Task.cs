using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AwesomeTasks.Models
{
    public class Task
    {
        [Key]
        public int ID { get; set; }

        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}