using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420DA3_Final_Formatif.Business.Domain
{
    public class Country
    {
        public const int SHORT_NAME_MAX_LENGTH = 32;
        public const int FULL_NAME_MAX_LENGTH = 128;


        private string shortName;
        private string fullName;

        public int Id { get; set; }
        // système de validation pour la longueur des valeurs des propriétés textuelles
        public string ShortName { 
            get {
                return  this.shortName;
            } 
            set {
                if (value.Length > SHORT_NAME_MAX_LENGTH) {
                    throw new Exception($"La longueur  maximal de ShortName doit etre de {SHORT_NAME_MAX_LENGTH} caractere. ");
                }
                this.ShortName = value;
            } 
        }
        public string FullName
        {
            get
            {
                return this.fullName;
            }
            set
            {
                if (value.Length > SHORT_NAME_MAX_LENGTH)
                {
                    throw new Exception($"La longueur  maximal de FullName doit etre de {FULL_NAME_MAX_LENGTH} caractere. ");
                }
                this.fullName = value;
            }
        }
        public byte[] RowVersion { get; set; }

        //◦ propriétés de navigation :
        public virtual List<Language> Languages { get; set; } = new List<Language>();


        //constructeur
        
        public Country() { }
        public  Country(int id, string shortName, string fullName, byte[] rowVersion)
        {
            this.Id = id;
            this.ShortName = shortName;
            this.FullName = fullName;
            this.RowVersion = rowVersion;
        }
    }
}
