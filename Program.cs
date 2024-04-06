double percentualDeBonus, percentualDeRetorno;
double pontosATransferir, pontosAReduzir, pontosAAcrescentar;

Console.Clear();
Console.WriteLine("--- Milhas Bumerangue ---\n");

Console.WriteLine("percentual De bonus.....:");
percentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Percentual De Retorno...:");
percentualDeRetorno = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pontos A Transferir.....:");
pontosATransferir = Convert.ToDouble(Console.ReadLine());

pontosAReduzir = pontosATransferir - (pontosATransferir * percentualDeRetorno) / 100;
pontosAAcrescentar = pontosATransferir + (pontosATransferir * percentualDeBonus) / 100;

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"Pontos A Acrescentar no destino...: {pontosAAcrescentar}");

