﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Retiro
{
    public partial class RegistrarForm : Form
    {
        public RegistrarForm()
        {
            InitializeComponent();
                                
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrarVacabutton_Click(object sender, EventArgs e)
        {
            new RetiroDAO().Adicionar(NomeVacatextBox.Text);
            infoRegistroLabel.Text = "Vaca adicionada com sucesso!";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
