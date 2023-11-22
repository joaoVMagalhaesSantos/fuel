namespace Fuel
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
            components = new System.ComponentModel.Container();
            btnVpower = new Button();
            btnComum = new Button();
            btnEtanol = new Button();
            txtValPag = new TextBox();
            txtLtAbast = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            txtVpower = new TextBox();
            label5 = new Label();
            panel3 = new Panel();
            txtComum = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            txtEtanol = new TextBox();
            label7 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // btnVpower
            // 
            btnVpower.BackColor = Color.Red;
            btnVpower.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVpower.ForeColor = SystemColors.HighlightText;
            btnVpower.Location = new Point(32, 233);
            btnVpower.Name = "btnVpower";
            btnVpower.Size = new Size(107, 35);
            btnVpower.TabIndex = 0;
            btnVpower.Text = "V-Power";
            btnVpower.UseVisualStyleBackColor = false;
            btnVpower.Click += btnVpower_Click;
            // 
            // btnComum
            // 
            btnComum.BackColor = Color.Yellow;
            btnComum.Font = new Font("Verdana", 6F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComum.ForeColor = Color.Red;
            btnComum.Location = new Point(145, 233);
            btnComum.Name = "btnComum";
            btnComum.Size = new Size(107, 35);
            btnComum.TabIndex = 1;
            btnComum.Text = "Gasolina Comum";
            btnComum.UseVisualStyleBackColor = false;
            btnComum.Click += btnComum_Click;
            // 
            // btnEtanol
            // 
            btnEtanol.BackColor = Color.ForestGreen;
            btnEtanol.Font = new Font("Verdana", 6.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEtanol.ForeColor = SystemColors.ButtonHighlight;
            btnEtanol.Location = new Point(258, 233);
            btnEtanol.Name = "btnEtanol";
            btnEtanol.Size = new Size(107, 35);
            btnEtanol.TabIndex = 2;
            btnEtanol.Text = "Etanol Comum";
            btnEtanol.UseVisualStyleBackColor = false;
            btnEtanol.Click += btnEtanol_Click;
            // 
            // txtValPag
            // 
            txtValPag.Location = new Point(133, 29);
            txtValPag.Name = "txtValPag";
            txtValPag.Size = new Size(114, 22);
            txtValPag.TabIndex = 3;
            txtValPag.TextAlign = HorizontalAlignment.Center;
            // 
            // txtLtAbast
            // 
            txtLtAbast.Location = new Point(133, 52);
            txtLtAbast.Name = "txtLtAbast";
            txtLtAbast.Size = new Size(114, 22);
            txtLtAbast.TabIndex = 4;
            txtLtAbast.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(138, 13);
            label1.Name = "label1";
            label1.Size = new Size(102, 14);
            label1.TabIndex = 5;
            label1.Text = "TOTAL A PAGAR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(103, 33);
            label2.Name = "label2";
            label2.Size = new Size(23, 14);
            label2.TabIndex = 6;
            label2.Text = "R$";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlText;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtValPag);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtLtAbast);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(371, 105);
            panel1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(165, 76);
            label3.Name = "label3";
            label3.Size = new Size(52, 14);
            label3.TabIndex = 8;
            label3.Text = "LITROS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(142, 139);
            label4.Name = "label4";
            label4.Size = new Size(121, 14);
            label4.TabIndex = 8;
            label4.Text = "PREÇO POR LITRO";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtVpower);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(32, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(107, 63);
            panel2.TabIndex = 9;
            // 
            // txtVpower
            // 
            txtVpower.Location = new Point(2, 35);
            txtVpower.Name = "txtVpower";
            txtVpower.Size = new Size(101, 22);
            txtVpower.TabIndex = 1;
            txtVpower.Text = "5,59";
            txtVpower.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 11);
            label5.Name = "label5";
            label5.Size = new Size(23, 14);
            label5.TabIndex = 0;
            label5.Text = "R$";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(txtComum);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(145, 164);
            panel3.Name = "panel3";
            panel3.Size = new Size(107, 63);
            panel3.TabIndex = 10;
            // 
            // txtComum
            // 
            txtComum.Location = new Point(2, 35);
            txtComum.Name = "txtComum";
            txtComum.Size = new Size(101, 22);
            txtComum.TabIndex = 1;
            txtComum.Text = "5,39";
            txtComum.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 11);
            label6.Name = "label6";
            label6.Size = new Size(23, 14);
            label6.TabIndex = 0;
            label6.Text = "R$";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(txtEtanol);
            panel4.Controls.Add(label7);
            panel4.Location = new Point(258, 164);
            panel4.Name = "panel4";
            panel4.Size = new Size(107, 63);
            panel4.TabIndex = 11;
            // 
            // txtEtanol
            // 
            txtEtanol.Location = new Point(2, 35);
            txtEtanol.Name = "txtEtanol";
            txtEtanol.Size = new Size(101, 22);
            txtEtanol.TabIndex = 1;
            txtEtanol.Text = "3,64";
            txtEtanol.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 11);
            label7.Name = "label7";
            label7.Size = new Size(23, 14);
            label7.TabIndex = 0;
            label7.Text = "R$";
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(400, 298);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(btnVpower);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnEtanol);
            Controls.Add(btnComum);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "Form1";
            Text = "Shell";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVpower;
        private Button btnComum;
        private Button btnEtanol;
        private TextBox txtValPag;
        private TextBox txtLtAbast;
        private Label label1;
        private Label label2;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Label label5;
        private TextBox txtVpower;
        private Panel panel3;
        private TextBox txtComum;
        private Label label6;
        private Panel panel4;
        private TextBox txtEtanol;
        private Label label7;
        private System.Windows.Forms.Timer timer1;
    }
}
