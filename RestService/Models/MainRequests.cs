using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestService.Models
{
    public class MainRequest
    {
        [Key]
        public int Id { get; set; }
        public DateTime Insert_Time { get; set; }
        public virtual IEnumerable<Request> Requests { get; set; }
    }
}