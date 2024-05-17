namespace ABD.Checkpoint1.Models;

public class ContaCorrente : ContaBancaria
{
    public double ChequeEspecial { get; set; }

    public ContaCorrente(string nomeTitular, double saldo, double cheque) : base(nomeTitular, saldo)
    {
        ChequeEspecial = cheque;
    }

    public override void PagarBoleto(double valor)
    {
        if (Saldo > valor)
        {
            Console.WriteLine("Pagamento realizado");
        }
        else
        {
            Console.WriteLine("Não há saldo suficiente");
        }
    }

    public void TotalSaidas()
    {
        double total = 0;

        for(int i=0; i < ExtratoDeSaida.Count; i++)
        {
            total += ExtratoDeSaida[i];
        }

        Saldo -= total;

        Console.WriteLine("Bem vindo a consulta de saídas de sua conta corrente, "+ NomeTitular +" Valor total gasto: " + total + "\n Saldo: " + Saldo);
    }



}
