namespace DeskLite.Boilerplate.Generation;

public static class ElementFileWriter
{
    public static async Task WriteAsync(string elementsPath, string tag, string Tag, Element element, bool overwriteExistingFiles)
    {
        string elem = Path.Combine(elementsPath, $"{Tag}.cs");
        if (File.Exists(elem) && !overwriteExistingFiles)
        {
            return;
        }

        string properties = element.Properties is string[] props
            ? string.Join(", ", props.Select(p => p.Capitalize()).Cast<string>().Select(s => $"{s} {s}"))
            : string.Empty;

        await File.WriteAllTextAsync(
            elem,
            $"""
            using DeskLite.Builder.Elements.Attributes;
            using DeskLite.Builder.Elements.Primitives;

            namespace DeskLite.Builder.Elements;

            public record {Tag}({properties}) : HtmlElement<{Tag}, {Tag}Attributes>("{tag}");

            """);
    }
}
