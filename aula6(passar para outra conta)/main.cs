// passar para outra conta
//Console.WriteLine ("Digite o nome do aluno:");
//aluno.Nome = Console.ReadLine();

using Modelos;
using System;
using System.Collections.Generic;

class Aula6
{

    public static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        List<Aluno> alunos = new List<Aluno>();
        List<Professor> professores = new List<Professor>();

        // Não é possível
        // Pessoa pessoa1 = new Pessoa();

        Pessoa pessoa1 = new Aluno();
        Aluno pessoa2 = new Aluno();
        Professor pessoa3 = new Professor();
       
        /* Aqui deu certo pela entrada de dados de forma simples agora fazer teste com função ja formada
        Console.WriteLine ("Digite o nome do aluno:");
        pessoa1.Nome = Console.ReadLine();
        
        Console.WriteLine("Nome: " + pessoa1.Nome);
        */
        pessoas.Add(pessoa1);
        pessoas.Add(pessoa2);

        // Não é possível
        // alunos.Add(pessoa3);

        pessoas.Add(pessoa3);

        alunos.Add(pessoa2);
        professores.Add(pessoa3);


    }
}