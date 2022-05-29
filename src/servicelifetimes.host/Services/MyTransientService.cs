using System.Text;

namespace servicelifetimes.host.Services
{
    public class MyTransientService : IMyTransientService
    {
        private readonly IIdGenerator _idGenerator;
        private int GlobalCounter = 0;
        private IMySecondLevelService _mySecondScopedService;
        
        public MyTransientService(IIdGenerator idGenerator, IMySecondLevelService mySecondScopedService)
        {
            _idGenerator = idGenerator;
            _mySecondScopedService = mySecondScopedService;
        }
        public string WriteToConsole()
        {
            var result = new StringBuilder(_mySecondScopedService.WriteToConsole());
            result.AppendLine( $"{nameof(MyTransientService)} has been counted for {GlobalCounter}, with Id: {_idGenerator.Id}");
            GlobalCounter++;
            return result.ToString();
        }
    } 
}
