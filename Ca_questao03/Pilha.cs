using System;
using Ca_questao03;

internal class Pilha
{
    private NoPilha topo;
    private int porto;
    public Pilha()
    {
        Topo = null;
    }

    public Pilha(NoPilha topo)
    {
        this.Topo = topo;
    }

    internal NoPilha Topo { get => topo; set => topo = value; }
    public int Porto { get => porto; set => porto = value; }

    public bool EstarVazia()
    {
        return topo == null;
    }

    public void ExibirPilha()
    {
        Console.WriteLine("Pilha:");
        NoPilha temp = topo;
        while (temp != null)
        {
            Console.WriteLine(temp.Codigo);
            temp = temp.Anterior;
        }
    }

        public void Inserir(string codigo)
    {
        if (EstarVazia())
        {
            NoPilha novaPilha = new NoPilha(codigo);
            topo = novaPilha;
        }
        else
        {
            NoPilha novaPilha = new NoPilha(codigo, topo);
            topo = novaPilha;
        }
    }

    public bool Remover()
    {
        if (EstarVazia())
            return false;
        else
        {
            topo = topo.Anterior;
            return true;
        }
    }

    public int QuantNaPilha()
    {
        int n = 0;
        NoPilha temp = topo;
        while (temp != null)
        {
            temp = temp.Anterior;
            n++;
        }
        return n;
    }

    public bool EstaCheia()
    {
        return QuantNaPilha() >= 3;
    }

    public bool CodigoExiste(string codigo)
    {
        NoPilha temp = topo;
        while (temp != null)
        {
            if (temp.Codigo.Equals(codigo))
                return true;
            else
                temp = temp.Anterior;
        }

        return false;
    }

    public void TrocarPeca(string pecaOriginal, string pecaNova)
    {
        NoPilha temp = topo;

        while (temp != null)
        {
            if (temp.Codigo.Equals(pecaOriginal))
            {
                temp.Codigo = pecaNova;
                Console.WriteLine($"Peça trocada: {pecaOriginal} por {pecaNova}");
                return;
            }
            else
                temp = temp.Anterior;
        }

        Console.WriteLine("A peça original não está na pilha.");
    }
}
