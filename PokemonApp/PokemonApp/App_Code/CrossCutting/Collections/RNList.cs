using System;

namespace PokemonApp.App_Code.CrossCutting.Collections
{
    public class RNList<T> where T : class
    {
        RNListItem primeiro = null; // ponteiro para o primeiro elemento da lista
        RNListItem ultimo = null; // ponteiro para o ultimo elemento da lista
        int qtde = 0;

        private void InserirNaPosicao(RNListItem anterior, T valor)
        {
            RNListItem novo = new RNListItem();//Cria o novo nodo a ser armazenado
            novo.Dado = valor;//Guarda o dado no nodo
            if (anterior == null)//Nodo Null -> inserir no inicio da Lista
            {
                if (qtde == 0)//Se não tem dados na lista
                {
                    primeiro = novo;//Primeiro recebe o novo
                    ultimo = novo;//Como só tem um dado o ultimo é o primeiro também
                }
                else//Se já tem dados salvos na Lista
                {
                    novo.Proximo = primeiro;//O novo se torna o primeiro e aponta para o segundo
                    primeiro.Anterior = novo;//E o primeiro que agora é segundo aponta para o primeiro
                    primeiro = novo;//Atualiza a variavel primeiro que agora é o novo
                }
            }
            else//Se tem dados no nodo
            {
                //O nodo recebido é o anterior a posição a ser inserido
                if (anterior.Proximo != null)//Se existe um proximo Nodo, então seu endereço anterior aponta para o novo, senão é nulo
                    anterior.Proximo.Anterior = novo;
                else//Se o próximo do anterior é nulo o novo nodo é o ultimo
                    ultimo = novo;//Atualiza o ultimo valor

                novo.Proximo = anterior.Proximo;//O novo recebe o proximo do anterior
                novo.Anterior = anterior;//O anterior do novo aponta para o anterior
                anterior.Proximo = novo;//E o proximo do anterior aponta para o novo
            }
            qtde++;
        }

        public void InserirNoInicio(T valor)
        {
            InserirNaPosicao(null, valor);
        }

        public void InserirNoFim(T valor)
        {
            if (qtde == 0)
                InserirNoInicio(valor);
            else
            {
                RNListItem aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }
        }

        public void InserirNaPosicao(T valor, int posicao)
        {
            if (posicao > qtde || posicao < 0)
                throw new Exception("Não é possível inserir.");
            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                //descobre qual é o nodo que será incluído
                RNListItem aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }

        public T RemoverDaPosicao(int posicao)
        {
            T dadoRemovido = null;

            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)//Se for para remover a primeira posição
            {
                dadoRemovido = (T)primeiro.Dado;

                if (qtde == 1)//Se tem apenas um dado
                    primeiro = ultimo = null;//Lista vazia
                else
                {
                    primeiro = primeiro.Proximo;//Se é a primeira posição o segundo se torna primeiro
                    primeiro.Anterior = null;//Atualiza o anterior para nulo
                }
            }
            else//Se a posição é maior que 0
            {
                //descobre qual é o Nodo que será excluido
                RNListItem aux = primeiro;
                for (int i = 0; i < posicao; i++)
                    aux = aux.Proximo;
                //////////////////////////////////////////

                dadoRemovido = (T)aux.Dado;
                aux.Anterior.Proximo = aux.Proximo;//Atualiza o ponteiro próximo do Nodo anterior do que foi removido

                if (aux.Proximo == null)//Se o proximo é nulo, então é o ultimo Nodo
                    ultimo = ultimo.Anterior;//Atualiza o ultimo Nodo
                else//Se existe um proximo nodo
                    aux.Proximo.Anterior = aux.Anterior;//Atualiza o ponteiro anterior do Nodo sucessor que foi removido
            }
            qtde--;
            return dadoRemovido;
        }

        public T Find(string propertyName, object value)
        {
            if(primeiro.Dado.GetType().GetProperty(propertyName) != null)
            {
                RNListItem aux = primeiro;
                while (aux != null)
                {
                    var propertyValue = aux.Dado.GetType().GetProperty(propertyName).GetValue(aux.Dado, null);
                    if (propertyValue.ToString() == value.ToString())
                        return (T)aux.Dado;
                    else
                        aux = aux.Proximo;
                }
                return null;
            }
            else
            {
                return null;
            }
        }

        public T RetornaPrimeiroElemento()
        {
            if (qtde == 0)
                return null;

            return (T)primeiro.Dado;
        }

        public T RetornaUltimoElemento()
        {
            if (qtde == 0)
                return null;

            return (T)ultimo.Dado;
        }

        public T RetornarDaPosicao(int posicao)
        {
            if (posicao >= qtde || posicao < 0 || qtde == 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)//Se for para remover a primeira posição
                return (T)primeiro.Dado;
            else
            {
                RNListItem aux = primeiro;
                for (int i = 0; i < posicao; i++)
                    aux = aux.Proximo;
                return (T)aux.Dado;
            }
        }

        public int Count()
        {
            return qtde;
        }
    }
}