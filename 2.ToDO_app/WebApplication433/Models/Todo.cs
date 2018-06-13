using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication433.Models
{
    public class Todo
    {   

        public int TodoId { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? TimeOfCompletion { get; set; }
        public bool Done { get; set; }

    }
}