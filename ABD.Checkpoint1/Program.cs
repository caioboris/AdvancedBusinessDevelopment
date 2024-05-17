// See https://aka.ms/new-console-template for more information

using ABD.Checkpoint1.Models;

ContaCorrente contaCorrente = new("Caio Boris", 15000.0, 30000.0);
ContaSalario contaSalario = new("Ayrton Senna", 2500.0, "Ferrari");

contaCorrente.ExtratoDeSaida.Add(1000.0);
contaCorrente.ExtratoDeSaida.Add(3400.0);
contaCorrente.ExtratoDeSaida.Add(700.0);
contaSalario.ExtratoDeEntrada.Add(500.0);
contaSalario.ExtratoDeEntrada.Add(1500.0);
contaSalario.ExtratoDeEntrada.Add(1000.0);

contaCorrente.TotalSaidas();
contaSalario.TotalEntradas();