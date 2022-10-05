using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
  /// <summary>
  /// Representa uma Pessoa Fisíca
  /// </summary>
  public class Pessoa
  {

    public string? Nome { get; set; }

    public int Idade { get; set; }
    public string? NomeRepresentanteLegal { get; set; }

    /// <summary>
    /// Faz a pessoa apresentar, dizendo Nome e Idade
    /// </summary>
    public void Apresentar()
    {
      Console.WriteLine($"Olá menu nome é {Nome}, e tenho {Idade} anos," +
       $"meu representante legal é: {NomeRepresentanteLegal}..."); // \n pula linha

    }
  }
}




