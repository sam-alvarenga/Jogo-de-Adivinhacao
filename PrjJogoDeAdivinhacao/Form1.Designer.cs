namespace PrjJogoDeAdivinhacao
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
            lblJogo = new Label();
            lbl = new Label();
            txtNumero = new TextBox();
            btnAdivinhar = new Button();
            SuspendLayout();
            // 
            // lblJogo
            // 
            lblJogo.AutoSize = true;
            lblJogo.Font = new Font("Bernard MT Condensed", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblJogo.Location = new Point(216, 89);
            lblJogo.Name = "lblJogo";
            lblJogo.Size = new Size(328, 44);
            lblJogo.TabIndex = 0;
            lblJogo.Text = "Jogo de Adivinhação";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(251, 161);
            lbl.Name = "lbl";
            lbl.Size = new Size(249, 22);
            lbl.TabIndex = 1;
            lbl.Text = "Inserir um número entre 1 e 100";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = SystemColors.Window;
            txtNumero.ForeColor = Color.Black;
            txtNumero.Location = new Point(335, 202);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 23);
            txtNumero.TabIndex = 2;
            // 
            // btnAdivinhar
            // 
            btnAdivinhar.BackColor = SystemColors.HotTrack;
            btnAdivinhar.FlatStyle = FlatStyle.Popup;
            btnAdivinhar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdivinhar.ForeColor = Color.White;
            btnAdivinhar.Location = new Point(306, 259);
            btnAdivinhar.Name = "btnAdivinhar";
            btnAdivinhar.Size = new Size(137, 34);
            btnAdivinhar.TabIndex = 3;
            btnAdivinhar.Text = "Adivinhar Número";
            btnAdivinhar.UseVisualStyleBackColor = false;
            btnAdivinhar.Click += btnAdivinhar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdivinhar);
            Controls.Add(txtNumero);
            Controls.Add(lbl);
            Controls.Add(lblJogo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJogo;
        private Label lbl;
        private TextBox txtNumero;
        private Button btnAdivinhar;
    }
}