using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56_Exceptions;

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
        return _peopleRepository.Read(personId);
    }


}

public interface ILogger
{
    //
}

public interface IPeopleRepository
{
    //
}