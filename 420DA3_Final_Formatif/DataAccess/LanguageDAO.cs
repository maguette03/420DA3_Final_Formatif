using _420DA3_Final_Formatif.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{
    internal class LanguageDAO
    {
        private MyDbContext context;

        public  LanguageDAO(MyDbContext context)
        {
            this.context = context;
        }

        public List<Language>GetCountrySpokenLanguages(Country country)
        {
            return this.context.Languages
                .Include(l => l.CountriesSpoken)
                .Where(l => l.CountriesSpoken.Contains(country))
                .ToList();
        }

        public List<Language> GetCountryNotSpokenLanguage(Country country) {
            return this.context.Languages
                .Include(l => l.CountriesSpoken)
                .Where(l => !l.CountriesSpoken.Contains(country))
                .ToList();
        }
    }
}
