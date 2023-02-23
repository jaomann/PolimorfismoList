class Funcionario
{

    static private int _id = 0;
    private int id { get; set; }
    public int ID { get { return id; } }
    public double salario;
    public string nome;

    public Funcionario(string nome, double salario)
    {
        _id++;
        id = _id;
        this.nome = nome;
        this.salario = salario;
    }
    public virtual string toString()
    {
        return $"Nome: {nome}\n" +
               $"Id: {ID}\n" +
               $"Salario: {salario}";
    }

}