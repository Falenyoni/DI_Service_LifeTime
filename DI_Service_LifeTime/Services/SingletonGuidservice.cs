namespace DI_Service_LifeTime.Services
{
    public class SingletonGuidservice : ISingletonGuidService
    {
        private readonly Guid Id;
        public SingletonGuidservice()
        {
            Id = Guid.NewGuid();
        }
        public string GetGuid()
        {
            return Id.ToString(); ;
        }
    }
}
