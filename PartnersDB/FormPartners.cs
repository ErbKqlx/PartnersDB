namespace PartnersDB
{
    public partial class FormPartners : Form
    {
        public FormPartners()
        {
            InitializeComponent();
        }

        private void ButtonAddPartner_Click(object sender, EventArgs e)
        {

        }

        private void Panel_MouseHover(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BackColor = Color.AliceBlue;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            var panel = sender as Panel;
            panel.BackColor = Color.White;
        }
    }
}
