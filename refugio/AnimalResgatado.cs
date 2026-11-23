using System;
using System.Collections.Generic;
using System.Text;

namespace refugio
{
    class AnimalResgatado
    {
        int id;
        string nome;
        int idCategoria;
        string especie;
        string sexo;
        int? idade;
        string situacao;
        string localResgate;
        DateTime? dataResgate;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int IdCategoria { get => idCategoria; set => idCategoria = value; }
        public string Especie { get => especie; set => especie = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int? Idade { get => idade; set => idade = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public string LocalResgate { get => localResgate; set => localResgate = value; }
        public DateTime? DataResgate { get => dataResgate; set => dataResgate = value; }
    }
}
