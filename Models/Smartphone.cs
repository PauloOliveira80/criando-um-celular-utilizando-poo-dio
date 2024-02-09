using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace ProjetoCelularPOO.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number, string model, string imei, string memory){
            Number = number;
            Model = model;
            imei = Imei;
            Memory = memory;
        }

        public string Number { get; set; }
        private string Model {get; set;}
        private string Imei { get; set; }
        private string Memory { get; set; }

        public void Call(string nuumber){
            if (nuumber != Number){
                Console.WriteLine($"Ligando para {nuumber}");
            }
            else{
                Console.WriteLine("Ocorreu um erro, o número não pode ser o mesmo!");
            }
        }
        public void ReceberLigação(){
            Console.WriteLine("Você está recebendo uma ligação!");
        }
        public abstract void InstalarAplicativo(string nomeAplicativo);
    }
    }

  
