namespace Fuel
{
    partial class Controller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtValSel = new TextBox();
            txtLitSel = new TextBox();
            button1 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "R$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Litros";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // txtValSel
            // 
            txtValSel.Location = new Point(61, 36);
            txtValSel.Name = "txtValSel";
            txtValSel.Size = new Size(100, 23);
            txtValSel.TabIndex = 3;
            txtValSel.KeyPress += txtValSel_KeyPress;
            txtValSel.Leave += txtValSel_Leave;
            // 
            // txtLitSel
            // 
            txtLitSel.Location = new Point(61, 63);
            txtLitSel.Name = "txtLitSel";
            txtLitSel.Size = new Size(100, 23);
            txtLitSel.TabIndex = 4;
            txtLitSel.KeyPress += txtLitSel_KeyPress;
            txtLitSel.Leave += txtLitSel_Leave;
            // 
            // button1
            // 
            button1.Location = new Point(35, 105);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 5;
            button1.Text = "Iniciar abastecimento";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 32);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 6;
            label4.Text = "label4";
            // 
            // Controller
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(210, 140);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(txtLitSel);
            Controls.Add(txtValSel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Controller";
            Text = "Controller";
            Load += Controller_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtValSel;
        private TextBox txtLitSel;
        private Button button1;
        private Label label4;
    }
}