﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WMS.Sisdep.Infra.Data.Contexts;

#nullable disable

namespace WMS.Sisdep.Infra.Data.Migrations
{
    [DbContext(typeof(SqlContextMigration))]
    [Migration("20230420015310_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Empresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Complemento")
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Contato")
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Endereço")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("IE")
                        .HasColumnType("int");

                    b.Property<string>("NomeServidor")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<int?>("Numero")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int?>("PortaServidor")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<bool?>("RequerAutenticacao")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("SenhaServidor")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("Telefone")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UF")
                        .IsRequired()
                        .HasColumnType("varchar(2)");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsuarioServidor")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Empresa");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"),
                            Bairro = "Bela Vista",
                            CEP = "03132125",
                            CNPJ = "68348630000195",
                            Cidade = "São Paulo",
                            Complemento = "",
                            Contato = "",
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(798),
                            Email = "nemag@nemag.com",
                            Endereço = "Rua Rocha",
                            IE = 0,
                            NomeServidor = "Nemag",
                            Numero = 71,
                            PortaServidor = 200,
                            RazaoSocial = "NEMAG INFORMÁTICA LTDA",
                            RequerAutenticacao = true,
                            SenhaServidor = "Nemag",
                            Telefone = "",
                            UF = "SP",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(799),
                            UsuarioServidor = "Nemag"
                        },
                        new
                        {
                            Id = new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"),
                            Bairro = "Bela Vista",
                            CEP = "03132125",
                            CNPJ = "11117385000198",
                            Cidade = "São Paulo",
                            Complemento = "",
                            Contato = "",
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(819),
                            Email = "nemag@nemag.com",
                            Endereço = "Rua Rocha",
                            IE = 0,
                            NomeServidor = "Nemag",
                            Numero = 71,
                            PortaServidor = 200,
                            RazaoSocial = "NEMAG TECNOLOGIA LTDA",
                            RequerAutenticacao = true,
                            SenhaServidor = "Nemag",
                            Telefone = "",
                            UF = "SP",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(820),
                            UsuarioServidor = "Nemag"
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Perfil", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Perfil");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1107),
                            Nome = "GESTOR",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1108)
                        },
                        new
                        {
                            Id = new Guid("3fd34b96-f0de-430f-838a-03bab572a776"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1112),
                            Nome = "COORDENADOR",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1113)
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Permissao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("PermiteAdicionar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermiteEditar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermiteInativar")
                        .HasColumnType("bit");

                    b.Property<bool>("PermiteVisualizar")
                        .HasColumnType("bit");

                    b.Property<string>("TelaReferencia")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Permissao");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d8defa05-3568-4c90-a0be-47090346feae"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1138),
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAdicionar = true,
                            PermiteEditar = true,
                            PermiteInativar = true,
                            PermiteVisualizar = true,
                            TelaReferencia = "Cadastro",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1138),
                            UsuarioId = new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091")
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("PerfilId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool?>("PermiteAlterarArquivos")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("PermiteAlterarEquipes")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("PermiteAlterarNotaFiscal")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<bool?>("QuedaInatividade")
                        .IsRequired()
                        .HasColumnType("bit");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsuarioNome")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Usuario");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.HasIndex("UsuarioNome")
                        .IsUnique();

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(891),
                            Email = "gabriel.pantoja@nemag.com.br",
                            Nome = "Gabriel Pantoja",
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAlterarArquivos = true,
                            PermiteAlterarEquipes = true,
                            PermiteAlterarNotaFiscal = true,
                            QuedaInatividade = false,
                            Senha = "12345",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(891),
                            UsuarioNome = "PANTOJA"
                        },
                        new
                        {
                            Id = new Guid("91a02238-897f-48b0-acd4-a040ab922743"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(900),
                            Email = "gustavo.graciano@nemag.com.br",
                            Nome = "Luiz Gustavo",
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAlterarArquivos = true,
                            PermiteAlterarEquipes = true,
                            PermiteAlterarNotaFiscal = true,
                            QuedaInatividade = false,
                            Senha = "12345",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(900),
                            UsuarioNome = "GUSTAVO"
                        },
                        new
                        {
                            Id = new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(904),
                            Email = "filippe@nemag.com.br",
                            Nome = "Filippe Ferreira",
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAlterarArquivos = true,
                            PermiteAlterarEquipes = true,
                            PermiteAlterarNotaFiscal = true,
                            QuedaInatividade = false,
                            Senha = "12345",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(904),
                            UsuarioNome = "FILIPPE"
                        },
                        new
                        {
                            Id = new Guid("c2c9052b-c40a-47d6-a0b8-0d07fbe8dc98"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(908),
                            Email = "super@super.com",
                            Nome = "Super",
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAlterarArquivos = true,
                            PermiteAlterarEquipes = true,
                            PermiteAlterarNotaFiscal = true,
                            QuedaInatividade = false,
                            Senha = "12345",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(908),
                            UsuarioNome = "SUPER"
                        },
                        new
                        {
                            Id = new Guid("8829e7ed-2598-4fb2-8f17-b9077c82b968"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(911),
                            Email = "admin@admin.com",
                            Nome = "Admin",
                            PerfilId = new Guid("0295242e-3dff-4588-b19a-17c911872ed2"),
                            PermiteAlterarArquivos = true,
                            PermiteAlterarEquipes = true,
                            PermiteAlterarNotaFiscal = true,
                            QuedaInatividade = false,
                            Senha = "12345",
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(911),
                            UsuarioNome = "ADMIN"
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.UsuarioEmpresa", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmpresaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("UltimaAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmpresaId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("UsuarioEmpresa");

                    b.HasData(
                        new
                        {
                            Id = new Guid("80cd505a-6aa0-47e8-81a3-beb5ace0f73b"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(960),
                            EmpresaId = new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"),
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(960),
                            UsuarioId = new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091")
                        },
                        new
                        {
                            Id = new Guid("845bda6c-b3ec-4461-a747-dbe6e60d3de6"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(969),
                            EmpresaId = new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"),
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(970),
                            UsuarioId = new Guid("91a02238-897f-48b0-acd4-a040ab922743")
                        },
                        new
                        {
                            Id = new Guid("1eb0e62b-c12d-4e51-a45d-ba2ccb30eb22"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(972),
                            EmpresaId = new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"),
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(973),
                            UsuarioId = new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619")
                        },
                        new
                        {
                            Id = new Guid("59fa0f33-a664-4813-a100-e5c9c9d54792"),
                            DataCadastro = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1030),
                            EmpresaId = new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"),
                            UltimaAlteracao = new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1030),
                            UsuarioId = new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619")
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Versao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .HasColumnType("text");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Versao");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1e2cf1f8-ed9a-4701-9a85-a6a3b2b3c0b8"),
                            Titulo = "1.00"
                        });
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Permissao", b =>
                {
                    b.HasOne("WMS.Sisdep.Infra.Data.Entities.Perfil", "Perfil")
                        .WithMany("Permissao")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMS.Sisdep.Infra.Data.Entities.Usuario", "Usuario")
                        .WithMany("Permissao")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Perfil");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Usuario", b =>
                {
                    b.HasOne("WMS.Sisdep.Infra.Data.Entities.Perfil", "Perfil")
                        .WithMany("Usuario")
                        .HasForeignKey("PerfilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perfil");
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.UsuarioEmpresa", b =>
                {
                    b.HasOne("WMS.Sisdep.Infra.Data.Entities.Empresa", "Empresa")
                        .WithMany("UsuarioEmpresa")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WMS.Sisdep.Infra.Data.Entities.Usuario", "Usuario")
                        .WithMany("UsuarioEmpresa")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Empresa");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Empresa", b =>
                {
                    b.Navigation("UsuarioEmpresa");
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Perfil", b =>
                {
                    b.Navigation("Permissao");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("WMS.Sisdep.Infra.Data.Entities.Usuario", b =>
                {
                    b.Navigation("Permissao");

                    b.Navigation("UsuarioEmpresa");
                });
#pragma warning restore 612, 618
        }
    }
}