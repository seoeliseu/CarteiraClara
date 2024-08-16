using Microsoft.EntityFrameworkCore;

namespace CarteiraClara.Infra.BancoDados.Context
{
    public class CarteiraClaraDbContext(DbContextOptions<CarteiraClaraDbContext> options) : DbContext(options)
    {
    }
}
