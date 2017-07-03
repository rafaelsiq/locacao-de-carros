using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LocaMais1
{
    class Program
    {
        static void ClienteCadastro()
        {
            System.Threading.Thread.Sleep(470);
            Console.Clear();
            int  c1;
            string n, e, t;
            Console.WriteLine("Digite o nome do Cliente:");
            n = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Digite o endereço do Cliente:");
            e = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Digite o telefone do Cliente:");
            t = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            c1 = Codigos();
            FileStream cli = new FileStream("CADASTRO CLIENTE.txt", FileMode.Append);
            StreamWriter escrevecli = new StreamWriter(cli);
            escrevecli.WriteLine("NOME:" + n + ";" + "ENDEREÇO:" + e + ";" + "TELEFONE:" + t + ";" + "CÓDIGO:" + c1);
            escrevecli.Close();
            Console.WriteLine("CLIENTE CADASTRADO COM SUCESSO!");
            Console.ReadKey();
        }
        static void ClientePesquisa()
        {
            string nomebusca;
            Console.WriteLine("Digite o nome do cliente que deseja buscar:");
            nomebusca = "NOME:" + Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(470);
            Console.Clear();
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            int a = 0;
            string[] array = File.ReadAllLines("CADASTRO CLIENTE.txt");
            for (int i = 0; i < array.Length; i++)
            {
                string[] auxiliar = array[i].Split(';');
                if (nomebusca == auxiliar[0])
                {
                    Console.WriteLine("DADOS DO CLIENTE:\n");
                   for(int x=0;x<auxiliar.Length;x++)
                    {
                        Console.WriteLine(auxiliar[x]);
                    }
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Cliente não cadastrado.");
            }
            a = 0;
            Console.ReadKey();
            System.Threading.Thread.Sleep(500);
            Console.Clear();
        }
        static void FunciCadastro()
        {
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            int  c1;
            string n, t, car, sal;
            Console.WriteLine("Digite o nome do Funcionário:");
            n = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Digite o telefone do Funcionário:");
            t = Console.ReadLine();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Digite o cargo do Funcionário:");
            car = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Digite o salário do Funcionário:");
            sal = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            c1 = Codigos();
            FileStream cli = new FileStream("CADASTRO FUN.txt", FileMode.Append);
            StreamWriter escrevecli = new StreamWriter(cli);
            escrevecli.WriteLine("NOME:" + n + ";" + "TELEFONE:" + t + ";" + "CARGO:" + car + ";" + "SALÁRIO:" + sal + ";" + "CÓDIGO:" + c1);
            escrevecli.Close();
            Console.WriteLine(" FUNCIONÁRIO CADASTRADO COM SUCESSO!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
        static void FunciPesquisa()
        {
            System.Threading.Thread.Sleep(100);
            Console.Clear();
            string nomebusca;
            int a = 0;
            Console.WriteLine("Digite o nome do funcionário que deseja buscar:");
            nomebusca = "NOME:" + Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            string[] array = File.ReadAllLines("CADASTRO FUN.txt");
            for (int i = 0; i < array.Length; i++)
            {
                string[] auxiliar = array[i].Split(';');
                if (nomebusca == auxiliar[0])
                {
                    Console.WriteLine("DADOS DO FUNCIONÁRIO:\n");
                    for (int x = 0; x < auxiliar.Length; x++)
                    {
                        Console.WriteLine(auxiliar[x]);
                    }
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Funcionário não cadastrado.");
            }
            a = 0;
            Console.ReadKey();
        }
        static void ClienteMenu()
        {
            System.Threading.Thread.Sleep(470);
            Console.Clear();
            char x;
            do
            {
                Console.WriteLine("MENU DE OPÇÕES: \n \n 1 - CADASTRAR CLIENTE \n \n 2 - PESQUISAR CLIENTE \n \n 3 - VOLTAR AO MENU INICIAL \n \n 4 - SAIR");
                x = char.Parse(Console.ReadLine());
                switch (x)
                {
                    case '1':
                        ClienteCadastro();
                        break;
                    case '2':
                        ClientePesquisa();
                        break;
                    case '3':
                        Inicial();
                        break;
                    case '4':
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            } while (x != '1' && x != '2' && x != '3');
        }
        static void FunciMenu()
        {
            System.Threading.Thread.Sleep(40);
            Console.Clear();
            char y;
            do
            {
                Console.WriteLine("MENU DE OPÇÕES: \n \n 1 - CADASTRAR FUNCIONÁRIO \n \n 2 - PESQUISAR FUNCIONÁRIO \n \n 3 - VOLTAR AO MENU INICIAL \n \n 4 - SAIR  ");
                y = char.Parse(Console.ReadLine());
                switch (y)
                {
                    case '1'://cadastro funcionario
                        FunciCadastro();
                        break;
                    case '2':
                        FunciPesquisa();
                        break;
                    case '3':
                        Inicial();
                        break;
                    case '4':
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        break;
                }
            } while (y != '1' && y != '2' && y != '3');
        }
        static void Inicial()
        {
            System.Threading.Thread.Sleep(70);
            Console.Clear();
            char menu;
            do
            {
                Console.WriteLine("MENU DE OPÇÕES: \n \n 1 - CLIENTE \n \n 2 - FUNCIONÁRIO \n \n 3 - VEÍCULO \n \n 4 - LOCAÇÃO \n \n 5 - SAIR");
                menu = char.Parse(Console.ReadLine());
                switch (menu)
                {
                    case '1':
                        ClienteMenu();
                        Inicial();
                        break;
                    case '2':
                        FunciMenu();
                        Inicial();
                        break;
                    case '3':
                        VeicMenu();
                        Inicial();
                        break;
                    case '4':
                        MenuLocacao();
                        Inicial();
                        break;
                    case '5':
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                        break;
                    default:
                        Console.WriteLine("OPÇÃO INVALIDA!");
                        break;
                }
            } while (menu != '5');
        }
        static void VeicCadastro()
        {
            Console.Clear();
            int  c1;
            string des, mod, cor, pla, dia, ass, sta;
            c1 = Codigos();
            Console.WriteLine("Digite a descrição do Veiculo:");
            des = Console.ReadLine();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            FileStream arq = new FileStream("CADASTRO VEI.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arq);
            Console.WriteLine("Digite o modelo do veiculo:");
            mod = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            Console.WriteLine("Digite a cor do veiculo:");
            cor = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            Console.WriteLine("Digite a placa do veiculo:");
            pla = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            Console.WriteLine("Digite o valor da diaria do veiculo:");
            dia = Console.ReadLine();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            Console.WriteLine("Digite a quantidade de ocupantes maxima do veiculo:");
            ass = Console.ReadLine();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            Console.WriteLine("Digite o status do veiculo:");
            sta = Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(120);
            Console.Clear();
            escreve.WriteLine("DESCRICAO:" + des + ";" + "MODELO:" + mod + ";" + "COR:" + cor + ";" + "PLACA:" + pla + ";" + "VALOR DIARIA:" + dia + ";" + "OCUPANTES:" + ass + ";" + "CODIGO:" + c1 + ";" + "STATUS:" + sta);
            escreve.Close();
            Console.WriteLine(" VEICULO CADASTRADO COM SUCESSO!");
            System.Threading.Thread.Sleep(250);
            Console.Clear();
        }
        static void VeicMenu()
        {
            System.Threading.Thread.Sleep(40);
            Console.Clear();
            char x;
            do
            {
                Console.WriteLine("MENU DE OPÇÕES: \n \n 1 - CADASTRAR VEICULO \n \n 2 - VOLTAR AO MENU INICIAL \n \n 3 - SAIR");
                x = char.Parse(Console.ReadLine());
                switch (x)
                {
                    case '1':
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                        VeicCadastro();
                        break;
                    case '2':
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                        Inicial();
                        break;
                    case '3':
                        System.Diagnostics.Process.GetCurrentProcess().Close();
                        break;
                    default:
                        System.Threading.Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("OPÇÃO INVALIDA!");
                        break;
                }
            } while (x != '1' && x != '2');
        }
        static void PesquisaLocCliente()
        {
            System.Threading.Thread.Sleep(70);
            Console.Clear();
            string nomebusca;
            int a = 0;
            Console.WriteLine("Digite o nome do Cliente que deseja buscar a locacao:");
            nomebusca = "Nome do Cliente:" + Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(300);
            Console.Clear();
            string[] array = File.ReadAllLines("CADASTRO LOCACAO.txt");
            for (int i = 0; i < array.Length; i++)
            {
                string[] auxiliar = array[i].Split(';');
                if (nomebusca == auxiliar[0])
                {
                    Console.WriteLine("\n \n");
                    for (int b = 0; b< auxiliar.Length; b++)
                    {
                        Console.WriteLine(auxiliar[b]);
                    }
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Esse cliente não realizou locações.");
            }
            a = 0;
            Console.ReadKey();
        }
        static void MostrarTodasLoc()
        {
            System.Threading.Thread.Sleep(70);
            Console.Clear();
            string[] todos = File.ReadAllLines("CADASTRO LOCACAO.txt");
            for (int i = 0; i < todos.Length; i++)
            {
                string[] dados = todos[i].Split(';');
                Console.WriteLine("\n \n");
                for (int a = 0; a < dados.Length; a++)
                {
                    Console.WriteLine(dados[a]);
                }
            }
            Console.ReadKey();
        }
        static void MenuLocacao()
        {
                System.Threading.Thread.Sleep(40);
                Console.Clear();
                char menu;
                do
                {
                    Console.WriteLine("MENU DE OPÇÕES: \n \n 1 - CADASTRAR LOCACAO \n \n 2 - DAR BAIXA EM LOCACAO \n \n 3 - PESQUISAR LOCACAO POR CLIENTE \n \n 4 - MOSTAR TODAS AS LOCAÇOES \n \n 5 - CLIENTES ACIMA DE 500 PONTOS NO PROGRAMA FIDELIDADE \n \n 6 - VOLTAR AO MENU INICIAL\n \n 7 - SAIR");
                    menu = char.Parse(Console.ReadLine());
                    DateTime hora = DateTime.Now;
                    string[] hora1 = Convert.ToString(hora).Split('/', ' ', ':');
                    int h = Convert.ToInt32(hora1[3]);
                    switch (menu)
                    {
                        case '1'://CADASTRAR - ok
                            if (h >= 8 && h < 18)
                            {
                                CadLocacao();
                                Inicial();
                            }
                            else
                            {
                                Console.WriteLine("NÃO É PERMITIDO LOCAR UM VEICULO NESSE HORARIO.");
                                Console.ReadKey();
                            }
                            break;
                        case '2'://DAR BAIXA
                            BaixaLoc();
                            Inicial();
                            break;
                        case '3'://PESQUISA POR CLIENTE
                            PesquisaLocCliente();
                            Inicial();
                            break;
                        case '4'://MOSTAR TODAS
                            MostrarTodasLoc();
                            Inicial();
                            break;
                        case '5'://PONTOS FIDELIDADE
                            PesquisaFid500();
                            Inicial();
                            break;
                        case '6'://VOLTAR AO INICIAL
                            Inicial();
                            break;
                        case '7'://SAIR 
                            System.Diagnostics.Process.GetCurrentProcess().Close();
                            break;
                        default:
                            Console.WriteLine("OPÇÃO INVALIDA!");
                            System.Threading.Thread.Sleep(1000);
                            Console.Clear();
                            break;
                    }
                } while (menu != '1' && menu != '2' && menu != '3' && menu != '4' && menu != '5' && menu != '6');
            }
        static void CadLocacao()
        {
            System.Threading.Thread.Sleep(70);
            Console.Clear();
            int c1 = Codigos();
            string nomebusca;
            Console.WriteLine("Digite o nome do cliente que deseja buscar:");
            nomebusca = "NOME:" + Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(470);
            Console.Clear();
            string nomecliente = "", tel, endereco, codigo = "", codigo1 = "";
            int a = 0;
            string[] array = File.ReadAllLines("CADASTRO CLIENTE.txt");
            for (int f = 0; f < array.Length; f++)
            {
                string[] auxiliar = array[f].Split(';');
                nomecliente = (auxiliar[0]);
                endereco = (auxiliar[1]);
                tel = (auxiliar[2]);
                codigo = (auxiliar[3]);
                codigo1 = codigo.Substring(7);
                if (nomebusca == nomecliente)
                {
                    Console.WriteLine("Dados do Cliente:");
                    Console.WriteLine(nomecliente);
                    Console.WriteLine(endereco);
                    Console.WriteLine(tel);
                    Console.WriteLine(codigo);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine("Cliente não cadastrado. \n \n Deseja cadastra-lo? \n S-SIM \n N-NÃO");
                string conf = Console.ReadLine().ToUpper();
                if (conf == "S")
                {
                    ClienteCadastro();
                    CadLocacao();
                }
                else if (conf == "N") { Inicial(); }
            }
            else if (a > 0)
            {
                string[] dialoc;
                string datloc;
                Console.WriteLine("Digite a data da locacao ");
                datloc = PreencheData();
                dialoc = datloc.Split('/');
                string[] dialdev;
                string datdev, seguro1 = "";
                Console.WriteLine("Digite a data da devolucao do veiculo ");
                datdev = PreencheData();
                dialdev = datdev.Split('/');
                int mes, ano, precoseguro = 0;
                mes = (Convert.ToInt32(dialdev[1]) - Convert.ToInt32(dialoc[1])) * 30;
                ano = (Convert.ToInt32(dialdev[2]) - Convert.ToInt32(dialoc[2])) * 365;
                int diasprev = (Convert.ToInt32(dialdev[0]) - Convert.ToInt32(dialoc[0])) + mes + ano;
                Console.WriteLine("Deseja contratar o seguro por apenas R$50,00?\n S-SIM \n N-NÃO");
                string seguro = Console.ReadLine().ToUpper();
                if (seguro == "S")
                {
                    precoseguro = 50;
                    seguro1 = "SIM";
                }
                if (seguro == "N")
                {
                    precoseguro = 0;
                    seguro1 = "NÃO";
                }
                Console.WriteLine("Qual a quantidade minima de assentos necessarios?");
                int assentos1 = int.Parse(Console.ReadLine());
                string[] array1 = File.ReadAllLines("CADASTRO VEI.txt");
                int disponivel = 0, x = 0;
                for (int t = 0; t < array1.Length; t++)
                {
                    string[] auxiliar = array1[t].Split(';');
                    int assentos2 = Convert.ToInt32(auxiliar[5].Substring(10));
                    if (assentos1 <= assentos2 && auxiliar[7].Substring(7) == "DISPONIVEL")
                    {
                        disponivel++;
                    }
                }
                if (disponivel > 0)
                {
                    string[] opcoes = new string[disponivel];
                    for (int t = 0; t < array1.Length; t++)
                    {
                        string[] auxiliar = array1[t].Split(';');
                        int assentos2 = Convert.ToInt32(auxiliar[5].Substring(10));
                        if (assentos1 <= assentos2 && auxiliar[7].Substring(7) == "DISPONIVEL")
                        {
                            opcoes[x] = array1[t];
                            x++;
                        }
                    }
                    Console.Write("Há " + disponivel + " carro(s) disponivel(is) \n Escolha uma das opções:");
                    for (int d = 0; d < disponivel; d++)
                    {
                        Console.WriteLine("\n OPÇÃO " + (d + 1));
                        Console.WriteLine(opcoes[d]);
                    }
                    int opcao = int.Parse(Console.ReadLine());
                    Console.WriteLine("\n \n Opção escolhida: \n" + opcoes[opcao - 1]);
                    string[] dados = opcoes[opcao - 1].Split(';');
                    double valorunit = Convert.ToDouble(dados[4].Substring(13));
                    double valortotal = (valorunit * diasprev) + precoseguro;
                    string nome = nomebusca.Substring(5);
                    Console.WriteLine("\n \n DADOS DA LOCAÇÃO:\n \n" + " Nome do Cliente: " + nome + "\n Código da Locação: " + c1 + "\n Data de retirada: " + datloc + "\n Data de devolução: " + datdev + "\n Quantidade de dias: " + diasprev + "\n Seguro: " + seguro1 + "\n Valor Total Previsto: R$ " + valortotal);
                    Console.WriteLine("\n Deseja confirmar a locação? \n S-SIM \n N-NÃO");
                    char confirma = char.Parse(Console.ReadLine().ToUpper());
                    if (confirma == 'S')
                    {
                        StreamReader sr = new StreamReader("CADASTRO VEI.txt ");
                        StringBuilder sb = new StringBuilder();
                        while (!sr.EndOfStream)
                        {
                            string s = sr.ReadLine();
                            if (s.IndexOf(opcoes[opcao - 1]) > -1)
                            {
                                s = s.Replace(opcoes[opcao - 1], dados[0] + ";" + dados[1] + ";" + dados[2] + ";" + dados[3] + ";" + dados[4] + ";" + dados[5] + ";" + dados[6] + ";" + "STATUS:ALUGADO");
                            }
                            sb.AppendLine(s);
                        }
                        sr.Close();
                        StreamWriter sw = new StreamWriter("CADASTRO VEI.txt ");
                        sw.Write(sb);
                        sw.Close();//mudança no Cadastro de veiculo
                        FileStream arq = new FileStream("CADASTRO LOCACAO.txt", FileMode.Append);
                        StreamWriter escreve = new StreamWriter(arq);
                        escreve.WriteLine("Nome do Cliente:" + nome + ";Código do Cliente:" + codigo1 + ";Código da Locação:" + c1 + ";Data de retirada:" + datloc + ";Data de devolução:" + datdev + ";Quantidade de dias:" + diasprev + ";Seguro:" + seguro1 + ";Codigo do veiculo:" + (dados[6].Substring(7)) + ";Valor: R$" + valortotal + ";STATUS:EM ABERTO");
                        escreve.Close();
                        Console.WriteLine("LOCAÇÃO REALIZADA COM SUCESSO!");
                        Console.ReadKey();
                    }
                    else if (confirma == 'N')
                    {
                        CadLocacao();
                    }
                    else
                    {
                        Console.WriteLine("OPÇÃO INVÁLIDA!");
                    }
                }
                else if (disponivel == 0)
                {
                    Console.WriteLine("Não há veiculos disponiveis para locação.");
                    Inicial();
                }
            }
        }
        static string PreencheData()
        {
            string data;
            string[] dia;
            do
            {
                Console.Write("(utilize o formato DD/MM/AAAA):");
                data = Console.ReadLine();
                dia = data.Split('/');
                if (Convert.ToInt32(dia[0]) > 31 || Convert.ToInt32(dia[0]) < 1)
                {
                    Console.WriteLine("Dia invalido!");
                }
                if (Convert.ToInt32(dia[1]) > 12 || Convert.ToInt32(dia[1]) < 1)
                {
                    Console.WriteLine("Mes invalido!");
                }
                if (Convert.ToInt32(dia[2]) < 1)
                {
                    Console.WriteLine("Ano invalido!");
                }
            } while ((Convert.ToInt32(dia[0]) > 31 || Convert.ToInt32(dia[0]) < 1) || (Convert.ToInt32(dia[1]) > 12 || Convert.ToInt32(dia[1]) < 1)|| (Convert.ToInt32(dia[2]) < 1));
            return data;
        }
        static void PontosFidCalc(string nomecliente, string cod, int dias)
        {
            int pontos, total = 0, a = 0, b = 0;
            string linha, nome, codigo;
            FileStream p = new FileStream("PONTOS.txt", FileMode.Open);
            StreamReader ler = new StreamReader(p);
            do
            {
                linha = ler.ReadLine();
                a++;
            }
            while (linha != null);
            ler.Close();
            if (a == 1)
            {
                pontos = dias * 10;
                FileStream p1 = new FileStream("PONTOS.txt", FileMode.Append);
                StreamWriter escreve = new StreamWriter(p1);
                escreve.WriteLine(nomecliente + ";" + cod + ";Pontos:" + pontos);
                escreve.Close();
                if (pontos >= 500)
                {
                    Console.WriteLine("CLIENTE ATINGIU 500 PONTO NO PROGRAMA FIDELIDADE");
                }
                Console.ReadKey();
            }
            else
            {
                string dados = "";
                string[] array = File.ReadAllLines("PONTOS.txt");
                for (int i = 0; i < array.Length; i++)
                {
                    string[] auxiliar = array[i].Split(';');
                    nome = (auxiliar[0]);
                    codigo = auxiliar[1];
                    if (nomecliente == nome && cod == codigo)
                    {
                        dados = array[i];
                        b++;
                    }
                }
                if (b > 0)
                {
                    string[] dados1 = dados.Split(';');//dados1[0]=nome,dados1[1]=codigo,dados1[2]=pontos
                    int pont = Convert.ToInt32(dados1[2].Substring(7));
                    pontos = dias * 10;
                    total = pont + pontos;
                    StreamReader sr = new StreamReader("PONTOS.txt ");
                    StringBuilder sb = new StringBuilder();
                    while (!sr.EndOfStream)
                    {
                        string s = sr.ReadLine();
                        if (s.IndexOf(dados) > -1)
                        {
                            s = s.Replace(dados, dados1[0] + ";" + dados1[1] + ";Pontos:" + total);
                        }
                        sb.AppendLine(s);
                        if (pontos >= 500)
                        {
                            Console.WriteLine("CLIENTE ATINGIU 500 PONTOS NO PROGRAMA FIDELIDADE!");
                        }
                        Console.ReadKey();
                    }
                    sr.Close();
                    StreamWriter sw = new StreamWriter("PONTOS.txt ");
                    sw.Write(sb);
                    sw.Close();
                }
                else
                {
                    pontos = dias * 10;
                    FileStream p2 = new FileStream("PONTOS.txt", FileMode.Append);
                    StreamWriter escreve2 = new StreamWriter(p2);
                    escreve2.WriteLine(nomecliente + ";" + cod + ";Pontos:" + pontos);
                    escreve2.Close();
                    if(pontos>=500)
                    {
                        Console.WriteLine("CLIENTE ATINGIU 500 PONTOS NO PROGRAMA FIDELIDADE!");
                    }
                    Console.ReadKey();
                }
            }
        }
        static void BaixaLoc()
        {
            string nomebusca, nomecliente = "";
            Console.WriteLine("Digite o nome do cliente que deseja buscar:");
            nomebusca = "Nome do Cliente:" + Console.ReadLine().ToUpper();
            System.Threading.Thread.Sleep(470);
            Console.Clear();
            int a = 0, diaat, mesat, anoat;
            string[] array = File.ReadAllLines("CADASTRO LOCACAO.txt");
            DateTime today = DateTime.Now;
            string[] date = Convert.ToString(today).Split('/', ' ', ':');
            diaat = Convert.ToInt32(date[0]);
            mesat = Convert.ToInt32(date[1]);
            anoat = Convert.ToInt32(date[2]);
            for (int i = 0; i < array.Length; i++)
            {
                string[] auxiliar = array[i].Split(';');
                nomecliente = (auxiliar[0]);
                if ((nomebusca == nomecliente) && (auxiliar[9] == "STATUS:EM ABERTO"))
                {
                    a++;
                }
            }
            if (a > 0)
            {
                int x = 0, mes, ano;
                string[] opcoes = new string[a];
                for (int t = 0; t < array.Length; t++)
                {
                    string[] auxiliar = array[t].Split(';');
                    nomecliente = (auxiliar[0]);
                    if ((nomebusca == nomecliente) && (auxiliar[9] == "STATUS:EM ABERTO"))
                    {
                        opcoes[x] = array[t];
                        x++;
                    }
                }
                Console.Write("Há " + a + " Locações em Aberto. \n Escolha uma das opções para dar baixa:");
                for (int b = 0; b < a; b++)
                {
                    Console.WriteLine("\n LOCAÇÃO " + (b + 1));
                    Console.WriteLine(opcoes[b]);
                }
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("\n \n Opção escolhida: \n" + opcoes[opcao - 1]);
                string[] dados = opcoes[opcao - 1].Split(';');
                string codvei = "CODIGO:" + dados[7].Substring(18);
                int[] dataret = new int[3];
                string dataarq = dados[3].Substring(17);
                string[] daata = dataarq.Split('/');
                dataret[0] = Convert.ToInt32(daata[0]);
                dataret[1] = Convert.ToInt32(daata[1]);
                dataret[2] = Convert.ToInt32(daata[2]);
                mes = (mesat - dataret[1]) * 30;
                ano = (anoat - dataret[2]) * 365;
                int diasprev = (diaat - dataret[0]) + mes + ano;
                string diasprev1 = dados[5].Substring(19);
                if (diasprev == Convert.ToInt32(diasprev1))
                {
                    Console.WriteLine("\n \n"+dados[8]);
                    Console.WriteLine("Confirmar devolução? \n S-SIM \n N-NÃO");
                    string confirma = Console.ReadLine().ToUpper();
                    if (confirma == "S")
                    {
                        StreamReader sr = new StreamReader("CADASTRO LOCACAO.txt ");
                        StringBuilder sb = new StringBuilder();
                        while (!sr.EndOfStream)
                        {
                            string s = sr.ReadLine();
                            if (s.IndexOf(opcoes[opcao - 1]) > -1)
                            {
                                s = s.Replace(opcoes[opcao - 1], dados[0] + ";" + dados[1] + ";" + dados[2] + ";" + dados[3] + ";" + dados[4] + ";" + dados[5] + ";" + dados[6] + ";" + dados[7] + ";" + dados[8] + ";" + "STATUS:ENCERRADO");
                            }
                            sb.AppendLine(s);
                        }
                        sr.Close();
                        StreamWriter sw = new StreamWriter("CADASTRO LOCACAO.txt ");
                        sw.Write(sb);
                        sw.Close();//mudança no Cadastro de Locação
                                   //mudança no Cadastro de veiculo:
                        string carro = "";
                        string[] array2 = File.ReadAllLines("CADASTRO VEI.txt");
                        for (int i = 0; i < array2.Length; i++)
                        {
                            string[] auxiliar = array2[i].Split(';');
                            string cod = auxiliar[6];
                            if (codvei == cod)
                            {
                                carro = array2[i];
                            }
                        }
                        string[] dados1 = carro.Split(';');
                        StreamReader sr1 = new StreamReader("CADASTRO VEI.txt ");
                        StringBuilder sb1 = new StringBuilder();
                        while (!sr1.EndOfStream)
                        {
                            string s1 = sr1.ReadLine();
                            if (s1.IndexOf(carro) > -1)
                            {
                                s1 = s1.Replace(carro, dados1[0] + ";" + dados1[1] + ";" + dados1[2] + ";" + dados1[3] + ";" + dados1[4] + ";" + dados1[5] + ";" + dados1[6] + ";" + "STATUS:DISPONIVEL");
                            }
                            sb1.AppendLine(s1);
                        }
                        sr1.Close();
                        StreamWriter sw1 = new StreamWriter("CADASTRO VEI.txt ");
                        sw1.Write(sb1);
                        sw1.Close();
                        //pontos fidelidade
                        Console.WriteLine("DEVOLUÇÃO FEITA COM SUCESSO!");
                        PontosFidCalc(dados[0], dados[1], diasprev);
                    }
                    else if (confirma == "N")
                    {
                        Inicial();
                    }
                }
                else //dia da devolução programada (do arquivo) diferente do dia atual
                {
                    int diasatraso = diasprev - Convert.ToInt32(diasprev1);
                    double totali, atraso, totalf;
                    totali = Convert.ToDouble(dados[8].Substring(9));
                    atraso = (totali * 0.05) + (20 * diasatraso);
                    totalf = totali + atraso;
                    Console.WriteLine("\n \n Valor total a ser pago: R$" + totalf);
                    Console.WriteLine("\n Confirmar devolução? \n S-SIM \n N-NÃO");
                    string confirma = Console.ReadLine().ToUpper();
                    if (confirma == "S")
                    {
                        StreamReader sr = new StreamReader("CADASTRO LOCACAO.txt ");
                        StringBuilder sb = new StringBuilder();
                        while (!sr.EndOfStream)
                        {
                            string s = sr.ReadLine();
                            if (s.IndexOf(opcoes[opcao - 1]) > -1)
                            {
                                s = s.Replace(opcoes[opcao - 1], dados[0] + ";" + dados[1] + ";" + dados[2] + ";" + dados[3] + ";" + dados[4] + ";" + dados[5] + ";" + dados[6] + ";" + dados[7] + ";" + dados[8] + ";" + "STATUS:ENCERRADO;"+"Data da devolução real:"+date[0]+"/"+date[1]+"/"+date[2]+";Valor pago:R$"+totalf);
                            }
                            sb.AppendLine(s);
                        }
                        sr.Close();
                        StreamWriter sw = new StreamWriter("CADASTRO LOCACAO.txt ");
                        sw.Write(sb);
                        sw.Close();//mudança no Cadastro de Locação
                                   //mudança no Cadastro de veiculo:
                        string carro = "";
                        string[] array2 = File.ReadAllLines("CADASTRO VEI.txt");
                        for (int i = 0; i < array2.Length; i++)
                        {
                            string[] auxiliar = array2[i].Split(';');
                            string cod = auxiliar[6];
                            if (codvei == cod)
                            {
                                carro = array2[i];
                            }
                        }
                        string[] dados1 = carro.Split(';');
                        StreamReader sr1 = new StreamReader("CADASTRO VEI.txt ");
                        StringBuilder sb1 = new StringBuilder();
                        while (!sr1.EndOfStream)
                        {
                            string s1 = sr1.ReadLine();
                            if (s1.IndexOf(carro) > -1)
                            {
                                s1 = s1.Replace(carro, dados1[0] + ";" + dados1[1] + ";" + dados1[2] + ";" + dados1[3] + ";" + dados1[4] + ";" + dados1[5] + ";" + dados1[6] + ";" + "STATUS:DISPONIVEL");
                            }
                            sb1.AppendLine(s1);
                        }
                        sr1.Close();
                        StreamWriter sw1 = new StreamWriter("CADASTRO VEI.txt ");
                        sw1.Write(sb1);
                        sw1.Close();
                        Console.WriteLine("DEVOLUÇÃO FEITA COM SUCESSO!");
                        //pontos fidelidade
                        PontosFidCalc(dados[0], dados[1], diasprev);
                    }
                }
                System.Threading.Thread.Sleep(470);
                Console.Clear();
            }


            else if (a == 0)
            {
                Console.WriteLine("Locação não encontrada.");
                Inicial();
                System.Threading.Thread.Sleep(470);
                Console.Clear();
            }
            a = 0;
        }
        static void PesquisaFid500()
        {
            int a = 0;
            string[] array = File.ReadAllLines("PONTOS.txt");
            string[] clientes = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                string[] auxiliar = array[i].Split(';');
                int pontos = Convert.ToInt32(auxiliar[2].Substring(7));
                if (pontos >= 500)
                {
                    clientes[a] = array[i];
                    a++;
                }
            }
            if (a > 0)
            {
                Console.WriteLine("Clientes com 500 pontos ou mais:");
                for (int i = 0; i < a; i++)
                {
                    Console.WriteLine(clientes[i]);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não há clientes com 500 pontos.");
                Console.ReadKey();
            }
            System.Threading.Thread.Sleep(470);
            Console.Clear();
        }
        static int Codigos()
        {
            int i, c, c1;
            FileStream cod = new FileStream("CODIGOS.txt", FileMode.Open);
            StreamReader ler = new StreamReader(cod);
            string todos;
            todos = ler.ReadToEnd();
            ler.Close();
            string[] cods;
            cods = todos.Split('\n');
            i = cods.Length;
            c = Convert.ToInt32(cods[i - 1]);
            c1 = c + 1;
            FileStream cod1 = new FileStream("CODIGOS.txt", FileMode.Append);
            StreamWriter escrevecod = new StreamWriter(cod1);
            escrevecod.WriteLine(" ");
            escrevecod.Write(c1);
            escrevecod.Close();
            return c1;
        }
        static void Main(string[] args)
        {
            Inicial();
        }
        
    }
}
