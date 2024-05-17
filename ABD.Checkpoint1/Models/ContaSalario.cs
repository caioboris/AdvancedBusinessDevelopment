namespace ABD.Checkpoint1.Models;

public class ContaSalario : ContaBancaria
{
    public string Empresa { get; set; }

    public ContaSalario(string nomeTitular, double saldo, string empresa): base(nomeTitular, saldo)
    {
        Empresa = empresa;
    }

    
    public override void PagarBoleto(double valor)
    {
        Console.WriteLine("Você não pode pagar boleto com uma conta salário");
    }

    public void TotalEntradas()
    {
        double total = 0;

        foreach(var item in ExtratoDeEntrada)
        {
            total += item; 
        }

        Saldo += total;

        if(total != 0)
        {
            Console.WriteLine("Bem vindo a consulta de saídas de sua conta corrente, " + NomeTitular + " Valor total depositado: " + total +"\n Saldo: "+ Saldo);
        }
        else
        {
            Console.WriteLine("Não houve depositos");
        }
        
    }



}
