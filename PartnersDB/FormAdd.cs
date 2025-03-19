using Microsoft.EntityFrameworkCore;
using PartnersDB.Models;
using System.ComponentModel;

namespace PartnersDB
{
    public partial class FormAdd : Form
    {
        private const string msgEmpty = "Поля не могут быть пустыми";
        private const string convertError = "Не удалось преобразовать строку в число";

        public FormAdd(DbSet<TypesOfPartner> typesOfPartners)
        {
            InitializeComponent();

            typeOfPartner.DataSource = typesOfPartners.Local.ToBindingList();
            typeOfPartner.DisplayMember = "TypeOfPartner";
            typeOfPartner.ValueMember = "Id";



            //else if (!inn.TryParse())
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (name.Text == ""
                || legalAdress.Text == ""
                || inn.Text == ""
                || nameOfDirector.Text == ""
                || phone.Text == ""
                || email.Text == ""
                || rating.Text == "")
            {
                
            }
        }
    }
}
