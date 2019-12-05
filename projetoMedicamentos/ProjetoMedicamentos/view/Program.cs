using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMedicamentos
{
  class Program

    /**
     *  Nome: Sistely Nazareth de Sousa
     *  Matricula: CB3003884  
    **/
  {
    public static Medicamentos med = new Medicamentos();
    static void Main(string[] args)
    {
      int opcao;
      bool menuescolha;

      do
      {
        Console.WriteLine("Projeto Medicamentos\n");
        Console.WriteLine("0 - Encerrar");
        Console.WriteLine("1 - Cadastrar um medicamento ");
        Console.WriteLine("2 - Consultar um medicamento sintético");
        Console.WriteLine("3 - Consultar um medicamento analítico");
        Console.WriteLine("4 - Comprar um medicamento");
        Console.WriteLine("5 - Vender um medicamento");
        Console.WriteLine("6 - Listar medicamentos");
        Console.WriteLine("Opção escolhida:");
        menuescolha = int.TryParse(Console.ReadLine(), out opcao);
        if (menuescolha)
        {
          Medicamento _medicamento = new Medicamento();
          bool auxiliar;
          int Mid, Lid = 0, qtd = 0;
          DateTime venc;
          string Mlab, Mnome;
          Lote mLote = new Lote();

          switch (opcao)
          {
            case 0:
              return;
            case 1:
              Console.Clear();
              Console.WriteLine("CADASTRO DE MEDICAMENTOS");
              do
              {
                Console.Write("ID do medicamento: ");
                auxiliar = int.TryParse(Console.ReadLine(), out Mid);
                if (!auxiliar)
                  Console.WriteLine("Por favor, insira somente números!");
              } while (!auxiliar);

              Console.WriteLine("Nome do medicamento: ");
              Mnome = Console.ReadLine();
              Console.WriteLine("Laboratório: ");
              Mlab = Console.ReadLine();
              Medicamento m1 = new Medicamento(Mid, Mnome, Mlab);
              med.adicionar(m1);
              Console.WriteLine("Medicamento cadastrado com sucesso! Aperte qualquer tecla para voltar ao menu inicial.");
              Console.ReadKey();
              Console.Clear();
              break;
            case 2:
              Console.Clear();
              Console.WriteLine("CONSULTA DE MEDICAMENTOS (SINTÉTICO)");
              do
              {
                Console.WriteLine("ID:");
                auxiliar = int.TryParse(Console.ReadLine(), out Mid);
                if (auxiliar)
                {
                  _medicamento = med.pesquisar(new Medicamento(Mid, "", ""));
                  if (_medicamento.Id == 0)
                    Console.WriteLine("O medicamento inserido não pode ser encontrado.");
                  else
                    Console.WriteLine(_medicamento.ToString());
                }
                else
                  Console.WriteLine("Por favor, insira somente números!");
              } while (!auxiliar);
              Console.ReadKey();
              Console.Clear();
              break;
            case 3:
              Console.Clear();
              Console.WriteLine("CONSULTA DE MEDICAMENTOS (ANALÍTICO)");
              do
              {
                Console.WriteLine("ID: ");
                auxiliar = int.TryParse(Console.ReadLine(), out Mid);
                if (auxiliar)
                {
                  _medicamento = med.pesquisar(new Medicamento(Mid, "", ""));
                  if (_medicamento.Id == 0)
                    Console.WriteLine("O medicamento inserido não pode ser encontrado.");
                  else
                    Console.WriteLine(_medicamento.ToString());

                  foreach (Lote l in _medicamento.Lotes)
                  {
                    Console.WriteLine(l.ToString());
                  }
                }
                else
                  Console.WriteLine("Por favor, insira somente números!");
              } while (!auxiliar);
              Console.ReadKey();
              Console.Clear();
              break;

            case 4:
              Console.Clear();
              Console.WriteLine("COMPRAR MEDICAMENTO");
              venc = DateTime.Now;
              Console.WriteLine("ID: ");
              auxiliar = int.TryParse(Console.ReadLine(), out Mid);
              _medicamento = med.pesquisar(new Medicamento(Mid, "", ""));
              if (_medicamento.Id == 0)
                Console.WriteLine("O medicamento não pode ser encontrado!");
              else
              {
                Console.WriteLine("SOBRE O LOTE");
                do
                {
                  Console.WriteLine("ID Lote ");
                  auxiliar = int.TryParse(Console.ReadLine(), out Lid);
                  if (!auxiliar)
                    Console.WriteLine("Por favor, insira somente números!");
                } while (!auxiliar);
                do
                {
                  Console.WriteLine("Quantidade");
                  auxiliar = int.TryParse(Console.ReadLine(), out qtd);
                  if (!auxiliar)
                    Console.WriteLine("Por favor, insira somente números! ");
                } while (!auxiliar && Lid < 0);

                do
                {
                  Console.WriteLine("Data de vencimento em formato (DD/MM/AAAA)");
                  auxiliar = DateTime.TryParse(Console.ReadLine(), out venc);
                  if (!auxiliar)
                  {
                    Console.WriteLine("Data inválida. Veja se a mesma se encontra no formato DD/MM/AAAA");
                  }
                } while (!auxiliar);
                Console.WriteLine("Compra realizada! Aperte qualquer tecla para voltar ao menu inicial.");
              }

              Lote nLote = new Lote(Lid, qtd, venc);
              _medicamento.comprar(nLote);

              Console.ReadKey();
              Console.Clear();
              break;
            case 5:
              Console.Clear();
              Console.WriteLine("VENDER MEDICAMENTO");
              Console.WriteLine("ID:");
              auxiliar = int.TryParse(Console.ReadLine(), out Mid);
              _medicamento = med.pesquisar(new Medicamento(Mid, "", ""));
              if (_medicamento.Id == 0)
                Console.WriteLine("O medicamento não pode ser encontrado.");
              else
              {
                do
                {
                  Console.WriteLine("Quantidade: ");
                  auxiliar = int.TryParse(Console.ReadLine(), out qtd);
                  if (!auxiliar && Lid < 0)
                    Console.WriteLine("A quantidade precisa ser numeros positivos!");

                } while (!auxiliar && Lid < 0);
                _medicamento.vender(qtd);
                Console.WriteLine("Produto vendido! Aperte qualquer tecla para voltar ao menu inicial.");
              }
              Console.ReadKey();
              break;
            case 6:
              foreach (Medicamento m in med.ListaMedicamentos)
              {
                Console.WriteLine(m.ToString());
              }
              Console.ReadKey();
              Console.Clear();
              break;
            default:
              Console.WriteLine("Opção inválida. Insira novamente.");
              Console.ReadKey();

              break;

          }

        }
        else
        {
          Console.WriteLine("Opção inválida. Insira novamente.");
          opcao = 7;
          Console.ReadKey();
          Console.Clear();
        }

      } while (opcao != 0);



    }
  }
}
