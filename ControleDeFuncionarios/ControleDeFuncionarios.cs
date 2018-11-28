using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeFuncionarios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(comboCargo.Text == "Assistente Administrativo")
            {
                Administrativo funcionario = new Administrativo(funcionario.Salvar);
                    
                txtFuncionarios.AppendText(funcionario.retornaNome() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaCargo() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaSalario() + "\n");
            }
            else

            if(comboCargo.Text == "Assistente de Designer")
            {
                Designer funcionario = new Designer(Funcionario.Salvar);               

                txtFuncionarios.AppendText(funcionario.retornaNome() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaCargo() + "\t");
                txtFuncionarios.AppendText(funcionario.retornaSalario() + "\n");
            }
        }
    }
}
