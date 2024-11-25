using System;

public class Jogo {
    static void Main() {
        int palpite;
        Random random = new Random();
        int resultado = random.Next(1, 101);
        Console.Write("Qual numero de 1 a 100 eu estou pensando?");
        if(int.TryParse(Console.ReadLine(), out palpite) && palpite >= 1 && palpite <= 100) {
            if(palpite == resultado)
                Console.Write("Acerto Miseravi!\n");
            else
                Console.Write($"Errrrrou!! Eu pensei em {resultado}\n");
        }

        else {
            Console.WriteLine("Ei! Esse valor eh invalido!\n");
        }
    }
}