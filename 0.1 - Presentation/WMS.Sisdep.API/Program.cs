using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using WMS.Sisdep.API.Services;
using WMS.Sisdep.Infra.CrossCutting.IOC;
using WMS.Sisdep.Infra.Middleware;

var builder = WebApplication.CreateBuilder(args);
//builder.Host.ConfigureAppSettings();

ConfigurationManager configuration = builder.Configuration;

// Add services to the container.

// Service Colletion
ConfigServiceCollection.AddConfig(builder.Services, configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = $"SISDEP - {configuration["Grupo"]}", Version = "v1" });
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "JWT Authorization header using the Bearer scheme."

    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new List<string>()
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
    c.SchemaFilter<SwaggerSchemaFilterService>();
});

//Adding Authorization
builder.Services.AddAuthorization();

//Adding Authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
//Adding Jwt Bearer
.AddJwtBearer(options =>
{
    options.SaveToken = true;
    options.RequireHttpsMetadata = false;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = false,
        ValidIssuer = "",
        ValidateAudience = true,
        ValidAudience = "LOCAL",
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Token:Key"]))
    };
});

builder.Services.AddCors(p =>
    p.AddPolicy("cors",
    builder =>
    {
        builder
            .AllowAnyOrigin() // For anyone access.
            .AllowAnyMethod()
            .AllowAnyHeader();
        //.SetIsOriginAllowed(origin => true) // allow any origin
        //.AllowCredentials(); // allow credentials
        //.WithOrigins("http://localhost:56573"); // for a specific url. Don't add a forward slash on the end!
    }
));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware(typeof(ErrorMiddleware));

app.UseHttpsRedirection();

// Authentication & Authorization
app.UseAuthentication();
app.UseAuthorization();

app.UseCors("cors");

app.MapControllers();

app.Run();
