namespace LegacyCodeKoans.StaticMethod
{
    public class Service
    {
        private readonly IDependencyWrapper dependencyWrapper;

        public Service(IDependencyWrapper dependencyWrapper)
        {
            this.dependencyWrapper = dependencyWrapper;
        }

        public void DoSomething()
        {
            dependencyWrapper.SomeSideEffect();
        }
    }
}