using Volo.Abp.Modularity;

namespace ProSelf;

[DependsOn(
    typeof(ProSelfApplicationModule),
    typeof(ProSelfDomainTestModule)
)]
public class ProSelfApplicationTestModule : AbpModule
{

}
