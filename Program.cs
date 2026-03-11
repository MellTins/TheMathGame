int resultadoInterno;
int pontosSomar = 0;
bool respostaUsuario;

    Console.WriteLine("Bem vindo ao Jogo Da Matemática!");
    Console.WriteLine("Vamos lá, mas antes uma breve instrução:");
    Console.WriteLine("O jogo tem 5 questões aritméticas de sua escolha, a cada resposta correta voce ganhrá um ponto!");
    Console.WriteLine("----------------------------------------");
    Console.WriteLine("Escolha com que tipo de operação aritmética quer jogar:");
    Console.WriteLine("\t1 - Soma");
    Console.WriteLine("\t2 - Subtração");
    Console.WriteLine("\t3 - Multiplicação");
    Console.WriteLine("\t4 - Divisão");

    
    string? tipoDeOperaçãoEscolhida = Console.ReadLine();

    switch (tipoDeOperaçãoEscolhida)
    {
        case "1":

            while (pontosSomar < 6)
            {
                Random valorSomar = new Random();
                int valorASomar1 = valorSomar.Next(1, 99);
                int ValorASomar2 = valorSomar.Next(1, 99);
                Console.WriteLine(valorASomar1 + "+" + ValorASomar2);
                respostaUsuario = int.TryParse(Console.ReadLine(), out int valorInteiro);

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

        case "2":

            while (pontosSomar < 6)
            {
                Random valorSubtrair = new Random();
                int valorAsubtrair1 = valorSubtrair.Next(1, 99);
                int valorASubtrair2 = valorSubtrair.Next(1, 99);
                int respostaSubtrair;

                //preciso que o primeiro valor seja maior que o segundo 

                if (valorAsubtrair1 < valorASubtrair2)
                {
                    Console.WriteLine(valorASubtrair2 +"-"+ valorAsubtrair1);
                    respostaUsuario = int.TryParse(Console.ReadLine(), out respostaSubtrair);

                    resultadoInterno = valorASubtrair2 - valorAsubtrair1;
                    if (resultadoInterno == respostaSubtrair)
                    {
                        Console.WriteLine("Certa Resposta");
                        pontosSomar += 1;
                    }
                }
                else
                {
                    Console.WriteLine(valorAsubtrair1 +"-"+ valorASubtrair2);
                    respostaUsuario = int.TryParse(Console.ReadLine(), out respostaSubtrair);

                    resultadoInterno = valorAsubtrair1 - valorASubtrair2;
                    if (resultadoInterno == respostaSubtrair)
                    {
                        Console.WriteLine("Certa Resposta");
                        pontosSomar += 1;
                    }
                }

            }

            break;

        case "3":

            while (pontosSomar < 6)
            {
                Random valorMultiplicar = new Random();
                int valorAMultiplicar1 = valorMultiplicar.Next(1, 99);
                int ValorAMultiplicar2 = valorMultiplicar.Next(1, 99);
                Console.WriteLine(valorAMultiplicar1 + "x" + ValorAMultiplicar2);
                respostaUsuario = int.TryParse(Console.ReadLine(), out int valorInteiro);

                resultadoInterno = valorAMultiplicar1 * ValorAMultiplicar2;

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
        case "4":
            while (pontosSomar < 6)
            {
                Random valorDivisao = new Random();
                int valorADividir1 = valorDivisao.Next(1, 99);
                int ValorADividir2 = valorDivisao.Next(1, 99);

                if (valorADividir1 % ValorADividir2 == 0)
                {
                    Console.WriteLine(valorADividir1 + "/" + ValorADividir2);
                    respostaUsuario = int.TryParse(Console.ReadLine(), out int valorInteiro);
                    resultadoInterno = valorADividir1 / ValorADividir2;
                    if (resultadoInterno == valorInteiro)
                    {

                        Console.WriteLine("Certa Resposta");
                        pontosSomar += 1;
                    }
                    else
                    {
                        Console.WriteLine("Errado!");
                    }
                }
            }
            break;
    }

    




    
            

    
