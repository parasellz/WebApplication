﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            //Test Upload 1
            return "Hello World";
        }

        [WebMethod]
        public string test1(FlightMatrixService.FlightMatrixRQ request)
        {
            return "Hello World";
        }


        [WebMethod]
        public string test2(AirSellService.OTA_AirPriceRQ request)
        {
            return "Hello World";
        }
    }
}
