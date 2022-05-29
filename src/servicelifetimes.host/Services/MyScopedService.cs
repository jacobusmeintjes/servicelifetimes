namespace servicelifetimes.host.Services
{
    public class MyScopedService : IMyScopedService
    {
        private int GlobalCounter = 0;
        private readonly IIdGenerator _idGenerator;

        public MyScopedService(IIdGenerator idGenerator)
        {                          
            _idGenerator = idGenerator;
        }

        public string WriteToConsole()
        {
            var result = $"{nameof(MyScopedService)} has been counted for {GlobalCounter}, with Id: {_idGenerator.Id}";
            GlobalCounter++;
            return result;
        }
    }
}
