using System;

public class Item{
    public string nome = string.Empty;
    public Boolean concluido;
}
public class Lista {

    static void Main () {
        List<Item> itemList = new List<Item>();
        int escolha1 = 0;
        int escolha2 = 0;
        while(escolha1 != 4) {
            //Menu de Escolhas
            Console.Write("============\nLISTA DE TAREFAS\n============\n");
            Console.Write("1-Adicionar item a lista\n");
            Console.Write("2-Manipular Lista\n");
            Console.Write("3-Ver Lista\n");
            Console.Write("4-Sair\n");
            if(int.TryParse(Console.ReadLine(), out escolha1)) {
                switch(escolha1) {
                    case 1:
                        //Adicionando Item
                        Item item = new Item();
                        Console.Write("Digite o item:\n");
                        item.nome = Console.ReadLine()!;
                        item.concluido = false;
                        //Por padrão o item na lista não está concluido
                        itemList.Add(item);
                        break;

                    case 2:
                        //Segundo Menu de Escolhas
                        Console.Write("1-Remover item\n");
                        Console.Write("2-Marcar como concluido\n");

                        if(int.TryParse(Console.ReadLine(), out escolha2)) {
                            switch(escolha2) {
                                case 1:
                                    //Remove a partir da posição
                                    Console.Write("Digite a posicao a ser removida:\n");
                                    int pos = int.Parse(Console.ReadLine()!);
                                    itemList.RemoveAt(pos); 
                                    break;
                                case 2:
                                    //A partir da posição, altera o status de não concluido para concluido
                                    Console.Write("Digite a posicao do item concluido:\n");
                                    pos = int.Parse(Console.ReadLine()!);
                                    itemList[pos].concluido = true;
                                    break;
                                default:
                                    Console.Write("Erro! Valor invalido\n");
                                    break;
                            }
                        }
                        else {
                            Console.Write("Erro! Valor invalido\n");
                        }
                        break;
                    case 3:
                        //Lista das Tarefas
                        for(int i = 0; i < itemList.Count; i++) {
                            Console.Write($"{itemList[i].nome}\n");
                            if(itemList[i].concluido == true)
                                Console.WriteLine("Concluido\n");
                            else
                                Console.WriteLine("Nao Concluido\n");
                        }
                        break;

                    case 4:
                        break;
                    
                    default:
                        Console.Write("Erro! Escolha invalida\n");
                        break;
                }
            }
            else {
                Console.Write("Erro! Valor invalido\n");
            }
        }
    }
}