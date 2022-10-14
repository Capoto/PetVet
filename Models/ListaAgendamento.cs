using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetVet.Models
{
    public class ListaAgendamento
    {
        private static List<Agendamento>  Lista = new  List<Agendamento>();


        public  void Adiciconar(Agendamento agendar){

                Lista.Add(agendar);

        }

        public  List<Agendamento>  Listar(){


            return Lista;
         }


    }
}