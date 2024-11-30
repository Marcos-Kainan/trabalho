using System;
using System.Collections.Generic;

namespace Modelos {

    class Aluno : Pessoa {

      private string matricula;
      private int periodo;
      public List<Historico> historicos = new List<Historico>();

      public Familiar Familiar {get; set;}

      public int Periodo {
        get => this.periodo;
        set {
          if (value > 0) {
            this.periodo = value;
          } else {
            this.periodo = 1;
          }
        }
      }

      public string Matricula {
        get => this.matricula;
        set {
          if(!String.IsNullOrWhiteSpace(value)) {
            this.matricula = value;
          }
        }
      }

      public Aluno() : this(1) {
      }

      public Aluno(int periodo) {
        this.Periodo = periodo;
      }

      public Aluno(int periodo, string matricula) 
        : this(periodo) {
       this.Matricula = matricula;
      }

      ~Aluno() {
        foreach (Historico historico in historicos) {
          historicos.Remove(historico);
        }
      }

      public override bool Investigar(IContato contato) {
        return contato.Informar() != Familiar.Informar();
      }

      public override bool Validar(IContato contato) {
        return this.Investigar(contato) && base.Examinar(contato);
      }

      public void Imprimir() {
        Console.WriteLine("*************************");
        Console.WriteLine("Aluno");
        Console.WriteLine("Nome: " + this.Nome);
        Console.WriteLine("Matricula: " + this.Matricula);
        Console.WriteLine("Periodo: " + this.Periodo);
        foreach(Historico historico in historicos) {
          historico.Imprimir();
        }
        Console.WriteLine("*************************");
      }
    }

}