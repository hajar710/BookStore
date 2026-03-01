using Application.Interfaces.IRepos;
using Application.Interfaces.IServices;
using Application.Services;
using Autofac;
using Infrastructure.Repositories;


namespace Presentation
{
    public static class AutofacConfigurations
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            // DBContext
            builder.RegisterType<DBContext>().AsSelf().InstancePerLifetimeScope();

            // Repositories
            builder.RegisterType<AuthorRepository>().As<IAuthorRepository>().InstancePerLifetimeScope();
            builder.RegisterType<BookRepository>().As<IBookRepository>().InstancePerLifetimeScope();

            // Services
            builder.RegisterType<AuthorService>().As<IAuthorService>().InstancePerLifetimeScope();
            builder.RegisterType<BookService>().As<IBookService>().InstancePerLifetimeScope();

            return builder.Build();
        }
}
