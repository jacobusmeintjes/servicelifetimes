namespace servicelifetimes.host.Services;

public class MySecondLevelService : IMySecondLevelService
{
    private int GlobalCounter = 0;
    private readonly IIdGenerator _idGenerator;
    public MySecondLevelService(IIdGenerator idGenerator)
    {
        _idGenerator = idGenerator;
    }

    public string WriteToConsole()
    {
        var result = $"{nameof(MySecondLevelService)} has been counted for {GlobalCounter}, with Id: {_idGenerator.Id}";
        GlobalCounter++;
        return result;
    }
}