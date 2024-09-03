using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propriedades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvAlunos.RowCount = 0;

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            dgvAlunos.Rows.Add(txtNome.Text, txtCurso.Text);

            txtNome.Clear();

            
            txtCurso.Clear();

            MessageBox.Show("Aluno Incluido com sucesso", "Inclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            lblTotal.Text = dgvAlunos.RowCount.ToString();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvAlunos.Rows.Count > 0)
            {

                dgvAlunos.Rows.RemoveAt(dgvAlunos.CurrentRow.Index);

                MessageBox.Show("Alunos Excluido com sucesso", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                lblTotal.Text = dgvAlunos.RowCount.ToString();
            }
        }

        private void dgvAlunos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAlunos.RowCount > 0)
            {

                txtAlteracao.Text = dgvAlunos.CurrentRow.Cells[0].Value.ToString(); 

            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtAlteracao.Text != "")
            {
                dgvAlunos.CurrentRow.Cells[0].Value = txtAlteracao.Text; 

                MessageBox.Show("Aluno alterado com sucesso", "Alterado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);    
            }

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
