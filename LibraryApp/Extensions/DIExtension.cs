using LibraryApp.Entities;
using LibraryApp.Repositories.Infrastructure;
using LibraryApp.Repositories.Interfaces;
using LibraryApp.Servicies.Infrastructure;
using LibraryApp.Servicies.Interfaces;

namespace LibraryApp.Extensions
{
    public static class DIExtension
    {

        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

            // repository
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IBaseRepository<Author>, AuthorRepository>();
            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IBaseRepository<Book>, BookRepository>();
            services.AddScoped<IRentalRepository, RentalRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            //service

            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IRentalService, RentalService>();


        }
    }
}
