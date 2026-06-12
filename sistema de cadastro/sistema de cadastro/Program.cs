using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace sistema_de_cadastro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(@"
░██████╗██╗░██████╗████████╗███████╗███╗░░░███╗░█████╗░  ██████╗░███████╗
██╔════╝██║██╔════╝╚══██╔══╝██╔════╝████╗░████║██╔══██╗  ██╔══██╗██╔════╝
╚█████╗░██║╚█████╗░░░░██║░░░█████╗░░██╔████╔██║███████║  ██║░░██║█████╗░░
░╚═══██╗██║░╚═══██╗░░░██║░░░██╔══╝░░██║╚██╔╝██║██╔══██║  ██║░░██║██╔══╝░░
██████╔╝██║██████╔╝░░░██║░░░███████╗██║░╚═╝░██║██║░░██║  ██████╔╝███████╗
╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚══════╝╚═╝░░░░░╚═╝╚═╝░░╚═╝  ╚═════╝░╚══════╝

░█████╗░░█████╗░██████╗░██████╗░░█████╗░░██████╗████████╗░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗
██║░░╚═╝███████║██║░░██║██████╔╝███████║╚█████╗░░░░██║░░░██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██╗██╔══██║░╚═══██╗░░░██║░░░██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██║░░██║██████╔╝░░░██║░░░╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░░╚════╝░
");
            Console.ResetColor();
            Console.WriteLine("\n Seja muito bem vindo!\n");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\n 1 - cadastro de animes");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n 2 - Cadastro de Supers");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n 3 - ");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n 4 - Cadastro de locadora de VHS");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n 5 - Cadastro de oficina mecânica");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n 6 - Cadastro de livros");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n 7 - Cadastro de restaurante cardapio");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n 8 - Cadastro de jogos");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("\n 9 - Cadastro de músicas");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n 10 - SAIR");

            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("\n Digite a opção escolhida: ");

            Console.ResetColor();

            opcao = int.Parse(Console.ReadLine());


            switch (opcao)

            {

                case 1:

                    cadastroAnimes();

                    break;

                case 2:

                    cadastroSupers();

                    break;

                case 3:

                    cadastroSeries();

                    break;


                case 4:

                    cadastroLocadoraVHS();

                    break;


                case 5:

                    Cadastrooficinamecânica();

                    break;


                case 6:

                    Cadastrolivros();

                    break;


                case 7:

                    Cadastrorestaurantecardapio();

                    break;


                case 8:

                    CadastroJogos();

                    break;


                case 9:

                    CadastroMusicas();

                    break;


                default:

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("\n Opção escolhida: ");

                    Console.ResetColor();

                    Thread.Sleep(1000);

                    break;

            }
            switch (opcao)

            {

                case 1:

                    cadastroAnimes();

                    break;

                case 2:

                    cadastroSupers();

                    break;

                case 3:

                    cadastroSeries();

                    break;


                case 4:

                    cadastroLocadoraVHS();

                    break;


                case 5:

                    Cadastrooficinamecânica();

                    break;


                case 6:

                    Cadastrolivros();

                    break;


                case 7:

                    Cadastrorestaurantecardapio();

                    break;


                case 8:

                    CadastroJogos();

                    break;


                case 9:

                    CadastroMusicas();

                    break;


                default:

                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("\n Opção escolhida: ");

                    Console.ResetColor();

                    Thread.Sleep(1000);

                    break;


                    switch (opcao)

                    {

                        case 1:

                            cadastroAnimes();

                            break;

                        case 2:

                            cadastroSupers();

                            break;

                        case 3:

                            cadastroSeries();

                            break;


                        case 4:

                            cadastroLocadoraVHS();

                            break;


                        case 5:

                            Cadastrooficinamecânica();

                            break;


                        case 6:

                            Cadastrolivros();

                            break;


                        case 7:

                            Cadastrorestaurantecardapio();

                            break;


                        case 8:

                            CadastroJogos();

                            break;


                        case 9:

                            CadastroMusicas();

                            break;


                         default:;

                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine("\n Opção escolhida: ");

                            Console.ResetColor();

                            Thread.Sleep(1000);

                            break;
                    }
            }
        } static void cadastroAnimes()

        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░██████╗░░█████╗░░██████╗████████╗░█████╗░  ██████╗░███████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗  ██╔══██╗██╔════╝
██║░░╚═╝███████║██║░░██║██████╔╝███████║╚█████╗░░░░██║░░░██║░░██║  ██║░░██║█████╗░░
██║░░██╗██╔══██║██║░░██║██╔══██╗██╔══██║░╚═══██╗░░░██║░░░██║░░██║  ██║░░██║██╔══╝░░
╚█████╔╝██║░░██║██████╔╝██║░░██║██║░░██║██████╔╝░░░██║░░░╚█████╔╝  ██████╔╝███████╗
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░░╚════╝░  ╚═════╝░╚══════╝

░█████╗░███╗░░██╗██╗███╗░░░███╗███████╗░██████╗
██╔══██╗████╗░██║██║████╗░████║██╔════╝██╔════╝
███████║██╔██╗██║██║██╔████╔██║█████╗░░╚█████╗░
██╔══██║██║╚████║██║██║╚██╔╝██║██╔══╝░░░╚═══██╗
██║░░██║██║░╚███║██║██║░╚═╝░██║███████╗██████╔╝
╚═╝░░╚═╝╚═╝░░╚══╝╚═╝╚═╝░░░░░╚═╝╚══════╝╚═════╝░
");


            Console.WriteLine(); ("\n Digite o título do anime:".;) string tituloAnimes = Console.ReadLine();
            Console.WriteLine("\n Digite a qnt de episodios: "); double qntAnimes = int.Parse(Console.ReadLine());

            Console.WriteLine("\n Digite o ano do anime: "); string anoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite o personagem principal: "); string personagemAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a clasificacao do anime: "); string classificacaoAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a categoria: "); string categoriaAnime = Console.ReadLine();

            Console.WriteLine("\n Digite a avaliacao do anime: "); string avaliacaoAnime = Console.ReadLine();


















        }




















    }








































}









    



     
      
   
