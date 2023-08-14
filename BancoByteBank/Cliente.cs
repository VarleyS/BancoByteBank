using System;
using System.Collections.Generic;
using System.Text;

namespace BancoByteBank
{
    public class Cliente
    {
        public int ID {  get; set; } = new int();
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao) 
        {
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }

        public Cliente() 
        {
        }
    }
}
