namespace AccessCorp.GestaoCategoria.EntityFramework.Factories
{
    public class FactoryDbContextAccessCorp
    {
        private static DbContextAccessCorp _dbContextAccessCorp;
        public static DbContextAccessCorp CreateDbContextAccessCorp()
        {
            if(_dbContextAccessCorp == null)
            {
                _dbContextAccessCorp = new DbContextAccessCorp();
            }

            return _dbContextAccessCorp;
        }
    }
}
