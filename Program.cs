using System;
using System.Xml;

namespace Tec
{

    public class Pessoas 
    {
    //metodos : vão ser herdados por class clientes e funcionarios 
        public void AdicionarPessoas() // vai permitir adiciona clinetes e funcionarios 
        { }

        public void ApagarPessoas() // vai permitir eleminar registos de pessoas
        { }

        public void EditarPessoas() // vai permitir editar registos de pessoas
        { }

    //estados //: vão ser herdados por class clientes e funcionarios 
        bool activoInactivo; //actico ou inactivo 

        int Idade; // idade
        DateTime dataNascimento; // data nascimento 
       
        char nome; //nome
        
        //porperty(s)
        public int idadePessoas
        {
            get
            {
                return Idade;
            }

            set
            {
                Idade = value;
            }
        }

        public bool ActInact
        {
            get 
            {
                return activoInactivo;
            }
            set
            {
                activoInactivo = value;
            }
        }

        public char nomePessoas
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime DataNascimentoPessoas //verificar formato de data
        {
            get
            {
                return dataNascimento;
            }
            set
            {
                dataNascimento = value;
            }
        }
    }

    public class Funcionarios : Pessoas
    {
    //metodos 
    
    //estados
    bool tipoFuncionario; // variavel para saber se é tecnico de sofware ou hardware 
    int codigoFuncionario; // codigo do funcionario 

        public int CodigoFuncionarioPessoas
        {
            get
            {
                return codigoFuncionario;
            }

            set
            {
                codigoFuncionario = value;
            }
        }

        public bool tipoFuncionarioPessoas
        {
            get
            {
                return tipoFuncionario;
            }

            set
            {
                tipoFuncionario = value;
            }
        }


        //obj funcionario    

    }

    public class Clientes : Pessoas
    {
    //metodos 
    
    //estados
    bool tipoCliente; // cliente particular ou empresa
    int codigoCliente; // codigo de cliente

        public bool tipoClientePessoas
        {
            get
            {
                return tipoCliente;
            }

            set
            {
                tipoCliente = value;
            }
        }

        public int codigoClientePessoas
        {
            get
            {
                return codigoCliente;
            }

            set
            {
                codigoCliente = value;
            }
        }
        
    //obj: cliente
    
    }
    
    public class equipamentos 
    {
    //metodos
        public void AdicionarEquipamentos() // vai permitir adicionar equipamentos dos registos de equipamentos 
        { }
        public void RemoverEquipamentos() // vai permitir remover equipamentos dos registos de equipamentos 
        { }
        public void EditarEquipamentos() // vai permitir edtitar os registos de equipamentos 
        { }
    
    //estados 
        char descricao; // decrição do equipamento
        char marca; // marca do equipamento 
        bool garantia; // se esta em garantia ou não
        int nSerie;// numero de serie 

        public char descricaoEquipamentos
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

        public char marcaEquipamentos
        {
            get
            {
                return marca;
            }

            set
            {
                marca = value;
            }
        }

        public bool garantiaEquipamentos
        {
            get
            {
                return garantia;
            }

            set
            {
                garantia = value;
            }
        }

        public int nSerieEquipamentos
        {
            get
            {
                return nSerie;
            }

            set
            {
                nSerie = value;
            }
        }



    }

    public class computador : equipamentos
    {
    //metodos:

    //estados:
    
    //obj - Desktop, Laptop, Server

    }

    public class mobile : equipamentos
    { 
    //metodos:
    
    //estados: 
    
    //obj - telemoveis, tablets 
    }
    
    public class reparacao
    {
    //metodos
        public void IniciarReparacao() // vai permitir criar registo de reparação 
        { }
        public void EditarReparacao() // vai permitir editar registo de reparação 
        { }
        public void RemoverReparacao() // vai permitir remover registo de reparação 
        { }
    
    //estados
        int codigoRep;
        char descricao;

        public int codigoRepReparacoes
        {
            get
            {
                return codigoRep;
            }

            set
            {
                codigoRep = value;
            }
        }

        public char descricaoReparacoes
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

    }

    public class repsoftware : reparacao
    { 
    
    }

    public class rephardware : reparacao
    { 
    
    }


    public class caixa
    {
    //metodos: 
        public void EntradaCaixa() 
        { }
        public void SaidaCaixa()
        { }
        public void EditarMovimentosCaixa()
        { }

    //estados - 
        int saldo;
        int numeroRegisto;
        char descricao;

        public int saldoCaixa
        {
            get
            {
                return saldo;
            }

            set
            {
                saldo = value;
            }
        }

        public int numeroRegistoCaixa
        {
            get
            {
                return numeroRegisto;
            }

            set
            {
                numeroRegisto = value;
            }
        }

        public char descricaoCaixa
        {
            get
            {
                return descricao;
            }

            set
            {
                descricao = value;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
