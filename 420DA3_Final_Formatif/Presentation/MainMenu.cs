using _420DA3_Final_Formatif.Business;
using _420DA3_Final_Formatif.Business.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _420DA3_Final_Formatif.Presentation
{
    internal partial class MainMenu : Form
    {
        private MyApplication parentApp;
        public MainMenu(MyApplication parentApp)
        {
            this.parentApp = parentApp;
            InitializeComponent();
        }

        private void btnCreateCountry_Click(object sender, EventArgs e)
        {
           Country? newCountry= this.parentApp.CountryServices.OpenViewForCreation();
            if (newCountry != null) { 
                this.searchResults.Items.Add(newCountry);
            }
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            //on cherche les resultat
            List<Country> result = this.parentApp.CountryServices.SearchCountries(this.SearchTextBox.Text.Trim());
            //on remplie la liste 
            this.searchResults.SelectedItem = null;
            this.searchResults.SelectedIndex = -1;
            //et on vide la liste
            this.searchResults.Items.Clear();
            //on re remplie la liste
            foreach (Country country in result) {
                this.searchResults.Items.Add(country);
            }
            
        }

        private void searchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lorsque quelqu'un selection quelque chose dans la liste on essaye d'aller cherche la valeur 
            Country? selectedCountry = this.searchResults.SelectedItem as Country;
            if (selectedCountry != null) {
                this.btnView.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnView.Enabled = false;
                this.btnEdit.Enabled = false;
                this.btnDelete.Enabled = false;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //On va chercher le pays selectionner 
            Country? selectedCountry = this.searchResults.SelectedItem as Country;
            if (selectedCountry != null)
            {
                this.parentApp.CountryServices.OpenViewForView(selectedCountry);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Country? selectedCountry = this.searchResults.SelectedItem as Country;
            if (selectedCountry != null)
            {
                this.parentApp.CountryServices.OpenViewForModification(selectedCountry);
                this.searchResults.Refresh();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Country? selectedCountry = this.searchResults.SelectedItem as Country;
            if (selectedCountry != null)
            {
                this.parentApp.CountryServices.OpenViewForDeletion(selectedCountry);
            }

        }

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
