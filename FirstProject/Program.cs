using System.Globalization;
using System.Text;

namespace FirstProject;

class Program
{
    static void Main()
    {
        /* 
         * Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!
         * 
            Console.WriteLine("Qual o seu nome?");
            string name = Console.ReadLine();
            string text = "Olá, {0}! Seja muito bem-vindo!";
            string phrase = string.Format(text, name);
            Console.WriteLine(phrase);
         */


        /*
            Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.

            Console.WriteLine("Informe seu nome");
            var firstName = Console.ReadLine();
            Console.WriteLine("Informe seu sobrenome");
            var surName = Console.ReadLine();

            var message = "{0} {1}";

            var fullName = string.Format(message, firstName, surName);

            Console.WriteLine(fullName);
         */



        /*
            Crie um programa com 2 valores do tipo double já declarados que retorne:
            - A soma entre esses dois números;
            - A subtração entre os dois números;
            - A multiplicação entre os dois números;
            - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
            - A média entre os dois números.
       
            double firstNumber = 2.5;
            double secondNumber = 5;

            if(secondNumber == 0)
            {
                Console.WriteLine("O número tem que ser diferente de 0");
                return;
            }

            double sum = firstNumber + secondNumber;
            double subtraction = firstNumber - secondNumber;
            double multiplication = firstNumber * secondNumber;
            double division = firstNumber / secondNumber;
            double average = (firstNumber * secondNumber) / 2;



            Console.WriteLine("Soma: " + firstNumber + " + " + secondNumber + " = " + sum );
            Console.WriteLine("Subtração: " + firstNumber + " - " + secondNumber + " = " + subtraction);
            Console.WriteLine("Multiplicação: " + firstNumber + " * " + secondNumber + " = " + multiplication);
            Console.WriteLine("Divisão: " + firstNumber + " / " + secondNumber + " = " + division);
            Console.WriteLine("Média: " + average);

         */



        /*
            Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem.
        
            Console.WriteLine("Informe uma ou mais palavras");
            var message = Console.ReadLine();
            var splitedMessage = message.Split(" ");
        
            foreach ( var item in splitedMessage) 
            {
                var countChars = item.Length;

                Console.WriteLine($"A palavra '{item}' possui {countChars} caracteres");
            }
         */



        /*
            Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
            - A placa deve ter 7 caracteres alfanuméricos;
            - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
            - Os quatro últimos caracteres são números;
    
            Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário.

            Console.WriteLine("Informe sua placa");
            var placa = Console.ReadLine();

            string verifier = "";

            if(placa.Length < 7)
            {
                Console.WriteLine("Placa inválida! A placa deve conter 7 carecteres.");
                return;
            }

            for(int i = 0; i < placa.Length; i++)
            {
                if (i < 3 && char.IsLetter(placa[i]))
                {
                    verifier = "Verdadeiro";

                } else if(i >= 3 && char.IsDigit(placa[i]))
                {
                    verifier = "Verdadeiro";

                } else
                {
                    verifier = "Falso";
                    break;
                }
            }

            Console.WriteLine(verifier);
         */



        /* 
            Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
            - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
            - Apenas a data no formato "01/03/2024".
            - Apenas a hora no formato de 24 horas.
            - A data com o mês por extenso.
         
         

             DateTime date = DateTime.Now;

            string[] formatDates = { "F", "dd/MM/yyyy", "T", "MMMM" };

            foreach (string itemFormatDate in formatDates)
            { 
                Console.WriteLine(date.ToString(itemFormatDate, new CultureInfo("pt-BR")));
            }
        */

    }
}