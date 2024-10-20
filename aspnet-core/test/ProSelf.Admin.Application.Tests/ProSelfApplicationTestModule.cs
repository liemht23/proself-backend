using Volo.Abp.Modularity;

namespace ProSelf.Admin;

[DependsOn(
    typeof(ProSelfAdminApplicationModule),
    typeof(ProSelfDomainTestModule)
)]
public class ProSelfApplicationTestModule : AbpModule
{

}
