﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTSLibrary
{
    public class PTSCustomerFacade : PTSSuperFacade
    {
        private DAO.CustomerDAO dao;
        public PTSCustomerFacade():base(new DAO.CustomerDAO())
        {
            dao = (DAO.CustomerDAO)base.dao;

        }

        public int Authenticate(string username, string password)
        {
            if (username == "" || password == "")
            {
                throw new Exception("Missing Data");

            }
            return dao.Authenticate(username, password);
        }

        public Project[] GetListOfProjects(int customerId)
        {
            return (dao.GetListOfProjects(customerId)).ToArray();
        }

    }
}
