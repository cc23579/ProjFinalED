using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class ListaSimples<Dado> : IRegistro
             where Dado : IComparable<Dado>
{
  NoLista<Dado> primeiro, ultimo, anterior, atual;
  int quantosNos;
  bool primeiroAcessoDoPercurso;

  public ListaSimples()
  {
    primeiro = ultimo = anterior = atual = null;
    quantosNos = 0;
    primeiroAcessoDoPercurso = false;
  }

  public void PercorrerLista()
  {
    atual = primeiro;
    while (atual != null)
    {
      Console.WriteLine(atual.Info);
      atual = atual.Prox;
    }
  }
  public bool EstaVazia
  {
    get => primeiro == null;
  }
  public NoLista<Dado> Primeiro
  {
    get => primeiro;
  }
  public NoLista<Dado> Ultimo
  {
    get => ultimo;
  }
  public int QuantosNos
  {
    get => quantosNos;
  }

    int IRegistro.TamanhoRegistro => throw new NotImplementedException();

    public void InserirAntesDoInicio(Dado novoDado)
  {
    var novoNo = new NoLista<Dado>(novoDado);

    if (EstaVazia)
       ultimo = novoNo;

    novoNo.Prox = primeiro;
    primeiro    = novoNo;
    quantosNos++;
  }

  public void InserirAposFim(Dado novoDado)
  {
    var novoNo = new NoLista<Dado>(novoDado);

    if (EstaVazia)
      primeiro = novoNo;
    else
      ultimo.Prox = novoNo;

    ultimo = novoNo;
    quantosNos++;
  }

  public void Listar(ListBox lsb)
  {
    lsb.Items.Clear();
    atual = primeiro;
    while (atual != null)
    {
      lsb.Items.Add(atual.Info);
      atual = atual.Prox;
    }
  }

    //Apenas para não aparecer erro, pois o "Dado" deve implementar IRegistro e IComparable
    //na árvore a lista é tratada como um dado
    void IRegistro.LerRegistro(BinaryReader arquivo, long qualRegistro)
    {
        throw new NotImplementedException();
    }

    void IRegistro.GravarRegistro(BinaryWriter arquivo)
    {
        throw new NotImplementedException();
    }

}
