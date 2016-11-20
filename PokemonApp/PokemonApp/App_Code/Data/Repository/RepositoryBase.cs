using PokemonApp.App_Code.CrossCutting.Collections;
using PokemonApp.App_Code.Data.Interfaces;
using System;
using System.Collections.Generic;

namespace PokemonApp.App_Code.Data.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        public abstract RNList<T> GetAll();
        public abstract T GetById(int id);
    }
}