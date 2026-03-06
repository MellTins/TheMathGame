int resultadoInterno;

Console.WriteLine("Bem vindo ao Jogo Da Matemática!");
Console.WriteLine("Vamos começar!");



    Console.WriteLine("Vamos lá, mas antes uma breve instrução:");
    Console.WriteLine("O jogo tem 5 questões aritméticas de sua escolha, a cada resposta correta voce ganhrá um ponto!");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Escolha com que tipo de operação aritmética quer jogar:");
    Console.WriteLine("\t1 - Soma");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Multiplicação");
    Console.WriteLine("\t4 - Divisão");
    string? tipoDeOperaçãoEscolhida = Console.ReadLine();

switch(tipoDeOperaçãoEscolhida)
{
    case "1":
        int pontosSomar = 0;
        while(pontosSomar < 6)
        {
            Random valorSomar = new Random();
            int valorASomar1 = valorSomar.Next(1,99);
            int ValorASomar2 = valorSomar.Next(1,99);
            Console.WriteLine(valorASomar1 + "+" + ValorASomar2);
            bool respostaUsuario = int.TryParse(Console.ReadLine(), out int valorInteiro);

            resultadoInterno = valorASomar1 + ValorASomar2;

            if (resultadoInterno == valorInteiro)
            {
                Console.WriteLine("Certa Resposta");
                pontosSomar += 1;

            }
            else
            {
                Console.WriteLine("Resposta errada");
            }
        }
        break;
}

    
            

    
