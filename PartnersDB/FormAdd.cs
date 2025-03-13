using Microsoft.EntityFrameworkCore;
using PartnersDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PartnersDB
{
    public partial class FormAdd : Form
    {

        public FormAdd(DbSet<TypesOfPartner> typesOfPartners)
        {
            InitializeComponent();

            typeOfPartner.DataSource = typesOfPartners.Local.ToBindingList();
            typeOfPartner.DisplayMember = "TypeOfPartner";
            typeOfPartner.ValueMember = "Id";
        }
    }
}
