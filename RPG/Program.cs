using System;

namespace RPG
{
    internal class Program
    {//  \n
        static void Main(string[] args)
        {

            Status statusMain = new Status();
            Funcao funcao = new Funcao();
            Arma arma = new Arma();
            Personagem personagem = new Personagem();
            Mochila mochila = new Mochila();
            Corpo corpo = new Corpo();
            
            

            string nome = new string("");
            int decisao1 = 0;
            bool menu = true;
            while (menu == true)
            {
                pontoinicial:
                Console.WriteLine("Olá jogador, você deseja jogar?\n" +
                    "1 - Sim.\n" +
                    "2 - Não.\n");
                decisao1 = int.Parse(Console.ReadLine());
                Console.Clear();
                if (decisao1 == 1)
                {
                    Console.Write("Bem vindo jogador, vamos criar primeiramente a sua ficha:\n" +
                        "Por qual nome você deseja ser chamado? ");                                                 //nome
                    personagem.nome = Console.ReadLine();
                    Console.Clear();

//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("Certo, " + personagem.nome + " De qual classe você deseja ser?\n ");                   //classe
                    personagem.classe = Console.ReadLine();
                    Console.Clear();

//------------------------------------------------------------------------------------------------------------------------------------------------------

                    
                    Console.WriteLine("\nÓtima escolha, agora vamos ao ouro que você tem. Que será gerado aleatóriamente:\n ");
                    mochila.espaco1 = funcao.DadoD10() * 5;
                    Console.WriteLine("Você obteve: " + mochila.espaco1 + " Ouro.");                                //Ouro
                    

//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("\nAgora vamos a arma que deseja usar na mão direita " + personagem.nome+"." +
                        " Digite o nome:\n ");
                    corpo.armaD.nomeArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.WriteLine("\nela é de corte, impacto ou arremesso/munição?\n ");        //mão direita
                    corpo.armaD.tipoArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.Write("\nQual o dano dela?\n");
                    corpo.armaD.danoArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.Write("\nQual o alcance de sua arma? Curto, médio ou alto?\n");
                    corpo.armaD.alcanceArma = Console.ReadLine();
                    Console.Clear();


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("\nAgora vamos a arma que deseja usar na mão Esquerda " + personagem.nome + "." +
                       " Digite o nome:\n ");
                    corpo.armaE.nomeArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.WriteLine("\nela é de corte, impacto, arremesso/munição?\n ");        //mão esquerda
                    corpo.armaE.tipoArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.Write("\nQual o dano dela?\n");
                    corpo.armaE.danoArma = Console.ReadLine();
                    //------------------------------------------------
                    Console.Write("\nQual o alcance de sua arma? Curto, médio ou alto?\n");
                    corpo.armaE.alcanceArma = Console.ReadLine();
                    Console.Clear();


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("Vamos agora escolher seus equipamentos. Se não for usar nada, aperte 'Enter'. ");
                    Console.WriteLine("Qual elmo irá usar?\n ");
                    corpo.cabeca = Console.ReadLine();
                    Console.WriteLine("Qual peitoral irá usar?\n ");
                    corpo.peito = Console.ReadLine();
                    Console.WriteLine("Qual luvas irá usar?\n ");
                    corpo.mao = Console.ReadLine();
                    Console.WriteLine("Qual calças irá usar?\n ");
                    corpo.perna = Console.ReadLine();
                    Console.WriteLine("Qual sapatos irá usar?\n ");
                    corpo.pé = Console.ReadLine();
                    Console.Clear();


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.Write("Certo, vamos prosseguir, conte-me um pouco do seu passado jogador. \n");         //história
                    personagem.historia = Console.ReadLine();
                    
                    Console.Clear();


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("Nossa, que interessante, você viveu bastante coisa antes de" +
                        " estar aqui não é mesmo? Mas acredite, sua aventura está apenas começando," +              //Objetivo
                        "sabendo disso, o que você busca viver agora? ");
                    personagem.objetivo = Console.ReadLine();
                    Console.Clear();


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    Console.WriteLine("vamos agora fazer um teste, me diga," +
                        " quais são suas habilidades de luta?");                                                    //habilidades
                    personagem.habilidade1 = Console.ReadLine();
                    personagem.habilidade2 = Console.ReadLine();
                    personagem.habilidade3 = Console.ReadLine();
                    Console.Clear();



//------------------------------------------------------------------------------------------------------------------------------------------------------

                    statusMain = funcao.DadoDefinicaoDeStts();
                    Console.WriteLine("Certo, Então vamos agora gerar seus status de forma aleatória, através de dados.");
                    Console.WriteLine("Força: " + statusMain.forca);
                    Console.WriteLine("Destreza: " + statusMain.destreza);                                                //dados aleatórios de status
                    Console.WriteLine("Constituição: " + statusMain.constituicao);
                    Console.WriteLine("Inteligencia: " + statusMain.inteligencia);
                    Console.WriteLine("Sabedoria: " + statusMain.sabedoria);
                    Console.WriteLine("Carisma: " + statusMain.carisma);


//------------------------------------------------------------------------------------------------------------------------------------------------------

                    int contador = 0;
                inicio:
                    Console.WriteLine("\npara continuar digite 1, para repetir o processo digite 2 (opção 2 só pode ser repetida 3 vezes).");
                    int decisao2 = int.Parse(Console.ReadLine());
                    if(decisao2 == 1)
                    {
                        Console.WriteLine("Parabéns, você concluiu seu registro");
                    }
                    else if(decisao2 ==2 )
                    {
                        contador++;
                        if(contador == 3)
                        {
                            Console.WriteLine("Chega amigão, vai ficar mudando pra sempre?");
                        }
                        else
                        {                                                                                                 //Gerador aleatório de status
                            goto inicio;
                        }
                    }      
                    else
                    {
                        Console.WriteLine("Não existe essa opção");
                    }
                    
                    




                    Console.ReadLine();

                }
                else if(decisao1 == 2)
                {
                    menu = false;
                }
                else
                {
                    Console.WriteLine("Não existe essa opção. Vamos tentar de novo:\n");
                    goto pontoinicial;
                }

//------------------------------------------------------------------------------------------------------------------------------------------------------
                Console.Clear();
                Console.WriteLine("Vamos lá jogador, estamos quase acabando, em sua mão(s) ficará a(s) arma(s) escolhida(s) para lutar,\n porém você também pode agregar alguns itens em seu inventário " +
                    "que serão úteis para suas missões,\n com quais você irá começar? (Lembrando que o espaço 1 ja é preenchido com ouro.\n");
                Console.WriteLine("\nespaço 1 contém: " + mochila.espaco1 + "Ouro");
                mochila.espaco2 = Console.ReadLine();
                Console.WriteLine("espaço 2 preenchido com: " + mochila.espaco2);
                mochila.espaco3 = Console.ReadLine();
                Console.WriteLine("espaço 3 preenchido com: " + mochila.espaco3);
                mochila.espaco4 = Console.ReadLine();
                Console.WriteLine("espaço 4 preenchido com: " + mochila.espaco4);
                mochila.espaco5 = Console.ReadLine();                                                                       //adicionando itens na mochila
                Console.WriteLine("espaço 5 preenchido com: " + mochila.espaco5);
                mochila.espaco6 = Console.ReadLine();
                Console.WriteLine("espaço 6 preenchido com: " + mochila.espaco6);
                mochila.espaco7 = Console.ReadLine();
                Console.WriteLine("espaço 7 preenchido com: " + mochila.espaco7);
                mochila.espaco8 = Console.ReadLine();
                Console.WriteLine("espaço 8 preenchido com: " + mochila.espaco8);
                mochila.espaco9 = Console.ReadLine();
                Console.WriteLine("espaço 9 preenchido com: " + mochila.espaco9);
                mochila.espaco10 = Console.ReadLine();
                Console.WriteLine("espaço 10 preenchido com: " + mochila.espaco10);

                //------------------------------------------------------------------------------------------------------------------------------------------------------

                Console.Clear();
                Console.WriteLine("Uooou, você é realmente forte para um iniciante. Ótimo aventureiro,\n" +
                      " sua ficha está pronta. Só te peço que antes de começarmos, você confirme os dados, ok?\n" +
                      "Vamos la:\n");
                Console.WriteLine("Nome: " + personagem.nome +                                                 //Ficha completa
                    "\n Classe: " + personagem.classe +
                    "\n Ouro: " + mochila.espaco1 +
                    "\n Sua arma da mão direita: " + corpo.armaD +
                    "\n Sua arma da mão esquerda: " + corpo.armaE +
                    "\n Seus equipamentos são: " + corpo.cabeca + ", " + corpo.peito + ", " + corpo.mao + ", " + corpo.perna + ", " + corpo.pé + "." +
                    "\n No seu inventário tem esses itens em seus respectivos 10 espaços:" +
                    "\n1- " + mochila.espaco1 +
                    "\n2- " + mochila.espaco2 +
                    "\n3- " + mochila.espaco3 +
                    "\n4- " + mochila.espaco4 +
                    "\n5- " + mochila.espaco5 +
                    "\n6- " + mochila.espaco6 +
                    "\n7- " + mochila.espaco7 +
                    "\n8- " + mochila.espaco8 +
                    "\n9- " + mochila.espaco9 +
                    "\n10- " + mochila.espaco10 +
                    "\nSeus status: " +
                    "\nForça" + statusMain.forca +
                    "\nDestreza" + statusMain.destreza +
                    "\nConstituição" + statusMain.constituicao +
                    "\nInteligência" + statusMain.inteligencia +
                    "\nSabedoria" + statusMain.sabedoria +
                    "\nCarisma" + statusMain.carisma +
                    "\nUm pouco sobre seu passado: " + personagem.historia +
                    "\nSeu objetivo daqui em diante: " + personagem.objetivo +
                    "\nSuas habilidades:\n " + personagem.habilidade1 + "\n" + personagem.habilidade2 + "\n" + personagem.habilidade3 +
                    "\nEstá tudo correto? ") ;


            }

        }
    }
}
