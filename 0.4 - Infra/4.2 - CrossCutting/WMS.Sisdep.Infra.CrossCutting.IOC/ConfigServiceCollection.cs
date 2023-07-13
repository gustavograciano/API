using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WMS.Sisdep.Application.Core.AutoMappers;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Application.Services;
using WMS.Sisdep.Domain.Core.AutoMappers;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Domain.Services;
using WMS.Sisdep.Infra.Data.Contexts;
using WMS.Sisdep.Infra.Integration.Interfaces;
using WMS.Sisdep.Infra.Integration.Services;
using WMS.Sisdep.Infra.OldData.AutoMappers;
using WMS.Sisdep.Infra.OldData.Context;
using WMS.Sisdep.Infra.OldData.Interfaces;
using WMS.Sisdep.Infra.OldData.Repositories;
using WMS.Sisdep.Infra.Repository.Interfaces;
using WMS.Sisdep.Infra.Repository.Repositories;

namespace WMS.Sisdep.Infra.CrossCutting.IOC
{
    public static class ConfigServiceCollection
    {
        public static IServiceCollection AddConfig(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<SqlContext>(options =>
                options.UseSqlServer(config.GetConnectionString("Database")));

            services.AddDbContext<OldDataContext>(options =>
                options.UseSqlServer(config.GetConnectionString("OldDatabase")));

            //services.AddMvc(options =>
            //{
            //    var policy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //    options.Filters.Add(new AuthorizeFilter(policy));
            //});

            //services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("user", policy => policy.RequireClaim("Store", "user"));
            //    options.AddPolicy("admin", policy => policy.RequireClaim("Store", "admin"));
            //});

            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new ModelToDTO());
                cfg.AddProfile(new EntityToModel());
                cfg.AddProfile(new BodyToEntity());
                cfg.AddProfile(new OldEntityToOldModel());
                cfg.AddProfile(new OldModelToOldDTO());
            });

            var mapper = mapperConfiguration.CreateMapper();
            services.AddSingleton(mapper);

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            #region AUTHORIZE CLIENT

            services.AddScoped<IAuthorizeClientApplicationService, AuthorizeClientApplicationService>();
            services.AddScoped<IIntegrationAuthorizeClientService, IntegrationAuthorizeClientService>();

            #endregion

            #region AUTENTICAR

            services.AddScoped<IAutenticarApplicationService, AutenticarApplicationService>();
            services.AddScoped<IAutenticarDomainService, AutenticarDomainService>();
            services.AddScoped<IAutenticarRepository, AutenticarRepository>();

            #endregion

            #region USUARIO

            services.AddScoped<IUsuarioApplicationService, UsuarioApplicationService>();
            services.AddScoped<IUsuarioDomainService, UsuarioDomainService>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IUsuarioOldRepository, UsuarioOldRepository>();

            #endregion

            #region VERSAO

            services.AddScoped<IVersaoApplicationService, VersaoApplicationService>();
            services.AddScoped<IVersaoDomainService, VersaoDomainService>();
            services.AddScoped<IVersaoRepository, VersaoRepository>();

            #endregion

            #region PERFIL

            services.AddScoped<IPerfilApplicationService, PerfilApplicationService>();
            services.AddScoped<IPerfilDomainService, PerfilDomainService>();
            services.AddScoped<IPerfilRepository, PerfilRepository>();

            #endregion

            #region PERMISSAO

            services.AddScoped<IPermissaoApplicationService, PermissaoApplicationService>();
            services.AddScoped<IPermissaoDomainService, PermissaoDomainService>();
            services.AddScoped<IPermissaoRepository, PermissaoRepository>();

            #endregion


            #region CONFIG

            services.AddScoped<IConfigApplicationService, ConfigApplicationService>();

            #endregion

            #region EMPRESA

            services.AddScoped<IEmpresaApplicationService, EmpresaApplicationService>();
            services.AddScoped<IEmpresaDomainService, EmpresaDomainService>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();

            #endregion

            return services;
        }
    }
}
