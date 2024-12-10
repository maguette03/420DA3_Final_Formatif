using _420DA3_Final_Formatif.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Services
{
    internal class CountryServices
    {
        private CountryDAO dao;

        public CountryServices(MyApplication parentApp, MyDbContext context)
        {
            this.dao = new CountryDAO(context)
        }
    }
}
