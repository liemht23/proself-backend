using Volo.Abp.Modularity;

namespace ProSelf.Admin;

public abstract class ProSelfApplicationTestBase<TStartupModule> : ProSelfTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
