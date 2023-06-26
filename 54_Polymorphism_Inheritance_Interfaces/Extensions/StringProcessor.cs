using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54_Polymorphism_Inheritance_Interfaces.Extensions
{
    public class Exercise
    {
        public List<string> ProcessAll(List<string> words)
        {
            var stringsProcessors = new List<StringsProcessor>
            {
                new StringsTrimmingProcessor(),
                new StringsUppercaseProcessor()
            };

            List<string> result = words;
            foreach (var stringsProcessor in stringsProcessors)
            {
                result = stringsProcessor.Process(result);
            }
            return result;
        }
    }
}
