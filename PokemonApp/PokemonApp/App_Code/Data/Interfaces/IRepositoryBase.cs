using PokemonApp.App_Code.CrossCutting.Collections;
using System.Collections.Generic;

namespace PokemonApp.App_Code.Data.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        RNList<T> GetAll();
        T GetById(int id);
    }
}