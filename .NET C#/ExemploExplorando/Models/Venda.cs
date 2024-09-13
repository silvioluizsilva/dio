using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }
        // Nome da string era Nome_Produto
        // Altera a string para o padrão C#, usando as propertys
        [JsonProperty("Nome_Produto")]  
        public string Produto { get; set; } 
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}