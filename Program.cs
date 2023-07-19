using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[]args)
        {
            Pessoa_Fisica pf = new Pessoa_Fisica();
            float val_pag;
            Console.WriteLine("Informar Nome");
            String var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            String var_endereco = Console.ReadLine();
            Console.WriteLine("Informar Pessoa fisica(f) ou juridica(j)");
            String var_tipo = Console.ReadLine();
            if(var_tipo == "f")
            {
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                pf.cpf = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("--------Pessoa Física-------");
                Console.WriteLine("Nome:" + pf.nome);
                Console.WriteLine("Endereço:" + pf.endereco);
                Console.WriteLine("CPF:" + pf.cpf);
                Console.WriteLine("RG:" + pf.rg);
                Console.WriteLine("Valor de Compra:" + pf.valor.ToString("C"));
                Console.WriteLine("Imposto:" + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Imposto:" + pf.total.ToString("C"));                 
            }

            if(var_tipo == "j")
            {
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pf.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pf.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra:");
                val_pag = float.Parse(Console.ReadLine());
                
            }
           
        }
    }
}
