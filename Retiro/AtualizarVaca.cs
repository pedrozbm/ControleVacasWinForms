using System;
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
    public partial class AtualizarVaca : Form
    {
        public AtualizarVaca()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NomeAtualtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Atualizarbutton_Click(object sender, EventArgs e)
        {
            new RetiroDAO().Atualizar (Convert.ToInt32(NomeAtualtextBox.Text), NomeNovotextBox.Text);

        }
    }
}
