using System;
using Ecom.Core.Interfaces;
using Ecom.Infrastructure.Data;
using Ecom.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Ecom.Infrastructure
{
	public static class InfrasturctureRegistration
	{
		public static IServiceCollection InfrasturctureConfiduration(this IServiceCollection services,IConfiguration configuration )
		{
			services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IUnitOfWork, UnitOfWork>();

			services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(
                configuration.GetConnectionString("DefaultConnection")
                ));
            return services;
		}
    }
}

