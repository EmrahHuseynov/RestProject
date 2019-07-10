using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestService.CalculatorService;

namespace RestService.Singleton
{
    public class GetCalculatorService
    {
       private static CalculatorSoapClient instance { get; set; }
        private GetCalculatorService()
        {
            if (instance == null)
                instance = new CalculatorSoapClient();
        }

        public static CalculatorSoapClient GetInstance()
        {
            if (instance == null)
                instance = new CalculatorSoapClient();
            return instance;
        }

    }
}