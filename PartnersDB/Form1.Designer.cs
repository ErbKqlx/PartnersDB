namespace PartnersDB
{
    partial class Form1
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonAddPartner = new Button();
            buttonUpdatePartner = new Button();
            buttonDeletePartner = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(buttonAddPartner);
            flowLayoutPanel1.Controls.Add(buttonUpdatePartner);
            flowLayoutPanel1.Controls.Add(buttonDeletePartner);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(10, 10);
            flowLayoutPanel1.Margin = new Padding(5);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(841, 71);
            flowLayoutPanel1.TabIndex = 0;
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
            buttonDeletePartner.Size = new Size(246, 58);
            buttonDeletePartner.TabIndex = 2;
            buttonDeletePartner.Text = "Удалить партнера";
            buttonDeletePartner.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 131);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Location = new Point(709, 15);
            label5.Name = "label5";
            label5.Size = new Size(49, 28);
            label5.TabIndex = 4;
            label5.Text = "10%";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(20, 93);
            label4.Name = "label4";
            label4.Size = new Size(278, 25);
            label4.TabIndex = 3;
            label4.Text = "Рейтинг: 10";
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(20, 68);
            label3.Name = "label3";
            label3.Size = new Size(278, 25);
            label3.TabIndex = 2;
            label3.Text = "+7 223 322 22 32";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(20, 43);
            label2.Name = "label2";
            label2.Size = new Size(278, 25);
            label2.TabIndex = 1;
            label2.Text = "Директор";
            // 
            // label1
            // 
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(278, 28);
            label1.TabIndex = 0;
            label1.Text = "Тип | Наименование партнера";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 574);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Padding = new Padding(10);
            Text = "Партнеры";
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonAddPartner;
        private Button buttonUpdatePartner;
        private Button buttonDeletePartner;
        private Panel panel1;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}
