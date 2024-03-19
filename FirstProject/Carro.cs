namespace FirstProject;

public class Carro
{
    public string Modelo { get; set; }
    public DateOnly Lancamento { get; set; }
    public Cor Cor { get; set; }

    public Carro(string modelo, Cor cor)
    {
        Modelo = modelo;
        Cor = cor;
    }

    public void NomeDoModelo()
    {
        Console.WriteLine(Modelo);
        Console.WriteLine(Cor);
    }
}
