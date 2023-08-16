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
}

public interface ILogger
{
    //
}

public interface IPeopleRepository
{
    //
}