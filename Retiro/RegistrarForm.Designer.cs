namespace Retiro
{
    partial class RegistrarForm
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
            this.NomeVacatextBox = new System.Windows.Forms.TextBox();
            this.Registrolabel = new System.Windows.Forms.Label();
            this.NomeVacalabel = new System.Windows.Forms.Label();
            this.Infolabel = new System.Windows.Forms.Label();
            this.RegistrarVacabutton = new System.Windows.Forms.Button();
            this.infoRegistroLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NomeVacatextBox
            // 
            this.NomeVacatextBox.Location = new System.Drawing.Point(161, 74);
            this.NomeVacatextBox.Name = "NomeVacatextBox";
            this.NomeVacatextBox.Size = new System.Drawing.Size(161, 22);
            this.NomeVacatextBox.TabIndex = 0;
            this.NomeVacatextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Registrolabel
            // 
            this.Registrolabel.AutoSize = true;
            this.Registrolabel.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrolabel.Location = new System.Drawing.Point(12, 9);
            this.Registrolabel.Name = "Registrolabel";
            this.Registrolabel.Size = new System.Drawing.Size(305, 33);
            this.Registrolabel.TabIndex = 1;
            this.Registrolabel.Text = "Insira os dados da nova vaca";
            this.Registrolabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Registrolabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NomeVacalabel
            // 
            this.NomeVacalabel.AutoSize = true;
            this.NomeVacalabel.Location = new System.Drawing.Point(53, 77);
            this.NomeVacalabel.Name = "NomeVacalabel";
            this.NomeVacalabel.Size = new System.Drawing.Size(102, 16);
            this.NomeVacalabel.TabIndex = 2;
            this.NomeVacalabel.Text = "Nome da vaca: ";
            // 
            // Infolabel
            // 
            this.Infolabel.AutoSize = true;
            this.Infolabel.Location = new System.Drawing.Point(182, 129);
            this.Infolabel.Name = "Infolabel";
            this.Infolabel.Size = new System.Drawing.Size(12, 16);
            this.Infolabel.TabIndex = 3;
            this.Infolabel.Text = "*";
            // 
            // RegistrarVacabutton
            // 
            this.RegistrarVacabutton.Location = new System.Drawing.Point(145, 113);
            this.RegistrarVacabutton.Name = "RegistrarVacabutton";
            this.RegistrarVacabutton.Size = new System.Drawing.Size(116, 32);
            this.RegistrarVacabutton.TabIndex = 4;
            this.RegistrarVacabutton.Text = "Registrar";
            this.RegistrarVacabutton.UseVisualStyleBackColor = true;
            this.RegistrarVacabutton.Click += new System.EventHandler(this.RegistrarVacabutton_Click);
            // 
            // infoRegistroLabel
            // 
            this.infoRegistroLabel.AutoSize = true;
            this.infoRegistroLabel.Location = new System.Drawing.Point(201, 172);
            this.infoRegistroLabel.Name = "infoRegistroLabel";
            this.infoRegistroLabel.Size = new System.Drawing.Size(0, 16);
            this.infoRegistroLabel.TabIndex = 5;
            this.infoRegistroLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // RegistrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 242);
            this.Controls.Add(this.infoRegistroLabel);
            this.Controls.Add(this.RegistrarVacabutton);
            this.Controls.Add(this.Infolabel);
            this.Controls.Add(this.NomeVacalabel);
            this.Controls.Add(this.Registrolabel);
            this.Controls.Add(this.NomeVacatextBox);
            this.Name = "RegistrarForm";
            this.Text = "Registrar nova vaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeVacatextBox;
        private System.Windows.Forms.Label Registrolabel;
        private System.Windows.Forms.Label NomeVacalabel;
        private System.Windows.Forms.Label Infolabel;
        private System.Windows.Forms.Button RegistrarVacabutton;
        private System.Windows.Forms.Label infoRegistroLabel;
    }
}