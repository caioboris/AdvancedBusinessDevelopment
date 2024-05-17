namespace ABD.Checkpoint1.Models;

public abstract class ContaBancaria
{
    protected string NomeTitular { get; set; }
    protected double Saldo { get; set; }
    public List<double> ExtratoDeEntrada { get; set; } = new List<double>();
    public List<double> ExtratoDeSaida { get; set; } = new List<double>();

    public ContaBancaria(string nomeTitular, double saldo)
    {
        NomeTitular = nomeTitular;
        Saldo = saldo;
    }

    public abstract void PagarBoleto(double valor);

}
