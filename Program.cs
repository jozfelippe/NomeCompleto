string nome, sobrenome, sobrenomeEmMaiusculas; 

Console.Write("Digite seu primeiro nome: ");
nome = Console.ReadLine()!;

Console.Write("Digite seu segundo nome: ");
sobrenome = Console.ReadLine()!;

sobrenomeEmMaiusculas = sobrenome.ToUpper();

Console.WriteLine($"Nome completo: {nome} {sobrenome}");

Console.WriteLine($"Nome de catalogo: {sobrenomeEmMaiusculas}, {nome}"); 


