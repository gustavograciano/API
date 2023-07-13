using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WMS.Sisdep.Infra.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RazaoSocial = table.Column<string>(type: "varchar(200)", nullable: false),
                    Endereço = table.Column<string>(type: "varchar(200)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(200)", nullable: true),
                    Cidade = table.Column<string>(type: "varchar(200)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(200)", nullable: false),
                    CEP = table.Column<string>(type: "varchar(8)", nullable: false),
                    CNPJ = table.Column<string>(type: "varchar(30)", nullable: false),
                    IE = table.Column<int>(type: "int", nullable: true),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    Contato = table.Column<string>(type: "varchar(200)", nullable: true),
                    Telefone = table.Column<string>(type: "varchar(50)", nullable: true),
                    Email = table.Column<string>(type: "varchar(200)", nullable: false),
                    NomeServidor = table.Column<string>(type: "varchar(200)", nullable: false),
                    PortaServidor = table.Column<int>(type: "int", nullable: false),
                    RequerAutenticacao = table.Column<bool>(type: "bit", nullable: false),
                    UsuarioServidor = table.Column<string>(type: "varchar(200)", nullable: false),
                    SenhaServidor = table.Column<string>(type: "varchar(200)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Versao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Usuario = table.Column<string>(type: "varchar(100)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(100)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    PermiteAlterarArquivos = table.Column<bool>(type: "bit", nullable: false),
                    QuedaInatividade = table.Column<bool>(type: "bit", nullable: false),
                    PermiteAlterarEquipes = table.Column<bool>(type: "bit", nullable: false),
                    PermiteAlterarNotaFiscal = table.Column<bool>(type: "bit", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Usuario_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TelaReferencia = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PermiteVisualizar = table.Column<bool>(type: "bit", nullable: false),
                    PermiteEditar = table.Column<bool>(type: "bit", nullable: false),
                    PermiteInativar = table.Column<bool>(type: "bit", nullable: false),
                    PermiteAdicionar = table.Column<bool>(type: "bit", nullable: false),
                    PerfilId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Permissao_Perfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "Perfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissao_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioEmpresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UltimaAlteracao = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioEmpresa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresa_Empresa_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsuarioEmpresa_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Empresa",
                columns: new[] { "Id", "Bairro", "CEP", "CNPJ", "Cidade", "Complemento", "Contato", "DataCadastro", "Email", "Endereço", "IE", "NomeServidor", "Numero", "PortaServidor", "RazaoSocial", "RequerAutenticacao", "SenhaServidor", "Telefone", "UF", "UltimaAlteracao", "UsuarioServidor" },
                values: new object[,]
                {
                    { new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"), "Bela Vista", "03132125", "68348630000195", "São Paulo", "", "", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(798), "nemag@nemag.com", "Rua Rocha", 0, "Nemag", 71, 200, "NEMAG INFORMÁTICA LTDA", true, "Nemag", "", "SP", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(799), "Nemag" },
                    { new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"), "Bela Vista", "03132125", "11117385000198", "São Paulo", "", "", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(819), "nemag@nemag.com", "Rua Rocha", 0, "Nemag", 71, 200, "NEMAG TECNOLOGIA LTDA", true, "Nemag", "", "SP", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(820), "Nemag" }
                });

            migrationBuilder.InsertData(
                table: "Perfil",
                columns: new[] { "Id", "DataCadastro", "Nome", "UltimaAlteracao" },
                values: new object[,]
                {
                    { new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1107), "GESTOR", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1108) },
                    { new Guid("3fd34b96-f0de-430f-838a-03bab572a776"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1112), "COORDENADOR", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1113) }
                });

            migrationBuilder.InsertData(
                table: "Versao",
                columns: new[] { "Id", "Descricao", "Titulo" },
                values: new object[] { new Guid("1e2cf1f8-ed9a-4701-9a85-a6a3b2b3c0b8"), null, "1.00" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "Id", "DataCadastro", "Email", "Nome", "PerfilId", "PermiteAlterarArquivos", "PermiteAlterarEquipes", "PermiteAlterarNotaFiscal", "QuedaInatividade", "Senha", "UltimaAlteracao", "Usuario" },
                values: new object[,]
                {
                    { new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(904), "filippe@nemag.com.br", "Filippe Ferreira", new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, false, "12345", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(904), "FILIPPE" },
                    { new Guid("8829e7ed-2598-4fb2-8f17-b9077c82b968"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(911), "admin@admin.com", "Admin", new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, false, "12345", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(911), "ADMIN" },
                    { new Guid("91a02238-897f-48b0-acd4-a040ab922743"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(900), "gustavo.graciano@nemag.com.br", "Luiz Gustavo", new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, false, "12345", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(900), "GUSTAVO" },
                    { new Guid("c2c9052b-c40a-47d6-a0b8-0d07fbe8dc98"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(908), "super@super.com", "Super", new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, false, "12345", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(908), "SUPER" },
                    { new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(891), "gabriel.pantoja@nemag.com.br", "Gabriel Pantoja", new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, false, "12345", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(891), "PANTOJA" }
                });

            migrationBuilder.InsertData(
                table: "Permissao",
                columns: new[] { "Id", "DataCadastro", "PerfilId", "PermiteAdicionar", "PermiteEditar", "PermiteInativar", "PermiteVisualizar", "TelaReferencia", "UltimaAlteracao", "UsuarioId" },
                values: new object[] { new Guid("d8defa05-3568-4c90-a0be-47090346feae"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1138), new Guid("0295242e-3dff-4588-b19a-17c911872ed2"), true, true, true, true, "Cadastro", new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1138), new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091") });

            migrationBuilder.InsertData(
                table: "UsuarioEmpresa",
                columns: new[] { "Id", "DataCadastro", "EmpresaId", "UltimaAlteracao", "UsuarioId" },
                values: new object[,]
                {
                    { new Guid("1eb0e62b-c12d-4e51-a45d-ba2ccb30eb22"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(972), new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(973), new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619") },
                    { new Guid("59fa0f33-a664-4813-a100-e5c9c9d54792"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1030), new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(1030), new Guid("143ab2b1-d7af-4864-a9ed-f16e3b24b619") },
                    { new Guid("80cd505a-6aa0-47e8-81a3-beb5ace0f73b"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(960), new Guid("bf006c54-99ff-4893-9881-0d30ec7406b1"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(960), new Guid("f53b9069-7a32-4e50-b4c3-6ecb1ccb7091") },
                    { new Guid("845bda6c-b3ec-4461-a747-dbe6e60d3de6"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(969), new Guid("bfabbb8f-2d40-43d0-a9e9-6b34d70565c7"), new DateTime(2023, 4, 20, 1, 53, 10, 388, DateTimeKind.Utc).AddTicks(970), new Guid("91a02238-897f-48b0-acd4-a040ab922743") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_PerfilId",
                table: "Permissao",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissao_UsuarioId",
                table: "Permissao",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_PerfilId",
                table: "Usuario",
                column: "PerfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Usuario",
                table: "Usuario",
                column: "Usuario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresa_EmpresaId",
                table: "UsuarioEmpresa",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioEmpresa_UsuarioId",
                table: "UsuarioEmpresa",
                column: "UsuarioId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissao");

            migrationBuilder.DropTable(
                name: "UsuarioEmpresa");

            migrationBuilder.DropTable(
                name: "Versao");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Perfil");
        }
    }
}
