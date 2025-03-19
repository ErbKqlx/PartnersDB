using Microsoft.EntityFrameworkCore;
using PartnersDB.Models;

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

            if (name.Text == null 
                || legalAdress.Text == null
                || inn.Text == null
                || nameOfDirector == null
                || phone == null
                || email == null
                || rating == null)
            {
                MessageBox.Show(msgEmpty);
                buttonSave.Enabled = false;
            }
            //else if (!inn.TryParse())
        }
    }
}
