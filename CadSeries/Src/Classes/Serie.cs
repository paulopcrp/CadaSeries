using CadSeries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace CadSeries
    {
        public class Serie : EntidadeBase
        {
            private Genero Genero { get; set; }
            private string Titulo { get; set; }
            private string Descricao  { get; set; }
            private int Ano { get; set; }
            private bool Excluido { get; set; }

        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
            {
                this.Id = Id;
                this.Genero = genero;
                this.Titulo = titulo;
                this.Descricao = descricao;
                this.Ano = ano;
                this.Excluido = false;

            }

            public override string ToString()
            {
                string retorno = "";
                retorno += "Genero: " + this.Genero + Environment.NewLine;
                retorno += "Titulo: " + this.Titulo + Environment.NewLine;
                retorno += "Descricao: " + this.Descricao + Environment.NewLine;
                retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
                return retorno;
            }

            public string retornaTitulo()
            {
                return this.Titulo;
            }

            public int retornaId()
            {
                return this.Id;
            }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }

    }
    }

