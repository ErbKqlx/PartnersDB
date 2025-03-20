using Microsoft.EntityFrameworkCore;
using PartnersDB.Models;
using System.ComponentModel;
using System.Windows.Forms;

namespace PartnersDB
{
    public partial class FormPartners : Form
    {
        private PartnersContext db;
        private short id;
        private Panel selectedPanel;
        public FormPartners()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            db = new PartnersContext();
            db.Partners.Load();
            db.Products.Load();
            db.PartnersProducts.Load();
            db.TypesOfPartners.Load();
            db.TypesOfProducts.Load();

            var partners = db.Partners.Local.OrderBy(p => p.Id).ToList();
            foreach (var partner in partners)
            {

                CreatePanel(
                    partner.Id,
                    db.TypesOfPartners.FirstOrDefault(t => t.Id == partner.IdTypeOfPartner).TypeOfPartner,
                    partner.Name,
                    partner.NameOfDirector,
                    partner.Phone,
                    partner.Rating
                );
                
            }

        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            db?.Dispose();
            db = null;
        }

        private void ButtonAddPartner_Click(object sender, EventArgs e)
        {
            FormAdd formAdd = new FormAdd(db.TypesOfPartners);
            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            Partner partner = new()
            {
                //IdTypeOfPartner = db.TypesOfPartners
                    //.FirstOrDefault(t => t.TypeOfPartner == formAdd.typeOfPartner.SelectedValue.ToString()).Id,
                IdTypeOfPartner = (short)formAdd.typeOfPartner.SelectedValue,
                Name = formAdd.name.Text,
                LegalAdress = formAdd.legalAdress.Text,
                Inn = formAdd.inn.Text,
                NameOfDirector = formAdd.nameOfDirector.Text,
                Phone = formAdd.phone.Text,
                Email = formAdd.email.Text,
                Rating = short.Parse(formAdd.rating.Text)
            };

            db.Partners.Add(partner);
            db.SaveChanges();



            CreatePanel(
                partner.Id,
                db.TypesOfPartners.FirstOrDefault(t => t.Id == partner.IdTypeOfPartner).TypeOfPartner,
                partner.Name,
                partner.NameOfDirector,
                partner.Phone,
                partner.Rating
            );

            MessageBox.Show("Партнер добавлен");
        }

        private void ButtonUpdatePartner_Click(object sender, EventArgs e)
        {
            if (selectedPanel == null)
                return;

            var partner = db.Partners.Find(id);

            FormAdd formAdd = new FormAdd(db.TypesOfPartners);

            formAdd.typeOfPartner.SelectedIndex = partner.IdTypeOfPartner-1;
            formAdd.name.Text = partner.Name;
            formAdd.legalAdress.Text = partner.LegalAdress;
            formAdd.inn.Text = partner.Inn;
            formAdd.nameOfDirector.Text = partner.NameOfDirector;
            formAdd.phone.Text = partner.Phone;
            formAdd.email.Text = partner.Email;
            formAdd.rating.Text = partner.Rating.ToString();

            DialogResult result = formAdd.ShowDialog(this);

            if (result == DialogResult.Cancel)
                return;

            partner.IdTypeOfPartner = (short)formAdd.typeOfPartner.SelectedValue;
            partner.Name = formAdd.name.Text;
            partner.LegalAdress = formAdd.legalAdress.Text;
            partner.Inn = formAdd.inn.Text;
            partner.NameOfDirector = formAdd.nameOfDirector.Text;
            partner.Phone = formAdd.phone.Text;
            partner.Email = formAdd.email.Text;
            partner.Rating = short.Parse(formAdd.rating.Text);

            db.SaveChanges();


        }

        private void Panel_MouseDown(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            id = short.Parse(panel.Name.Split("_")[1]);
            panel.BackColor = Color.AliceBlue;

            if (panel != selectedPanel && selectedPanel != null)
            {
                selectedPanel.BackColor = Color.White;
            }
            selectedPanel = panel;
        }

        private void Panel_MouseUp(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BackColor = Color.White;
        }

        private void CreatePanel(short id, string type, string name, string director, string number, short? rate)
        {
            var panel = new Panel();
            Label nameOfPartner = new();
            Label nameOfDirector = new();
            Label phone = new();
            Label rating = new();
            Label percent = new();

            // 
            // percent
            // 
            percent.Location = new Point(709, 15);
            percent.Name = "percent";
            percent.Size = new Size(49, 28);
            percent.TabIndex = 4;
            percent.Text = "0%";
            // 
            // rating
            // 
            rating.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rating.Location = new Point(20, 93);
            rating.Name = "rating";
            rating.Size = new Size(278, 25);
            rating.TabIndex = 3;
            rating.Text = $"Рейтинг: {rate}";
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phone.Location = new Point(20, 68);
            phone.Name = "phone";
            phone.Size = new Size(278, 25);
            phone.TabIndex = 2;
            phone.Text = $"+7 {number}";
            // 
            // nameOfDirector
            // 
            nameOfDirector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameOfDirector.Location = new Point(20, 43);
            nameOfDirector.Name = "nameOfDirector";
            nameOfDirector.Size = new Size(278, 25);
            nameOfDirector.TabIndex = 1;
            nameOfDirector.Text = director.ToString();
            // 
            // nameOfPartner
            // 
            nameOfPartner.Location = new Point(20, 15);
            nameOfPartner.Name = "nameOfPartner";
            nameOfPartner.Size = new Size(278, 28);
            nameOfPartner.TabIndex = 0;
            nameOfPartner.Text = $"{type} | {name}";

            // 
            // panel
            // 
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Controls.Add(percent);
            panel.Controls.Add(rating);
            panel.Controls.Add(phone);
            panel.Controls.Add(nameOfDirector);
            panel.Controls.Add(nameOfPartner);
            panel.Name = $"panel_{id}";
            panel.Size = new Size(815, 131);
            panel.TabIndex = 1;
            panel.MouseDown += Panel_MouseDown;

            flowLayoutPartners.Controls.Add(panel);
        }

    }
}
