using _420DA3_Final_Formatif.Business.Services;
using _420DA3_Final_Formatif.DataAccess;
using _420DA3_Final_Formatif.Presentation;
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
        public MainMenu mainMenu;
        public CountryServices CountryServices { get; private set; }
        public LanguageServices LanguageServices { get; private set; }

        public MyApplication() {
            ApplicationConfiguration.Initialize();
            this.context = new MyDbContext();
            this.mainMenu = new MainMenu(this);
            this.CountryServices = new CountryServices(this,this.context);
            this.LanguageServices = new LanguageServices(this, this.context);
        }

        public  void Start()
        {
            Application.Run(this.mainMenu);
        }
    }
}
