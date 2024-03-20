// 1 -> já fiz

/*
2)
Console.WriteLine("Me diga sua idade!");
int idade = int.Parse(Console.ReadLine()!);
if ( idade >= 18){
  Console.WriteLine("Você é maior de 18 anos!");
} else {
  Console.WriteLine("Você é menor de idade!");
}
*/

// 3 -> já fiz (lista passada)
// 4 -> já fiz (lista passada)

/*
5)
Console.WriteLine("Qual é a senha?");
string? senha = Console.ReadLine();
  if( senha == "IFMSNota5"){
    Console.WriteLine("Senha correta!");
  } else{
    Console.WriteLine("Senha incorreta!");
  }
  */

/*
6) (mesmo código da 8))
Console.WriteLine("Me diga o primeiro número!");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Me diga o segundo número!");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Me diga o terceiro número!");
int num3 = int.Parse(Console.ReadLine()!);
  if (num1 < num2 && num1 < num3){
    if (num2 < num3){
      Console.WriteLine(num1+","+num2+","+num3);
    } else{
      Console.WriteLine(num1+","+num3+","+num2);
    }
  } else if( num2 < num1 && num2 < num3){
    if (num1 < num3){
      Console.WriteLine(num2+","+num1+","+num3);
    } else{
      Console.WriteLine(num2+","+num3+","+num1);
    }
  } else if ( num1 < num2){
      Console.WriteLine(num3+","+num1+","+num2);
  } else{
    Console.WriteLine(num3+","+num2+","+num1);
  }
  */
  
//7
Console.WriteLine("Me fale um valor em reais!");
  double num1 = Convert.ToDouble(Console.ReadLine()!);
Console.WriteLine("Digite qual moeda você quer converter! (dolar, euro, libra)");
  string? operador = Console.ReadLine()!.ToLower();
  double dolar = num1 / 5.03;
  double euro = num1 / 5.47;
  double libra = num1 / 6.40;

      if (operador == "dolar"){
        Console.WriteLine(dolar.ToString("C"));
      } if(operador == "euro"){
        Console.WriteLine(euro.ToString("C"));
      } else if (operador == "libra"){
        Console.WriteLine(libra.ToString("C"));
      }


/*
                    __
         .,-;-;-,. /'_\
       _/_/_/_|_\_\) /
     '-<_><_><_><_>=/\
      `/_/====/_/-'\_\
        ""     ""    ""
        noted by: moonie */