using System;
using System.Collections.Generic;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            * LISTAS É UMA ESTRUTURA DE DADOS:
            - Homogênia (dados do mesmo tipo)
            - Ordenada (Elementos acessados por meio de posições)
            - Iniciada Vazia, e seus elementos são alocados sob demanda.
            - Cada elemento ocupa um "nó"(ou nodo) da lista.
            
            * Esse nameespace é obrigatório para que funcione a List:
            Nameespace: System.Collections.Generic

            * VANTAGENS:
            - Tamanho variável.
            - Facilidade para se realizar inserções e deleções.

            * DESVANTAGENS:
            - Acesso sequencial aos elementos.
             */

            /*Essa é maneira de declarar a lista e instância-la:*/
            List<string> list1 = new List<string>();
            /*Nesse exemplo simples foi instânciada uma lista vazia, mas
             vale resaltar que na linguagem C# é possível declara-la,
            instância-la e já tribuir valores a ela, exemplo:*/
            List<string> list2 = new List<string> { "Maria", "Alex", "Bob" };

            /*
            * COMANDOS DE LIST
            - Inserir elemento na lista: Add, Insert
            - Tamanho da lista: Count
            - Encontrar primeiro ou último elementos da lista que
            satisfaça um predicado: list.Find, list.FindLast
            - Encontrar primeira ou última posição de elemento da lista que
            satisfaça um predicado: list.FindIdex, list.FindLastIndex
            - Filtrar a lista com base em um predicado: list.FindAll
            - Remover elementos da lista: Remove, RemoveAll, RemoveAt, RemoveRange

            * ASSUNTOS PENDENTES ENVOLVIDOS:
            - Generics
            - Predicados (lambda)
             */

            list1.Add("Maria"); /*O comando "Add" Adiciona o elemento na
                                  lista, sempre na última posição da lista
                                  de forma sequencial*/
            list1.Add("Alex");
            list1.Add("Bob");
            list1.Add("Anna");
            list1.Add("David");
            list1.Add("Adriana");
            list1.Add("Reginaldo");


            foreach (string obj in list1)/*Imprime os elementos da lista*/
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            list1.Insert(2, "Marco"); /*O comando "Insert" Adiciona um
            elemento na posição que for especificada, nesse exemplo foi
            na posição 2. Lembrando que como no vertor, a primeira
            posição começa na posição 0*/

            foreach (string obj in list1)/*Imprime os elementos da lista*/
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            Console.WriteLine("Tamando da lista: " + list1.Count);/*O comando "Count"
            mostra o tamanho atual da lista*/

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string s1 = list1.Find(x => x[0] == 'A'); /*O comando Find espera um PREDICADO como
            argumento, esse PREDICADO é uma função e tem haver com o assunto
            pendente LAMBDA. O conceito de PREDICADO é uma função que pega um
            valor e retorna verdadeiro ou falso conforme a lógica implementada
            na função, não sendo obrigatório a criação da função separadamente
            para que funcione o teste, entrando o assundo da função LAMBDA que
            faz o teste automaticamente.
            A expressão LAMBDA se le da seguinte forma: x => x[0] == 'A'
            x que é um elemento, tal que x na posição 0 (primeiro posição que satisfaça a condição
            a seguir) é igual ao A. Sendo o "s" um parâmetro de entrada para o teste lambda.
            Esse expressão LAMBDA resumida de teste de uma condição é chamada de expressão anõnima
            sendo uma forma simples de definir uma fuñção de teste sem a necessidade de criar
            uma função separadamente para testar a lógica.*/

            /*static bool Test(string s) Função que irá retornar um booleano
                                        (verdadeiro), somente se a condição
                                        especificada for verdadeira, seria
                                        necessario criar essa função se não
                                        fosse utilizada a função LAMBDA.
            {
                return s[0] == 'A';
            }*/

            Console.WriteLine("Primeiro Elemento da lista que começa com A: " + s1);

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            string s2 = list1.FindLast(x => x[0] == 'A'); /*Mesmo conceito do exemplo acima
            porém com a diferença que o comando Find.Last retorna o último valor que atenda a
            condição especificada na função LAMBDA*/

            Console.WriteLine("Último Elemento da lista que começa com A: " + s2);

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            int pos1 = list1.FindIndex(x => x[0] == 'M'); /*O comando FindIndex retorna a primeira
            posição que satisfaça a condição da função LAMBDA*/

            Console.WriteLine("Primeira posição da lista que começa com M: " + pos1);

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            int pos2 = list1.FindLastIndex(x => x[0] == 'M'); /*Mesmo conceito do exemplo acima
            porém com a diferença que o comando Find.LastIndex retorna o último valor que atenda a
            condição especificada na função LAMBDA*/

            Console.WriteLine("Última posição da lista que começa com M: " + pos2);

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            List<string> list3 = list1.FindAll(x => x.Length == 5); /*O comando FindAll é utilizado
            para filtrar a lista contendo apenas os elementos que satisfaca o predicado especificado
            na função LAMBDA acima. Ou seja é possível criar uma nova lista que possibilita incluir
            apenas os elementos que satisfaçam o pridicado da função LAMBDA. No exemplo foi filtrado
            apenas os elemento que possui 5 caracteres de tamanho(Length).*/

            Console.WriteLine("Nova lista que possui os elementos com 5 caracteres: ");
            Console.WriteLine();

            foreach (string obj in list3) //Percorre todos os elementos da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            list1.Remove("Alex"); /*O comando Remove remove o elemento especificado nos parâmetros da lista em questão*/

            Console.WriteLine("Nova lista que removeu o elemento especificado no comando Remove: ");
            Console.WriteLine();

            foreach (string obj in list1) //Percorre todos os elementos da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            list1.RemoveAll(x => x[0] == 'M'); /*O comando RemoveAll espera como parâmetro um predicado e ele remove
            todos os elementos que atendam a condição da função LAMBDA do predicado. Vale ressaltar que
            se for definido para remover um elemento que não existe na lista, o comando simplismente não
            fará nenhuma modificação.*/

            Console.WriteLine("Nova lista que removeu todos os elementos que atendeu o pridicado especificado do comando RemoveAll: ");
            Console.WriteLine();

            foreach (string obj in list1) //Percorre todos os elementos da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            list1.RemoveAt(1); /*O comando RemoveAt remove um elemento pela posição dele que ele se e
            não pelo seu valor */

            Console.WriteLine("Nova lista que removeu o elemento da posição especificada no comando RemoveAt: ");
            Console.WriteLine();

            foreach (string obj in list1) //Percorre todos os elementos da lista
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();

            list1.RemoveRange(1, 2); /*O comando RemoveRange remove um elemento pela faixa, ele espera como parâmetro a
            posição que será inciada a remoção e uma contagem de quantos elementos serão removidos.*/

            Console.WriteLine("Nova lista que removeu os elementos apartir da posição especificada no comando RemoveRange: ");
            Console.WriteLine();

            foreach (string obj in list1) //Percorre todos os elementos da lista
            {
                Console.WriteLine(obj);
            }

        }
    }
}
