//inicializa a aplicação e configura os serviços e o pipeline da API

using SubToDo.Repositories;

var builder = WebApplication.CreateBuilder(args); // cria a aplicação ASP.NET 

// Add services to the container.

builder.Services.AddControllers(); // ATIVA OS CONTROLLERS sem isso a API não funciona 
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi(); // documentação automática da API (mais moderno)
builder.Services.AddSingleton<ServicoRepository>(); // isso aqui é MUITO importante - cria 1 único TarefaRepository, reutiliza ele no sistema inteiro

builder.Services.AddEndpointsApiExplorer(); // ativa o Swagger UI
builder.Services.AddSwaggerGen(); // ativa o Swagger UI, serve para testar API e ver endpoints (Endpoints é um “endereço” da sua API)

//comunicação com front - permite o frontend acessar a API 
// localhost:5173  seu front (Vite/React/Vue) - API normalmente roda em outra porta, SEM CORS BLOQUEIA REQUISIÇÃO DO FRONT 
builder.Services.AddCors(options =>
{
    options.AddPolicy("MinhaPoliticaCORS", policy =>
    {
        policy.WithOrigins("http://localhost:5173")
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build(); // finaliza configuração e cria o app
app.UseCors("MinhaPoliticaCORS"); // libera o acesso do front
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();    // só funciona em modo DEV (serve pra todos)
    app.MapOpenApi();
}

app.UseAuthorization(); // controle de acesso (login/token) - no seu projeto ainda não está sendo usado de verdade

app.MapControllers(); // ativa as rotas da API

app.Run(); // Inicia o servidor
