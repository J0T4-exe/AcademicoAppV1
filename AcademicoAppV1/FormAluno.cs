using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademicoAppV1
{
    public partial class FormAluno : MaterialForm
    {
        #region Variaveis
        string alunosFilename = "alunos.txt";
        bool isEditMode = false;
        int indexSelecionado = 0;
        #endregion

        #region Métodos
        public FormAluno()
        {
            InitializeComponent();
        }

        private void LimpaCampos()
        {
            isEditMode = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedTextBox)
                    maskedTextBox.Clear();
            }
        }
        private void Salvar()
        {
            var line = $"{txtMatricula.Text};" +
                       $"{txtDataNascimento.Text};" +
                       $"{txtNome.Text};" +
                       $"{txtEndereco.Text};" +
                       $"{txtBairro.Text};" +
                       $"{txtCidade.Text};" +
                       $"{cboEstado.Text};" +
                       $"{txtSenha.Text};";
            if (!isEditMode)
            {
                using (StreamWriter sw = new StreamWriter(alunosFilename, true))
                {
                    sw.WriteLine(line);
                }
            }
            else
            {
                var fileLines = File.ReadAllLines(alunosFilename).ToList();
                fileLines[indexSelecionado] = line;
                File.WriteAllLines(alunosFilename, fileLines);
            }
        }

        private bool ValidaFormulario()
        {
            var erro = "";
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                erro += "Matricula deve ser informada!\n";
            }
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                erro += "Nome deve ser informado!\n";
            }
            if (string.IsNullOrEmpty(txtDataNascimento.Text))
            {
                erro += "Data de nascimento deve ser informada!\n";
            }
            if (!DateTime.TryParse(txtDataNascimento.Text, out _))
            {
                erro += "Data de Nascimento invalida!";
            }
            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                erro += "Endereço deve ser informado!\n";
            }
            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                erro += "Bairro deve ser informada!\n";
            }
            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                erro += "Cidade deve ser informada!\n";
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                erro += "Senha deve ser informada!\n";
            }
            if (!string.IsNullOrEmpty(erro))
            {
                MessageBox.Show(erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void CarregaListView()
        {
            Cursor.Current = Cursors.WaitCursor;
            listViewConsulta.Columns.Clear();
            listViewConsulta.Items.Clear();
            listViewConsulta.Columns.Add("Matricula");
            listViewConsulta.Columns.Add("Data Nasc.");
            listViewConsulta.Columns.Add("Nome");
            listViewConsulta.Columns.Add("Endereço");
            listViewConsulta.Columns.Add("Bairro");
            listViewConsulta.Columns.Add("Cidade");
            listViewConsulta.Columns.Add("Estado");
            listViewConsulta.Columns.Add("Senha");
            var fileLines = File.ReadAllLines(alunosFilename);
            foreach (var line in fileLines)
            {
                var campos = line.Split(";");
                listViewConsulta.Items.Add(new ListViewItem(campos));
            }
            listViewConsulta.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            Cursor.Current = Cursors.Default;
        }

        private void Editar()
        {
            if (listViewConsulta.SelectedIndices.Count > 0)
            {
                isEditMode = true;
                indexSelecionado = listViewConsulta.SelectedItems[0].Index;
                var item = listViewConsulta.SelectedItems[0];
                txtMatricula.Text = item.SubItems[0].Text;
                txtDataNascimento.Text = item.SubItems[1].Text;
                txtNome.Text = item.SubItems[2].Text;
                txtEndereco.Text = item.SubItems[3].Text;
                txtBairro.Text = item.SubItems[4].Text;
                txtCidade.Text = item.SubItems[5].Text;
                cboEstado.Text = item.SubItems[6].Text;
                txtSenha.Text = item.SubItems[7].Text;
                TabControlCadastro.SelectedIndex = 0;
                txtMatricula.Focus();
            }
            else
            {
                MessageBox.Show("Selecione algum registro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Deletar()
        {
            if(listViewConsulta.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("Deseja realmente deletar?", "Pergunta",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    indexSelecionado = listViewConsulta.SelectedItems[0].Index;
                    var fileLines = File.ReadAllLines(alunosFilename).ToList();
                    fileLines.RemoveAt(indexSelecionado);
                    File.WriteAllLines(alunosFilename, fileLines);
                }
                
            }
            
        }
        #endregion

        #region Eventos

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Informações não salvas serão perdidas!\n" + "Deseja realmente cancelar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void listViewConsulta_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Deletar();
        }

        private void tabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaListView();
        }
        #endregion






        
    }
}
