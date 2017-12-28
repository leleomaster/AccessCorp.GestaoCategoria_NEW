namespace AccessCorp.GestaoCategoria.CrossCutting.DesignPatterns.Singletons
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
