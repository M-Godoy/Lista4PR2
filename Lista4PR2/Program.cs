using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista4PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //atividade 1

            //Console.WriteLine("A afirmativa é falsa, pois quando se tem uma variável float o valor a ser atribuído para ela pode conter números com casas decimais, " +
            //    "enquanto uma variável do tipo int recebe apenas números inteiros;");
            //Console.WriteLine("A afirmativa será verdadeira se e somente se o valor da variável float tiver as casas decimais iguais a zero, " +
            //    "exixtem códigos na qual faz isso se totnar possível, desde aproximação até excluir as casas decimais;" +
            //    "para testar podemos tentar fazer o código de excluir as casas decimais;");

            //float f;
            //Console.WriteLine("digite um valor para float: ");
            //f = float.Parse(Console.ReadLine());

            //int i = (int)Math.Round(f);

            //Console.WriteLine("convertendo a variável float para int, de maneira de excluir ambas casas decimais, será respectivamente " + f +", "+ i);
            //Console.ReadKey();


            //atividade 2
            //Console.WriteLine("\r\nA única diferença entre Read() e ReadLine()  é que Console.Read é usado para ler apenas um único caractere do dispositivo de saída padrão, " +
            //    "enquanto Console.ReadLine é usado para ler uma linha ou string do dispositivo de saída padrão." +
            //    "\r\nEx de Read \r\n\r\nEntrada:\r\nGeeks\r\n\r\nSaída:\r\nGee\r\n\r\nEx de ReadLine\r\n\r\nEntrada:\r\nGeeks\r\nFor\r\nGeeks\r\n\r\nSaída:\r\nGeeksForGeeks\r\n\r\n");


            //Console.ReadKey();

            ////atividade 3
            //Console.WriteLine("Um cuidado necessário é quandom escrevemos a lina de código que vai adcionar uma valor a váriavel escolhida \r\n\r' int v;\r\n            Console.WriteLine(\"Digite um valor: \");\r\n            v = int.Parse(Console.ReadLine());'" +
            //    "\r\n\rporque pode ocorrer de errarmos o tipo de varíavel como por exemplo\r\n\r    int v;\r\n            Console.WriteLine(\"Digite um valor: \");\r\n            v = float.Parse(Console.ReadLine()); ");
            //Console.ReadKey();

            ////atividade 4
            //Console.WriteLine("O progama a seguir tem como objetivo confirmar se o resultado das contas satisfaça as condições postas no laço de condição:");
            //int num, num2, num3;

            //Console.WriteLine("entre com um número: ");
            //num = int.Parse(Console.ReadLine());
            //num2 = num / 2;
            //num3 = num % 2;

            //if(num3 == 0 && num2 * 2 > 10)
            //{
            //    Console.WriteLine("Mnesagem 1");
            //}
            //else
            //{
            //    Console.WriteLine("Mensagem 2");
            //}


            //Console.WriteLine("Quando se é posto o valor 8 para variável num sua saída será de 'mensagem 2' ");
            //Console.WriteLine("Quando se é posto o valor 27 para variável num sua saída será de 'mensagem 2' ");
            //Console.WriteLine("Quando se é posto o valor 28 para variável num sua saída será de 'mensagem 1' ");


            //Console.ReadKey();


            ////atividade 5
            //double v, s, s0, t;


            //Console.WriteLine("quala posição inicial do objeto em metros:  ");
            //s0 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o intervalo de tempo em segundos:  ");
            //t = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a volocidade em m/s:  ");
            //v = double.Parse(Console.ReadLine());

            //s = s0 + v * t;

            //Console.WriteLine("Sua posição final será: " + s + "m");
            //Console.ReadKey();

            //////atividade 6
            //int n;

            //Console.WriteLine("Digite um valor: ");
            //n = int.Parse(Console.ReadLine());

            //if (n % 3 == 0 && n % 5 == 0 && n % 10 == 0)
            //{
            //    Console.WriteLine("Seu valor é dvisível por 3,5 e 10;");
            //}
            //else if (n % 3 == 0 && n % 5 == 0)
            //{
            //    Console.WriteLine("Seu valor é dvisível por 3 e por 5;");
            //}
            //else if (n % 3 == 0)
            //{
            //    Console.WriteLine("Seu valor é dvisível somente por 3;");
            //}
            //else if (n % 5 == 0)
            //{
            //    Console.WriteLine("Seu valor é dvisível somente por 5;");
            //}
            //else
            //{
            //    Console.WriteLine("Valor não divisível por 3, 5  ou 10;");
            //}
            //Console.ReadKey();

            ////atividade 7
            //double v=12, s=100, s0, t;


            //Console.WriteLine("digite sua localização em km:  ");
            //s0 = double.Parse(Console.ReadLine());


            //t = (s - s0) / v;

            //Console.WriteLine("Vc chegará em sua escola em " + t + "minutos");
            //Console.ReadKey();

            //// atividade 8
            //int u, m;
            //double p, c, i, vt, ll;
            //Console.WriteLine("digite a quantidades do produto desejado;");
            //u = int.Parse(Console.ReadLine());

            //Console.WriteLine("qual a marca de ração desejada?");
            //Console.WriteLine("1- royal");
            //Console.WriteLine("2- wiskas");
            //Console.WriteLine("3- golden");
            //Console.WriteLine("4- nutrien");
            //Console.WriteLine("5- specialcat");
            //Console.WriteLine("6- marba");
            //Console.WriteLine("7- gatus");

            //m = int.Parse(Console.ReadLine());

            //switch (m)
            //{
            //    case 1:
            //        p = 129.50;
            //        c = p * (77.5 / 100);
            //        i = 33 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de "+ vt +" e o Lucro líquido será de "+ ll);
            //        break;
            //    case 2:
            //        p = 182.78;
            //        c = p * (89.7 / 100);
            //        i = 27.5 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;
            //    case 3:
            //        p = 159.46;
            //        c = p * (71.7 / 100);
            //        i = 22.5 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;
            //    case 4:
            //        p = 144.80;
            //        c = p * (88.9 / 100);
            //        i = 25 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;
            //    case 5:
            //        p = 205.40;
            //        c = p * (83.24 / 100);
            //        i = 22 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;
            //    case 6:
            //        p = 125.10;
            //        c = p * (90.4 / 100);
            //        i = 17.9 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;
            //    case 7:
            //        p = 133.99;
            //        c = p * (133.99 / 100);
            //        i = 20 / 100;

            //        ll = ((p - c) - i);
            //        vt = u * p;
            //        Console.WriteLine("o preço total será de " + vt + " e o Lucro líquido será de " + ll);
            //        break;

            //    default:
            //        Console.WriteLine("Inválido: marca de ração não encontrado");
            //        break;
            //}
            //Console.ReadKey();
        }
    }
}
