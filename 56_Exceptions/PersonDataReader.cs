namespace _56_Exceptions;

public interface ILogger
{
    void Log(Exception ex);
}

public interface IPeopleRepository
{
    Person Read(int personId);
}

public class PersonDataReader
{
    private readonly IPeopleRepository _peopleRepository;
    private readonly ILogger _logger;

    public PersonDataReader(IPeopleRepository personRepository, ILogger logger)
    {
        _peopleRepository = personRepository;
        _logger = logger;
    }

    public Person ReadPersonData(int personId)
    {
        try
        {
            return _peopleRepository.Read(personId);
        }
        catch (Exception ex)
        {
            _logger.Log(ex);
            throw;
        }
    }
}
