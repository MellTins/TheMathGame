
Console.WriteLine("Bem vindo ao Jogo Da Matemática!");
Console.WriteLine("Vamos começar?");
Console.WriteLine("\t1 - Sim");
Console.WriteLine("\t2 - Não");
var permissãoPraJogar = Console.ReadLine();

if(permissãoPraJogar == "1")
{
    Console.WriteLine("Vamos lá, mas antes uma breve instrução:" );
    Console.WriteLine("O jogo tem 5 questões aritméticas de sua escolha, a cada resposta correta voce ganhrá um ponto!");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Escolha com que tipo de operação aritmética quer jogar:");
    Console.WriteLine("\t1 - Soma");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Divisão");
    Console.WriteLine("\t4 - Multiplicação");
    var tipoDeOperaçãoEscolhida = Console.ReadLine();

    switch(tipoDeOperaçãoEscolhida)
    {
        case "1":
            Console.WriteLine("O jogo da soma vai começar!");
           
            var pontos = 0;
            do
            {
                Random valor = new Random();
                int valores = valor.Next(1, 9);
                int valores2 = valor.Next(1, 9);
                Console.WriteLine($"Qual é o resultado da soma entre {valores} e {valores2}");
                var resposta = Convert.ToInt32(Console.ReadLine());
                var resultadointerno = valores + valores2;
                 
                if(resposta == resultadointerno)
                {
                    Console.WriteLine("Certa resposta! +1 ponto ");
                    pontos++;
                }
                else
                {
                    Console.WriteLine("Resposta incorreta -1");
                    pontos--;
                }

            } while (pontos <=5);
            Console.WriteLine($"Quantidades de acertos: {pontos}");
            ;
            break;
            case "2":;
            break;
            case "3":;
            break;
            case "4":;
            break;
    }
}