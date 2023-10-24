namespace Retiro
{
    partial class AtualizarVaca
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
            this.NomeAtualtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Atualizarbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeNovotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NomeAtualtextBox
            // 
            this.NomeAtualtextBox.Location = new System.Drawing.Point(138, 67);
            this.NomeAtualtextBox.Name = "NomeAtualtextBox";
            this.NomeAtualtextBox.Size = new System.Drawing.Size(274, 22);
            this.NomeAtualtextBox.TabIndex = 0;
            this.NomeAtualtextBox.TextChanged += new System.EventHandler(this.NomeAtualtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID da vaca";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Atualizarbutton
            // 
            this.Atualizarbutton.Location = new System.Drawing.Point(337, 183);
            this.Atualizarbutton.Name = "Atualizarbutton";
            this.Atualizarbutton.Size = new System.Drawing.Size(75, 23);
            this.Atualizarbutton.TabIndex = 2;
            this.Atualizarbutton.Text = "Atualizar";
            this.Atualizarbutton.UseVisualStyleBackColor = true;
            this.Atualizarbutton.Click += new System.EventHandler(this.Atualizarbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Novo nome";
            // 
            // NomeNovotextBox
            // 
            this.NomeNovotextBox.Location = new System.Drawing.Point(138, 144);
            this.NomeNovotextBox.Name = "NomeNovotextBox";
            this.NomeNovotextBox.Size = new System.Drawing.Size(274, 22);
            this.NomeNovotextBox.TabIndex = 4;
            // 
            // AtualizarVaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 251);
            this.Controls.Add(this.NomeNovotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Atualizarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NomeAtualtextBox);
            this.Name = "AtualizarVaca";
            this.Text = "AtualizarVaca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NomeAtualtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Atualizarbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeNovotextBox;
    }
}