using RestService.Models;
using RestService.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestService.Helper
{
    public static class HelperMethods
    {
        public  static void AddLogToDb(Log _log)
        {
            ProjectContext context = GetContext.GetInstance();
            var mainrequest = context.mainRequests.Add(new MainRequest { Insert_Time = _log.RequestToRest });
            context.SaveChanges();
            context.requests.Add(new Request { MainRequestId = mainrequest.Id, Insert_Time = _log.RequestToRest, Value = "Request to REST" });
            context.requests.Add(new Request { MainRequestId = mainrequest.Id, Insert_Time = _log.RequestToSoap, Value = "Request to SOAP" });
            context.requests.Add(new Request { MainRequestId = mainrequest.Id, Insert_Time = _log.ResponseFromSoap, Value = "Response from SOAP" });
            context.SaveChanges();
        }

    }
}