using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retiro
{
    public partial class FormDados : Form
    {
        public FormDados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDados_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarForm form = new RegistrarForm();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //executa o método e coloca os dados na variável
            var dados = new RetiroDAO().ListarTodas();
            //conta os registros e coloca no label
            quantidadeLabel.Text = $"Registros encontrados: {dados.Rows.Count}";
            //joga os dados no grid
            ListdataGridView.DataSource = dados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DeletarButton_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Confirma a exclusão da Vaca?", ProductName,
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //pega o id da linha selecionada no grid
                    int id = Convert.ToInt32(ListdataGridView.SelectedRows[0].Cells["IDVaca"].Value);
                    //executa a exclusão
                    new RetiroDAO().Excluir(id);
                    //executa a busca novamente, como se tivesse clicado no botão
                    Buscarbutton.PerformClick();
                    //avisa o usuário
                    MessageBox.Show("Vaca excluída com sucesso!", ProductName,
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void atualizarVacasToolStripMenuItem_Click(object sender, EventArgs e)
        {
          AtualizarVaca atualizar = new AtualizarVaca();
            atualizar.Show();
        }
    }
}
