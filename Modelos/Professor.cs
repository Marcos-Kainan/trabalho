using System;
using System.Collections.Generic;
namespace Modelos {

     class Professor : Pessoa {
        private string matricula;

        public string Matricula{
            get => this.matricula;
            set{
                if(!String.IsNullOrWhiteSpace(value)){
                 this.matricula=value;
                }
            }
        }
        public override bool Validar( IContato contato){
            return base.Examinar(contato);
        } 

        public void Imprimir(){
                Console.WriteLine("**************************************");
                Console.WriteLine("Professor");
                Console.WriteLine("Nome: "+this.Nome);
                Console.WriteLine("Matricula: "+this.Matricula);
                Console.WriteLine("**************************************");
        }
    }
}