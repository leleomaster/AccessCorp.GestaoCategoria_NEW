using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AccessCorp.GestaoCategoria.Web.Comunicacao.Singleton
{
    public sealed class SigletionGeneric<T> where T : class, new()
    {
        private static T instance;

        public static T Instance()
        {
            lock (typeof(T))
                if (instance == null) instance = new T();

            return instance;
        }
    }
}