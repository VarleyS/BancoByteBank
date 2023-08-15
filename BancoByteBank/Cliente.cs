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

        public Cliente(int id, string nome, string cpf, string profissao) 
        {
            ID = id;
            Nome = nome;
            CPF = cpf;
            Profissao = profissao;
        }

        public Cliente() 
        {
        }
    }
}
