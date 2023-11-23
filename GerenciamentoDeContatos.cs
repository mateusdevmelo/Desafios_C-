using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        while (true)
        {

            string nome = Console.ReadLine();


            string email = Console.ReadLine();


            string telefone = Console.ReadLine();

            Console.WriteLine("Contato adicionado!");
            Console.WriteLine($"Nome: {nome}\n E-mail: {email}\n Tel: {telefone}");
            
            
            break;
        }
    }
}



/*Descrição
O Dynamics 365 é uma poderosa ferramenta de gerenciamento de relacionamento com o cliente usada por empresas para rastrear, armazenar e interagir com contatos, como clientes, leads e parceiros de negócios. Sua tarefa é criar um programa que permita a um usuário adicionar informações de contato ao Dynamics 365 e classificar esses contatos em categorias específicas

Entrada
A entrada deverá ser realizada através do Console.ReadLine(), recebendo as seguintes informações:

Nome do contato (uma string).
Endereço de e-mail do contato (uma string).
Número de telefone do contato (uma string).
Saída
A saída deverá retornar um texto informando:

A Confirmação de que o contato foi adicionado com sucesso.
Exibição das informações do contato, incluindo nome, endereço de e-mail e número de telefone.
Exemplos
A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

Entrada	Saída
Joao
j@dio.com
123432	Contato adicionado!
Nome: Joao
E-mail: j@dio.com
Tel: 123432
Ana
ana@email.com
010101	Contato adicionado!
Nome: Ana
E-mail: ana@email.com
Tel: 010101
Rafa
rafa@dio.com
555000	Contato adicionado!
Nome: Rafa
E-mail: rafa@dio.com
Tel: 555000*/