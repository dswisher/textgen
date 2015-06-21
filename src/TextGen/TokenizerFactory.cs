using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGen
{
    public interface ITokenizerFactory
    {
        ITokenizer Create(string extension);
    }



    public class TokenizerFactory : ITokenizerFactory
    {
        // TODO - use something from http://docs.autofac.org/en/latest/register/registration.html#selection-of-an-implementation-by-parameter-value
        public TokenizerFactory()
        {
            
        }

        public ITokenizer Create(string extension)
        {
            throw new NotImplementedException();
        }
    }
}
