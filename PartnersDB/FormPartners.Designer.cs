namespace PartnersDB
{
    partial class FormPartners
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutButtons = new FlowLayoutPanel();
            buttonAddPartner = new Button();
            buttonUpdatePartner = new Button();
            buttonDeletePartner = new Button();
            panel0 = new Panel();
            percent = new Label();
            rating = new Label();
            phone = new Label();
            nameOfDirector = new Label();
            nameOfPartner = new Label();
            flowLayoutPartners = new FlowLayoutPanel();
            flowLayoutButtons.SuspendLayout();
            panel0.SuspendLayout();
            flowLayoutPartners.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutButtons
            // 
            flowLayoutButtons.Controls.Add(buttonAddPartner);
            flowLayoutButtons.Controls.Add(buttonUpdatePartner);
            flowLayoutButtons.Controls.Add(buttonDeletePartner);
            flowLayoutButtons.Dock = DockStyle.Top;
            flowLayoutButtons.Location = new Point(10, 10);
            flowLayoutButtons.Margin = new Padding(5);
            flowLayoutButtons.Name = "flowLayoutButtons";
            flowLayoutButtons.Size = new Size(841, 71);
            flowLayoutButtons.TabIndex = 0;
            // 
            // buttonAddPartner
            // 
            buttonAddPartner.BackColor = Color.White;
            buttonAddPartner.Location = new Point(5, 5);
            buttonAddPartner.Margin = new Padding(5);
            buttonAddPartner.Name = "buttonAddPartner";
            buttonAddPartner.Size = new Size(246, 58);
            buttonAddPartner.TabIndex = 0;
            buttonAddPartner.Text = "Добавить партнера";
            buttonAddPartner.UseVisualStyleBackColor = false;
            buttonAddPartner.Click += ButtonAddPartner_Click;
            // 
            // buttonUpdatePartner
            // 
            buttonUpdatePartner.BackColor = Color.White;
            buttonUpdatePartner.Location = new Point(261, 5);
            buttonUpdatePartner.Margin = new Padding(5);
            buttonUpdatePartner.Name = "buttonUpdatePartner";
            buttonUpdatePartner.Size = new Size(246, 58);
            buttonUpdatePartner.TabIndex = 1;
            buttonUpdatePartner.Text = "Редактировать партнера";
            buttonUpdatePartner.UseVisualStyleBackColor = false;
            // 
            // buttonDeletePartner
            // 
            buttonDeletePartner.BackColor = Color.White;
            buttonDeletePartner.Location = new Point(517, 5);
            buttonDeletePartner.Margin = new Padding(5);
            buttonDeletePartner.Name = "buttonDeletePartner";
            buttonDeletePartner.Size = new Size(319, 58);
            buttonDeletePartner.TabIndex = 2;
            buttonDeletePartner.Text = "Посмотреть истории реализации продукций партнером";
            buttonDeletePartner.UseVisualStyleBackColor = false;
            // 
            // panel0
            // 
            panel0.BackColor = Color.White;
            panel0.BorderStyle = BorderStyle.FixedSingle;
            panel0.Controls.Add(percent);
            panel0.Controls.Add(rating);
            panel0.Controls.Add(phone);
            panel0.Controls.Add(nameOfDirector);
            panel0.Controls.Add(nameOfPartner);
            panel0.Location = new Point(3, 3);
            panel0.Name = "panel0";
            panel0.Size = new Size(833, 131);
            panel0.TabIndex = 1;
            panel0.MouseEnter += Panel_MouseHover;
            panel0.MouseLeave += Panel_MouseLeave;
            // 
            // percent
            // 
            percent.Location = new Point(709, 15);
            percent.Name = "percent";
            percent.Size = new Size(49, 28);
            percent.TabIndex = 4;
            percent.Text = "10%";
            // 
            // rating
            // 
            rating.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rating.Location = new Point(20, 93);
            rating.Name = "rating";
            rating.Size = new Size(278, 25);
            rating.TabIndex = 3;
            rating.Text = "Рейтинг: 10";
            // 
            // phone
            // 
            phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            phone.Location = new Point(20, 68);
            phone.Name = "phone";
            phone.Size = new Size(278, 25);
            phone.TabIndex = 2;
            phone.Text = "+7 223 322 22 32";
            // 
            // nameOfDirector
            // 
            nameOfDirector.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameOfDirector.Location = new Point(20, 43);
            nameOfDirector.Name = "nameOfDirector";
            nameOfDirector.Size = new Size(278, 25);
            nameOfDirector.TabIndex = 1;
            nameOfDirector.Text = "Директор";
            // 
            // nameOfPartner
            // 
            nameOfPartner.Location = new Point(20, 15);
            nameOfPartner.Name = "nameOfPartner";
            nameOfPartner.Size = new Size(278, 28);
            nameOfPartner.TabIndex = 0;
            nameOfPartner.Text = "Тип | Наименование партнера";
            // 
            // flowLayoutPartners
            // 
            flowLayoutPartners.Controls.Add(panel0);
            flowLayoutPartners.Dock = DockStyle.Fill;
            flowLayoutPartners.FlowDirection = FlowDirection.TopDown;
            flowLayoutPartners.Location = new Point(10, 81);
            flowLayoutPartners.Name = "flowLayoutPartners";
            flowLayoutPartners.Size = new Size(841, 483);
            flowLayoutPartners.TabIndex = 2;
            // 
            // FormPartners
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 574);
            Controls.Add(flowLayoutPartners);
            Controls.Add(flowLayoutButtons);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "FormPartners";
            Padding = new Padding(10);
            Text = "Партнеры";
            flowLayoutButtons.ResumeLayout(false);
            panel0.ResumeLayout(false);
            flowLayoutPartners.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutButtons;
        private Button buttonAddPartner;
        private Button buttonUpdatePartner;
        private Button buttonDeletePartner;
        private Panel panel0;
        private Label nameOfPartner;
        private Label rating;
        private Label phone;
        private Label nameOfDirector;
        private Label percent;
        private FlowLayoutPanel flowLayoutPartners;
    }
}
