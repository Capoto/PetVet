using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetVet.Models
{
    public class Dados
    {
        public static ListaAgendamento Registro { get; set;}
        static Dados(){
       
                Registro = new ListaAgendamento();
            }
    }
}