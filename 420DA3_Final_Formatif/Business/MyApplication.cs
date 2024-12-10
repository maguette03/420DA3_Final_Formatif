using _420DA3_Final_Formatif.Business.Services;
using _420DA3_Final_Formatif.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business
{
    internal class MyApplication
    {
        private MyDbContext context;
        public CountryServices CountryServices { get; private set; }
        public LanguageServices LanguageServices { get; private set; }

        public MyApplication() { 
            this.context = new MyDbContext();
            this.CountryServices = new CountryServices(this,this.context);
            this.LanguageServices = new LanguageServices(this, this.context);
        }
    }
}
