namespace servicelifetimes.host.Services
{
    public class IdGenerator : IIdGenerator
    {
        public Guid Id { get; } = Guid.NewGuid();
    }
}