using System;

namespace RestService.Helper
{
    public class Log
    {
        public DateTime RequestToRest { get; set; }
        public DateTime RequestToSoap { get; set; }
        public DateTime ResponseFromSoap { get; set; }
    }

}