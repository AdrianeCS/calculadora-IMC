double massa, altura, IMC;
string diagnostico;

Console.WriteLine("--massa IMC");

Console.Write("digite seu peso em KG...:");
massa = Convert.ToDouble(Console.ReadLine());

Console.Write("digite sua altura em M...:");
altura = Convert.ToDouble(Console.ReadLine());

IMC = massa / Math.Pow(altura, 2);

Console.WriteLine($"\n seu imc é...: {IMC :N2}kg/m²");

if (IMC < 17)
{
   diagnostico = "muito abaixo do peso";
}
else if (IMC < 18.5)
{ 
  diagnostico = "Abaixo do peso";
}
 else if (IMC< 25)
{ 
   diagnostico = "Peso normal";
}
else if (IMC< 30)
{
  diagnostico = "Acima do peso"; 
}
else if (IMC < 35)
{
diagnostico = "Obesidade I";
}
else if (IMC < 40)
{  
   diagnostico = "Obesidade II (severa)";
}
else
{
diagnostico = "Obesidade III (mórbida)";
}

Console.WriteLine($"Diagnóstico: {diagnostico}");