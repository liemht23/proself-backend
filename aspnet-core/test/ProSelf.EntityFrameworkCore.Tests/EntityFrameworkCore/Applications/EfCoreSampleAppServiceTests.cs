using ProSelf.Samples;
using Xunit;

namespace ProSelf.EntityFrameworkCore.Applications;

[Collection(ProSelfTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ProSelfEntityFrameworkCoreTestModule>
{

}
