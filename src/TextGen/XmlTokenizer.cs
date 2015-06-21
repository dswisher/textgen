using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TextGen
{

    // TODO - move this to its own home, once we add a second type of tokenizer...
    public interface ITokenizer
    {
        Task Tokenize(TextReader reader, Action<Token> handler);
    }



    public class XmlTokenizer : ITokenizer
    {
        public Task Tokenize(TextReader reader, Action<Token> handler)
        {
            // Open the document
            XmlDocument doc = new XmlDocument();
            doc.Load(reader);

            // TODO
            throw new NotImplementedException();
        }
    }
}
