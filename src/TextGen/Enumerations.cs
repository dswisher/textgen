
namespace TextGen
{
    /// <summary>
    /// The context (location) from which a token originated
    /// </summary>
    public enum TokenContext
    {
        Headline,
        Summary,
        Body
    }


    public enum TokenType
    {
        Word,
        Punctuation,
        SectionEnd
    }
}
