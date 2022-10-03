using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos.Models
{
  public class Pessoas
  {

    public string Nome { get; set; }

    public int Idade { get; set; }
    public string NomeRepresentanteLegal { get; set; }

    public void Apresentar()
    {
      Console.WriteLine($"Olá menu nome é {Nome}, e tenho {Idade} anos," +
       $"meu representante legal é: {NomeRepresentanteLegal}..."); // \n pula linha

    }
  }
}




