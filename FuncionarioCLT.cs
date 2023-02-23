using System;
using System.Collections.Generic;
using System.Text;

namespace NewApp
{
    class FuncionarioCLT : Funcionario
    {
        public double Aumento;
        public double Taxa;
        public FuncionarioCLT(string nome, double salario, double aumento, double taxa) : base(nome, salario) {
            this.nome = nome;
            this.Aumento = aumento;
            this.Taxa = taxa;
            this.salario = salario - (salario * Taxa / 100) + (salario * Aumento / 100);
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
