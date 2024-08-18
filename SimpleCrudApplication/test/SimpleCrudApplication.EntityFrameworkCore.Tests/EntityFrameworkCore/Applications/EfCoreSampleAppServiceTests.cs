using SimpleCrudApplication.Samples;
using Xunit;

namespace SimpleCrudApplication.EntityFrameworkCore.Applications;

[Collection(SimpleCrudApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<SimpleCrudApplicationEntityFrameworkCoreTestModule>
{

}
