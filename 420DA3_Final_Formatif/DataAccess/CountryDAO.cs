using _420DA3_Final_Formatif.Business.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.DataAccess
{
    internal class CountryDAO
    {
        private MyDbContext context;
        public CountryDAO(MyDbContext context)
        {
            this.context = context;
        }

        public List<Country> Search(string criterion)
        {
            return this.context.Countries
                .Where(c => c.ShortName.Contains(criterion) || c.FullName.Contains(criterion))
                .Include(c => c.Languages)
                .ToList();
        }

        public Country Insert(Country country) { 
            _= this.context.Countries.Add(country);
            _= this.context.SaveChanges();
            return country;
        }
        public Country Update(Country country) { 
            _= this.context.Countries.Update(country);
            _= this.context.SaveChanges();
            return country;
        }

        public Country Delete(Country country) { 
            _= this.context.Countries .Remove(country);
            _= this.context.SaveChanges();
            return country;
        }
    }
}
