
List<int> jogosAnteriores = new();
int resposta;
int resultadoInterno;

Random valor = new Random();
int valores = valor.Next(100);
int valores2 = valor.Next(1, 100);
Console.WriteLine("Bem vindo ao Jogo Da Matemática!");
Console.WriteLine("Vamos começar?");
Console.WriteLine("\t1 - Sim");
Console.WriteLine("\t2 - Não");
var permissãoPraJogar = Console.ReadLine();

if (permissãoPraJogar == "1")
{
    Console.WriteLine("Vamos lá, mas antes uma breve instrução:");
    Console.WriteLine("O jogo tem 5 questões aritméticas de sua escolha, a cada resposta correta voce ganhrá um ponto!");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Escolha com que tipo de operação aritmética quer jogar:");
    Console.WriteLine("\t1 - Soma");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Multiplicação");
    Console.WriteLine("\t4 - Divisão");
    var tipoDeOperaçãoEscolhida = Console.ReadLine();

    switch (tipoDeOperaçãoEscolhida)
    {
        case "1":

            {
                Console.WriteLine("O jogo da soma vai começar!");
                var contagemDePontos = 0;


                for (int i = 1; i <= 5; i++)
                {


                    Console.WriteLine($"Qual é o resultado da soma entre {valores} + {valores2}");
                    resposta = Convert.ToInt32(Console.ReadLine());
                    resultadoInterno = valores + valores2;


                    jogosAnteriores.Add(resultadoInterno);

                    if (resposta == resultadoInterno)
                    {
                        Console.WriteLine("Certa resposta! +1 ponto ");
                        contagemDePontos++;
                    }
                    else
                    {
                        Console.WriteLine("Resposta incorreta -1 ponto");
                        contagemDePontos--;
                    }



                }
                Console.WriteLine($"Total de pontos:{contagemDePontos}");
                Console.WriteLine("Deseja ver o resultado de jogos anteriores?");
                Console.WriteLine("\tS -Sim");
                Console.WriteLine("\tN -Não");
                var historico = Console.ReadLine();

                if (historico == ("S").ToLower())
                {
                    Console.WriteLine($"Resultado de jogos Anteriores : {jogosAnteriores}");
                }
                else
                {
                    Environment.Exit(0);
                }

            }
                ;
            break;
        case "2":

            Console.WriteLine("O jogo da subtração vai começar!");
            var contagemDePontos1 = 0;

            for (int i = 0; i <= 5; i++)
            {


                Console.WriteLine($"Qual é o resultado da subtração entre {valores} - {valores2}");
                resposta = Convert.ToInt32(Console.ReadLine());
                resultadoInterno = valores - valores2;





                if (resposta == resultadoInterno)
                {
                    Console.WriteLine("Certa resposta! +1 ponto ");
                    contagemDePontos1++;
                }
                else
                {
                    Console.WriteLine("Resposta incorreta -1 ponto");
                    contagemDePontos1--;
                }

            }




            Console.WriteLine($"Total de pontos:{contagemDePontos1}");

            //se o primeiro valor aleatorio for menor que o segundo ,eu troco eles de lugar
            //SE O RESULTADO FOR UM DECIMAL,O LOOP DEVE CONTINUAR ATÉ ME DEVOLVE UM RESULTADO INTEIRO
            ;
            break;
        case "3":
            ;

            Console.WriteLine("O jogo da Multiplicação vai começar!");
            var contagemDePontos2 = 0;

            for (int i = 0; i <= 5; i++)
            {

                Console.WriteLine($"Qual é o resultado da multiplicação entre {valores} * {valores2}");
                resposta = Convert.ToInt32(Console.ReadLine());
                resultadoInterno = valores * valores2;

                if (resposta == resultadoInterno)
                {
                    Console.WriteLine("Certa resposta! +1 ponto ");
                    contagemDePontos2++;
                }
                else
                {
                    Console.WriteLine("Resposta incorreta -1 ponto");
                    contagemDePontos2--;
                }

            }
            Console.WriteLine($"Total de pontos:{contagemDePontos2}");

            break;
        case "4":

           

            ;
                break;
            
    }
}
    
