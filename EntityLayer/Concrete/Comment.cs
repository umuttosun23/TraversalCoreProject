using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string Message { get; set; }
        public string Subject { get; set; }
        public DateTime Date { get; set; }
        public string UserName { get; set; }
        public bool status { get; set; }
        public int DestinationID { get; set; }
        public Destination Destination { get; set; }
    }
}
