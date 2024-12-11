﻿using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Services
{
    internal class LanguageServices
    {
        private LanguageDAO dao;

        public LanguageServices(MyApplication parentApp, MyDbContext context)
        {
            this.dao = new LanguageDAO(context);
        }

        public List<Language> GetAll() {
            return this.dao.GetAll();
        }
        public List<Language> GetCountrySpokenLanguages(Country country)
        {
            return this.dao.GetCountrySpokenLanguages(country);
        }
         
        public  List<Language> GetCountryNotSpokenLanguages(Country coutry)
        {
            return this.dao.GetCountryNotSpokenLanguage(coutry);
        }

    }
}
