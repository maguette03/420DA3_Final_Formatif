using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Domain
{
    public class Language
    {
        public const int NAME_MAX_LENGTH = 32;
        public const int ISOCODE_MAX_LENGTH = 2;


        private string name;
        private string isoCode;

        public int Id { get; set; }
        // système de validation pour la longueur des valeurs des propriétés textuelles
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length > NAME_MAX_LENGTH)
                {
                    throw new Exception($"La longueur  maximal de Name doit etre de {NAME_MAX_LENGTH} caractere. ");
                }
                this.name = value;
            }
        }
        public string IsoCode
        {
            get
            {
                return this.isoCode;
            }
            set
            {
                if (value.Length > ISOCODE_MAX_LENGTH)
                {
                    throw new Exception($"La longueur  maximal de Isocode doit etre de {ISOCODE_MAX_LENGTH} caractere. ");
                }
                this.isoCode = value;
            }
        }
        public byte[] RowVersion { get; set; }

        //◦ propriétés de navigation :
        public virtual List<Country> CountriesSpoken { get; set; } = new List<Country>();


        //Constructeur 
        public Language() { }
        protected Language(int id, string name , string isoCode , byte[] rowVersion)
        {
            this.Id = id;
            this.Name = name;
            this.IsoCode = isoCode;
            this.RowVersion = rowVersion;
        }
    }
}
