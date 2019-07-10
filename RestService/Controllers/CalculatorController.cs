using RestService.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using RestService.CalculatorService;
using RestService.Helper;
using NLog;
using RestService.Models;
using RestService.Oauth;
using static RestService.Helper.HelperMethods;
using System.Threading.Tasks;

namespace RestService.Controllers
{
    [Authorize]
    public class CalculatorController : ApiController
    {
        Logger logger = LogManager.GetLogger(""); //NLog library instance for logging to file
        [HttpGet]
        public JsonResult<RestResponse> Add(int? a, int? b)
        {
            if (a != null && b != null)
            {
                try
                {
                    //For get all required log data instance
                    Log _log = new Log();
                    //Log to file
                    logger.Info("Request to Rest");
                    _log.RequestToRest = DateTime.Now;
                    //Instance of calculator
                    CalculatorSoapClient calculator = GetCalculatorService.GetInstance();
                    //Log to file
                    logger.Info("Request to SOAP"); 
                    _log.RequestToSoap = DateTime.Now; 
                    var result = calculator.Add((int)a, (int)b);
                    //Log to file
                    logger.Info("Response from  SOAP"); 
                    _log.ResponseFromSoap = DateTime.Now;
                    //Logging to Database
                    AddLogToDb(_log);  
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = result, OperationName = "Add", Error = null });
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Add", Error = ex.Message });
                }
            }
            else
            {
                return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Add", Error = "Params must be fill correctly" });
            }
        }

        [HttpGet]
        public JsonResult<RestResponse> Divide(int? a, int? b)
        {
            if (a != null && b != null)
            {
                try
                {
                    Log _log = new Log();
                    logger.Info("Request to Rest");
                    _log.RequestToRest = DateTime.Now;
                    CalculatorSoapClient calculator = GetCalculatorService.GetInstance();
                    logger.Info("Request to SOAP");
                    _log.RequestToSoap = DateTime.Now;
                    var result = calculator.Divide((int)a, (int)b);
                    logger.Info("Response from  SOAP");
                    _log.ResponseFromSoap = DateTime.Now;
                    AddLogToDb(_log);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = result, OperationName = "Divide", Error = null });
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Divide", Error = ex.Message });
                }

            }
            else
            {
                return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Divide", Error = "Params must be fill correctly" });
            }
        }

        [HttpGet]
        public JsonResult<RestResponse> Multiply(int? a, int? b)
        {
            if (a != null && b != null)
            {
                try
                {
                    Log _log = new Log();
                    logger.Info("Request to Rest");
                    _log.RequestToRest = DateTime.Now;
                    CalculatorSoapClient calculator = GetCalculatorService.GetInstance();
                    logger.Info("Request to SOAP");
                    _log.RequestToSoap = DateTime.Now;
                    var result = calculator.Multiply((int)a, (int)b);
                    logger.Info("Response from  SOAP");
                    _log.ResponseFromSoap = DateTime.Now;

                    AddLogToDb(_log);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = result, OperationName = "Multiply", Error = null });
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "MuLtiply", Error = ex.Message });
                }

            }
            else
            {
                return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Multiply", Error = "Params must be fill correctly" });
            }
        }

        [HttpGet]
        public JsonResult<RestResponse> Subtract(int? a, int? b)
        {
            if (a != null && b != null)
            {
                try
                {
                    Log _log = new Log();
                    logger.Info("Request to Rest");
                    _log.RequestToRest = DateTime.Now;
                    CalculatorSoapClient calculator = GetCalculatorService.GetInstance();
                    logger.Info("Request to SOAP");
                    _log.RequestToSoap = DateTime.Now;
                    var result = calculator.Subtract((int)a, (int)b);
                    logger.Info("Response from  SOAP");
                    _log.ResponseFromSoap = DateTime.Now;
                    AddLogToDb(_log);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = result, OperationName = "Subtract", Error = null });
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message);
                    return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Subtract", Error = ex.Message });
                }
            }
            else
            {
                return Json(new RestResponse { FirstNumber = a, SecondNumber = b, Result = null, OperationName = "Subtract", Error = "Params must be fill correctly" });
            }
        }
    }

}
