using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Escolar.Processo
{
    internal class ProcessoMsg
    {
        public DialogResult DesejaAlterar()
        {
            var desejaAlterar = MessageBox.Show("Já existe um cadastro com essa matricula. Deseja Alterar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return desejaAlterar;
        }
        public DialogResult Salvo()
        {
            var salvo = MessageBox.Show("Salvo!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return salvo;
        }
        public DialogResult Bye()
        {
            var bye = MessageBox.Show("Até logo!", "Bye", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return bye;
        }
        public DialogResult DesejaDeletar()
        {
            var desejaDeletar = MessageBox.Show("Deseja deletar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            return desejaDeletar;
        }
        public DialogResult Cancelado()
        {
            var cancelado = MessageBox.Show("Cancelado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return cancelado;
        }
        public DialogResult Deletado()
        {
            var deletado = MessageBox.Show("Deletado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return deletado;
        }
        public DialogResult Cadastrado()
        {
            var cadastrado = MessageBox.Show("Cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return cadastrado;
        }
        public DialogResult Alterado()
        {
            var alterado = MessageBox.Show("Alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return alterado;
        }
    }
}
