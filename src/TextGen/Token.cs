

namespace TextGen
{
    public class Token
    {
        public TokenContext Context { get; set; }
        public TokenType Type { get; set; }
        public string Content { get; set; }
    }
}
