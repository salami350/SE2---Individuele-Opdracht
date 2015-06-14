﻿using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace SE2___Individuele_Opdracht
{
    public class Service : Advert
    {
        public string Experience { get; set; }
        public string Employees { get; set; }
        public string CompanyType { get; set; }

        public Service(int advertID, string title, DateTime creationDate, int views, bool isService, int userID, string experience, string employees, string companyType) : base(advertID, title, creationDate, views, isService, userID)
        {
            Experience = experience;
            Employees = employees;
            CompanyType = companyType;
        }
    }
}
