namespace NewApp
{
    class FuncionarioPJ : Funcionario
    {

        public double Aumento;
        public double TaxaPJ;
        public FuncionarioPJ(string nome, double salario, double aumento, double taxapj) : base(nome, salario)
        {
            this.nome = nome;
            this.Aumento = aumento;
            this.TaxaPJ = taxapj;
            this.salario = salario - (salario * TaxaPJ / 100) + (salario * Aumento / 100);
        }
        public override string toString()
        {
            return base.toString();
        }
    }
}
