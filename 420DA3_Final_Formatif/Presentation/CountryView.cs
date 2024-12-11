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
    public enum ViewAction
    {
        Create,
        View,
        Update,
        Delete
    }
    internal partial class CountryView : Form
    {
        private MyApplication parentApp;
        private ViewAction currentAction;
        private Country currentInstance = null!;
        private bool isInitialized = false;

        public CountryView(MyApplication parentApp)
        {
            this.parentApp = parentApp;
            InitializeComponent();
            this.ShortNameValue.MaxLength = Country.SHORT_NAME_MAX_LENGTH;
            this.FullNameValue.MaxLength = Country.FULL_NAME_MAX_LENGTH;
        }

        public DialogResult OpenForCreation(Country newCountry)
        {
            try {
                this.Initialize();
                this.currentAction = ViewAction.Create;
                this.LoadCountryData(newCountry);
                this.btnAction.Text = "Create";
                this.ShortNameValue.Enabled = true;
                this.FullNameValue.Enabled = true;
                this.SpokenLanguageValue.Enabled = true;
                return this.ShowDialog();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return DialogResult.Abort;
            }
        

        }
        public DialogResult OpenForView(Country country)
        {
            try
            {
                this.Initialize();
                this.currentAction = ViewAction.View;
                this.LoadCountryData(country);
                this.btnAction.Text = "OK";
                //desactiver les champs vue que c'est juste le view
                this.ShortNameValue.Enabled = false;
                this.FullNameValue.Enabled = false;
                this.SpokenLanguageValue.Enabled = false;   
                return this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }
        }
        public DialogResult OpenForModification(Country country)
        {

            try
            {
                this.Initialize();
                this.currentAction = ViewAction.Update;
                this.LoadCountryData(country);
                this.btnAction.Text = "Save";
                this.ShortNameValue.Enabled = true;
                this.FullNameValue.Enabled = true;
                this.SpokenLanguageValue.Enabled = true;
                return this.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }

        }
        public DialogResult OpenForDeletion(Country country)
        {
            try
            {
                this.Initialize();
                this.currentAction = ViewAction.Delete;
                this.LoadCountryData(country);
                this.btnAction.Text = "Confirm";
                this.ShortNameValue.Enabled = false;
                this.FullNameValue.Enabled = false;
                this.SpokenLanguageValue.Enabled = false;
                return this.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return DialogResult.Abort;
            }


        }
        public  void Initialize()
        {
            if (!this.isInitialized) {
                List<Language> languages = this.parentApp.LanguageServices.GetAll();
                foreach (Language language in languages)
                {
                    this.SpokenLanguageValue.Items.Add(language);
                }
            }
          
            this.isInitialized = true;
        }

        private  void LoadCountryData(Country country)
        {
            this.currentInstance = country;

            this.IdValue.Value = country.Id;
            this.ShortNameValue.Text = country.ShortName;
            this.FullNameValue.Text = country.FullName;


            //la selection des donnes 

            this.SpokenLanguageValue.SelectedItem = null;
            this.SpokenLanguageValue.SelectedIndex = -1;
            this.SpokenLanguageValue.SelectedItems.Clear();
            foreach(Language language in country.Languages)
            {
                this.SpokenLanguageValue.SelectedItems.Add(language);
            }

        }
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            switch (this.currentAction)
            {
                case ViewAction.Create:
                    this.currentInstance.ShortName = this.ShortNameValue.Text;
                    this.currentInstance.FullName = this.FullNameValue.Text;

                    this.currentInstance.Languages.Clear();
                    this.currentInstance.Languages = this.SpokenLanguageValue.SelectedItems.Cast<Language>().ToList();
                    this.parentApp.CountryServices.InsertCountry(this.currentInstance);
                    break;
                case ViewAction.Update:
                    this.currentInstance.ShortName = this.ShortNameValue.Text;
                    this.currentInstance.FullName = this.FullNameValue.Text;

                    this.currentInstance.Languages.Clear();
                    this.currentInstance.Languages = this.SpokenLanguageValue.SelectedItems.Cast<Language>().ToList();
                    this.parentApp.CountryServices.UpdateCountry(this.currentInstance);
                    break;

                case ViewAction.Delete:
                    this.parentApp.CountryServices.DeleteCountry(this.currentInstance);
                    break;
                case ViewAction.View:
                default:
                    //il ya rien a faire
                    break;
            }
            this.DialogResult = DialogResult.OK;

        }
    }
}
