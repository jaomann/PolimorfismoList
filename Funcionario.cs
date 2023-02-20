class Funcionario
{

    static private int _id = 0;
    private int id { get; set; }
    public int ID { get { return id; } }
    public double salario;
    public string nome;
    public Funcionario(string nome, double salario)
    {
        _id += 1;
        id = _id;

        this.nome = nome;
        this.salario = salario;
    }

}