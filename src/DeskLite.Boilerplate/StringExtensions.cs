namespace DeskLite.Boilerplate;

public static class StringExtensions
{
    extension(string? s)
    {
        public string? Capitalize()
            => s switch
            {
                null => null,
                "" => "",
                string character when character.Length == 1 => character[0].ToString().ToUpperInvariant(),
                string longer => longer[0].ToString().ToUpperInvariant() + longer[1..]
            };
    }
}
