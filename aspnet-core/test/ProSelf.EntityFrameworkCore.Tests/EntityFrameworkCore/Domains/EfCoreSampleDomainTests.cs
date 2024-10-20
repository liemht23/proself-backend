using ProSelf.Samples;
using Xunit;

namespace ProSelf.EntityFrameworkCore.Domains;

[Collection(ProSelfTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ProSelfEntityFrameworkCoreTestModule>
{

}
