using Microsoft.EntityFrameworkCore;
using TesteTecnico.Data;;

var optionsBuilder = newDbContextOptionsBuilder<AppDbContext>();
optionsBuilder.UseMySql(
    "sever=localhost;database=teste_tecnico;user=;root;password=#Gf518",
    new MySqlServerVersion(new Version(8, 0, 21))
);

using var context = new AppDbContext(optionsBuilder.Options);

var service = new OperacaoService(new OperacaoRepository(context));
var resultado = await service.CalcularLucroPrejuizoPorClienteAsync();

foreach (var item in resultado)
{
    Console.WriteLine($"Cliente: {item.Cliente}, Lucro: {item.Lucro}, Prejuízo: {item.PrejuizoTotal}");
}