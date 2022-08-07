﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PTSLibrary;

namespace PTSWebServ
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

        private PTSCustomerFacade facade;


        public void HelloService()
        {
            facade = new PTSCustomerFacade();
        }

        [WebMethod]
        public int authenticate(string username, string password)
        {
            return facade.Authenticate(username, password);
        }

        [WebMethod]
        public Project[] GetListOfProjects(int customerId)
        {
            return facade.GetListOfProjects(customerId);

        }
    }
}
