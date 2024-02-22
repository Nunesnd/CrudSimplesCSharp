using Microsoft.EntityFrameworkCore;

public class AplicacaoDbContexto : DbContext
{
    public AplicacaoDbContexto(DbContextOptions<AplicacaoDbContexto> options)
        : base(options)
    {
    }

    public DbSet<PessoaModel> Pessoas { get; set; }
}
