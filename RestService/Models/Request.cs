using System;
using System.ComponentModel.DataAnnotations;

namespace RestService.Models
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public DateTime Insert_Time { get; set; }
        public int MainRequestId { get; set; }
        public virtual MainRequest MainRequest { get; set; }
        public string Value { get; set; }

    }
}