using System;
using System.Collections.Generic;

#nullable disable

namespace PRNProject.Models
{
    public partial class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public int? UserId { get; set; }
      
        public virtual User User { get; set; }
    }
}
