using Volo.Abp.Modularity;

namespace ProSelf;

public abstract class ProSelfApplicationTestBase<TStartupModule> : ProSelfTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
