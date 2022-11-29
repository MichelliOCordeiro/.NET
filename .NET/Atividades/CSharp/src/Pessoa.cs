using System;
namespace Classes.src
{
    class Pessoa
    {
        private string v;
        private object value;

    public string Nome {get; set;}

    public string CorDaPele {get; set;}

    public double Tamanho {get; set;}

    public string CorOlhos {get; set;}

    public Pessoa(string _nome, string _cordapele, double _tamanho, string _corolhos)
    {
        Nome= _nome;
        CorDaPele= _cordapele;
        Tamanho=_tamanho;
        CorOlhos=_corolhos;
    }

        public Pessoa(string v, object value)
        {
            this.v = v;
            this.value = value;
        }

        public string Comer(string comida)
    {
        return "Vou comer";
    }
    public void Dormir()
    {
        Console.WriteLine("Descanso..");
    }
    public void Estudar()
    {
        Console.WriteLine("Estou concentrada");
    }

    public void Trabalhar()
    {
        Console.WriteLine("Estou trabalhando!");
    }
}
}