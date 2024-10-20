using Xunit;

namespace ProSelf.EntityFrameworkCore;

[CollectionDefinition(ProSelfTestConsts.CollectionDefinitionName)]
public class ProSelfEntityFrameworkCoreCollection : ICollectionFixture<ProSelfEntityFrameworkCoreFixture>
{

}
