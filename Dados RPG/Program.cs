using System;

public class Dados {
    static void Main () {
        int quantidadeDados = 0, faces = 0, resultado = 0;
        
        Console.Write("Indique o número de dados a serem rolados, seguido da letra 'd' e do número de faces do dado, conforme o exemplo: 1d20\n");
        string dado = Console.ReadLine()!;
        
        // Separando em 2 partes: a quantidade de dados e o número de faces
        string[] partes = dado.Split('d');
        
        // Convertendo para int a quantidade de dados e o número de faces
        quantidadeDados = int.Parse(partes[0]);
        faces = int.Parse(partes[1]);

        //Pequeno uso de pausas do programa
        Console.Write("Rodando...\n");
        Thread.Sleep(3000);
        Console.Write("Pronto!\n");
        Thread.Sleep(1500);

        // Gerar a rolagem dos dados
        Random random = new Random();
        for(int i = 0; i < quantidadeDados; i++) {
            int rolagem = random.Next(1, faces + 1);
            resultado += rolagem;
        }

        Console.WriteLine($"Resultado: {resultado}\n");
    }
}
