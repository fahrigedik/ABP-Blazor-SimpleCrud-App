using SimpleCrudApplication.Samples;
using Xunit;

namespace SimpleCrudApplication.EntityFrameworkCore.Domains;

[Collection(SimpleCrudApplicationTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<SimpleCrudApplicationEntityFrameworkCoreTestModule>
{

}
