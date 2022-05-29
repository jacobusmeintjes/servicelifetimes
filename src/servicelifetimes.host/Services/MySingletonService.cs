using System.Text;

namespace servicelifetimes.host.Services
{
    public class MySingletonService : IMySingletonService
    {
        private int GlobalCounter = 0;
        private readonly IIdGenerator _idGenerator;
        private readonly IMySecondLevelService _mySecondScopedService;

        public MySingletonService(IIdGenerator idGenerator, IMySecondLevelService mySecondScopedService)
        {
            _idGenerator = idGenerator;
            _mySecondScopedService = mySecondScopedService;
        }

        public string WriteToConsole()
        {
            var result = new StringBuilder(_mySecondScopedService.WriteToConsole());
            result.Append(
                $"{nameof(MySingletonService)} has been counted for {GlobalCounter}, with Id: {_idGenerator.Id}");
            GlobalCounter++;

            return result.ToString();
        }
    }  
}
