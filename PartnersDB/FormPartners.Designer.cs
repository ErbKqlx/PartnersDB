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
            flowLayoutPartners = new FlowLayoutPanel();
            flowLayoutButtons.SuspendLayout();
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
            buttonAddPartner.TabIndex = 2;
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
            buttonUpdatePartner.TabIndex = 3;
            buttonUpdatePartner.Text = "Редактировать партнера";
            buttonUpdatePartner.UseVisualStyleBackColor = false;
            buttonUpdatePartner.Click += ButtonUpdatePartner_Click;
            // 
            // buttonDeletePartner
            // 
            buttonDeletePartner.BackColor = Color.White;
            buttonDeletePartner.Location = new Point(517, 5);
            buttonDeletePartner.Margin = new Padding(5);
            buttonDeletePartner.Name = "buttonDeletePartner";
            buttonDeletePartner.Size = new Size(319, 58);
            buttonDeletePartner.TabIndex = 4;
            buttonDeletePartner.Text = "Посмотреть истории реализации продукций партнером";
            buttonDeletePartner.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPartners
            // 
            flowLayoutPartners.AutoScroll = true;
            flowLayoutPartners.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPartners.Location = new Point(10, 81);
            flowLayoutPartners.Name = "flowLayoutPartners";
            flowLayoutPartners.Size = new Size(841, 483);
            flowLayoutPartners.TabIndex = 1;
            flowLayoutPartners.WrapContents = false;
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
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutButtons;
        private Button buttonAddPartner;
        private Button buttonUpdatePartner;
        private Button buttonDeletePartner;
        private FlowLayoutPanel flowLayoutPartners;
    }
}
