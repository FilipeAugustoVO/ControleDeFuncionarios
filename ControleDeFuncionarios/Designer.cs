using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeFuncionarios
{
    public class Designer : IFuncionario
    {
        string name, cargo;
        decimal salario;
        private Action<string, string, decimal> salvar;

        public Designer(Action<string, string, decimal> salvar)
        {
            this.salvar = salvar;
        }

        public void Salvar(string name, string cargo, decimal salario)
        {
            throw new NotImplementedException();
        }

        public string retornaNome()
        {
            throw new NotImplementedException();
        }

        public string retornaCargo()
        {
            throw new NotImplementedException();
        }

        public string retornaSalario()
        {
            throw new NotImplementedException();
        }
    }
}
