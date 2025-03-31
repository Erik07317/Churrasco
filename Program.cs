Console.WriteLine("Vamos fazer um churrasco!");
Console.WriteLine(" Digite quantos adultos não bebem: ");
int adultonaobebe = Convert.ToInt32(Console.ReadLine())!;

Console.WriteLine(" Digite quantos adultos bebem: ");
int adultoQuebebe = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine(" Digite quantas crianças irão: ");
int crianca = Convert.ToInt32(Console.ReadLine())!;

double cerveja, refrigerante, agua, carne, acompanhamento;

cerveja = (adultoQuebebe)*2;
refrigerante = (adultoQuebebe) + (adultonaobebe)*0.05 + (crianca )*0.05;
carne = (adultoQuebebe) + (adultonaobebe ) * 0.04 + (crianca )*0.02;
acompanhamento = (adultoQuebebe) + (adultonaobebe )*0.02 + (crianca )*0.02;
agua =  (adultoQuebebe) + (adultonaobebe )*0.04 + (crianca )*0.04;
Console.WriteLine($"dultos (que consomem bebidas alcoólicas): {adultoQuebebe} ");
Console.WriteLine($"dultos (que não consomem bebidas alcoólicas); {adultonaobebe} ");
Console.WriteLine($"Crianças: {crianca} ");

Console.WriteLine($"Carne: {carne} KG ");
Console.WriteLine($"Acompanhamentos: {acompanhamento} KG");
Console.WriteLine($"Cerveja: {cerveja} L ");
Console.WriteLine($"Refrigerante: {refrigerante} ML");
Console.WriteLine($"Água: {agua} ML");
