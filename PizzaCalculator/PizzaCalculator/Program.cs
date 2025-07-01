int pesoMasaTotal;
double hidratacionPorcentaje = 70;
double bigaPorcentaje = 20.83;
Console.Write("Ingrese el peso de la masa en gramos: ");
pesoMasaTotal = int.Parse(Console.ReadLine() ?? "0");

double harina = pesoMasaTotal / (1 + (hidratacionPorcentaje / 100));
double agua = pesoMasaTotal - harina;

double harinaBiga = Math.Round(harina * (bigaPorcentaje / 100));
double harinaFinal = Math.Round(harina - harinaBiga);

double aguaBiga = Math.Round(harinaBiga * 0.5);
double aguaFinal = Math.Round(agua - aguaBiga);

double sal = Math.Round(harina * 0.02);

Console.WriteLine($"Para una masa de Pizza de: {pesoMasaTotal} gr\n");
Console.WriteLine($"Para la biga:");
Console.WriteLine($"Harina: {harinaBiga} gr\nAgua: {aguaBiga} gr\nLevadura: Pizca\n");

Console.WriteLine($"Para la masa final");
Console.WriteLine($"Harina: {harinaFinal} gr\nAgua: {aguaFinal} gr\nSal: {sal} gr\nLevadura: Pizca");

Console.WriteLine("Consejos:\nBiga fermentación 24h en el refrigerador.\nMasa fermenteación 12-24h en el refrigerador.\nBollos fermentación 3-4h temperatura ambiente.");
