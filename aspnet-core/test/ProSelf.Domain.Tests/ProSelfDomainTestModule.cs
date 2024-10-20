using Volo.Abp.Modularity;

namespace ProSelf;

[DependsOn(
    typeof(ProSelfDomainModule),
    typeof(ProSelfTestBaseModule)
)]
public class ProSelfDomainTestModule : AbpModule
{

}
