using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSeries
{
  public class Serie:EntidadeBase
    {

        
        private Genero Genero { get; set; }
        private string Titulo{get;set;}
        private string Descricao { get; set; }
        private int Ano { get; set; }

        private bool Excluido { get; set; }
        public Serie(int id , Genero genero,string titulo,string descricao,int ano)
        {
            this.Id= id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornoTitulo()
        {
            return this.Titulo;
        }
        public int RetornoId()
        {
            return this.Id;
        }
        public void Excluir()
        {
            this.Excluido = true;
        }
    }
}
