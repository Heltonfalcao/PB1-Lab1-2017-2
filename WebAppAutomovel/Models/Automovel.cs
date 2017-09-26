using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppAutomovel.Models
{
    public class Automovel
    {
        public int AutomovelId { get; set; }
        public String Carro { get; set; }
        public String Caminhao { get; set; }
        public String Motocicleta { get; set; }
        public String Descricao { get; set; }
        public String Marca { get; set; }

        private bool disponivel;

        public bool GetDisponivel()
        {
            return disponivel;
        }

        public void SetDisponivel(bool value)
        {
            disponivel = value;
        }

        public DateTime DataDeCadastro { get; set; }


    }




}