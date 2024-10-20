using Volo.Abp.Modularity;

namespace ProSelf;

/* Inherit from this class for your domain layer tests. */
public abstract class ProSelfDomainTestBase<TStartupModule> : ProSelfTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
