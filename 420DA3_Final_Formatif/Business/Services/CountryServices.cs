using _420DA3_Final_Formatif.Business.Domain;
using _420DA3_Final_Formatif.DataAccess;
using _420DA3_Final_Formatif.Presentation;
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
        private CountryView view;

        public CountryServices(MyApplication parentApp, MyDbContext context)
        {
            this.dao = new CountryDAO(context);
            this.view = new CountryView(parentApp);
        }

        public Country? OpenViewForCreation()
        {
            Country nowCountry = new Country();
            DialogResult result = this.view.OpenForCreation(nowCountry);
            if (result == DialogResult.OK)
            {
                return nowCountry;
            }
            else
            {
                return null;
            }
        }

        public Country OpenViewForView(Country country)
        {
            this.view.OpenForView(country);
            return country;
        }


        public Country? OpenViewForModification(Country country)
        {
            DialogResult result = this.view.OpenForModification(country);
            if (result == DialogResult.OK)
            {
                return country;
            }
            else
            {
                return null;
            }
        }

        public Country? OpenViewForDeletion(Country country)
        {
            DialogResult result = this.view.OpenForDeletion(country);
            if (result == DialogResult.OK)
            {
                return country;
            }
            else
            {
                return null;
            }
        }

        public List<Country> SearchCountries(string criterion)
        {
            return this.dao.Search(criterion);
        }

        public Country InsertCountry(Country country)
        {
            return this.dao.Insert(country);
        }
        public Country UpdateCountry(Country country) { 
            return this.dao.Update(country);
        }
        public Country DeleteCountry(Country country) { 
            return this.dao.Delete(country);
        }
    }

}
