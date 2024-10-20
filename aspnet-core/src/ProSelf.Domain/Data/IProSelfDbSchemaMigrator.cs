using System.Threading.Tasks;

namespace ProSelf.Data;

public interface IProSelfDbSchemaMigrator
{
    Task MigrateAsync();
}
