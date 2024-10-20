using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ProSelf.Data;

/* This is used if database provider does't define
 * IProSelfDbSchemaMigrator implementation.
 */
public class NullProSelfDbSchemaMigrator : IProSelfDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
