using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Helper
{
    public class RestResponse
    {
        public string OperationName { get; set; }
        public int ? FirstNumber { get; set; }
        public  int ? SecondNumber { get; set; }
        public double ? Result { get; set; }
        public string Error { get; set; }
    }

}