int adultobebe, adultonaobebe, crianca;

double carne, acompanhamento, cerveja, refrigerante, agua;

Console.WriteLine("Calcule a quantidade de itens necessários para um churrasco!");
Thread.Sleep(1000);

Console.Write("Digite a quantidade de adultos que bebem: ");
adultobebe = int.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de adultos que não bebem: ");
adultonaobebe = int.Parse(Console.ReadLine()!);

Console.Write("Digite a quantidade de crianças: ");
crianca = int.Parse(Console.ReadLine()!);

carne = 0.4 * (adultobebe + adultonaobebe) + 0.2 * crianca;

acompanhamento = 0.2 * (adultobebe + adultonaobebe + crianca);

cerveja = 2 * adultobebe;

refrigerante = 0.5 * (adultonaobebe + crianca);

agua = 0.4 * (adultobebe + adultonaobebe + crianca);

Console.Clear();



Console.WriteLine("--- Churrasco ---\n");

Console.WriteLine($"Adultos (que consomem bebidas alcoólicas).......: {adultobebe}");
Console.WriteLine($"Adultos (que não consomem bebidas alcoólicas)...: {adultonaobebe}");
Console.WriteLine($"Crianças........................................: {crianca}\n");

Console.WriteLine($"Carne.............: {carne:N1}kg");
Console.WriteLine($"Acompanhamentos...: {acompanhamento:N1}kg");
Console.WriteLine($"Cerveja...........: {cerveja:N1}l");
Console.WriteLine($"Refrigerante......: {refrigerante:N1}l");
Console.WriteLine($"Água..............: {agua:N1}l");

