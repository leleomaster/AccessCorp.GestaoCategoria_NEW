using AccessCorp.GestaoCategoria.Repository.Implementations;
using AccessCorp.GestaoCategoria.Repository.Interfaces;
using AccessCorp.GestaoCategoria.Service.Implementations;
using AccessCorp.GestaoCategoria.Service.Interfaces;
using Ninject;

namespace AccessCorp.GestaoCategoria.IoC
{
    public static class ServiceModule
    {
        public static void Bind(IKernel kernel)
        {
            kernel.Bind<ITextoCampoService>().To<TextoCampoService>();
            kernel.Bind<ICampoService>().To<CampoService>();
            kernel.Bind<ICategoriaService>().To<CategoriaService>();
            kernel.Bind<ISubCategoriaService>().To<SubCategoriaService>();
            kernel.Bind<ITipoCampoService>().To<TipoCampoService>();
            
            kernel.Bind<ITextoCampoRepository>().To<TextoCampoRepository>();
            kernel.Bind<ICampoRepository>().To<CampoRepository>();
            kernel.Bind<ICategoriaRepository>().To<CategoriaRepository>();
            kernel.Bind<ISubCategoriaRepository>().To<SubCategoriaRepository>();
            kernel.Bind<ITipoCampoRepository>().To<TipoCampoRepository>();
        }
    }
}
