using Xunit;

namespace LegacyCodeKoans.StaticClass
{
    public class ServiceShould
    {
        [Fact]
        public void DoSomething()
        {
            Service.DoSomething();

            // TODO: Assert Dependency.SomeSideEffect() method was called
        }
    }
}