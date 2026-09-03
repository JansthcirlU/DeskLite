using System.Text;

namespace DeskLite.Boilerplate.Generation;

public static class AttributesFileWriter
{
    public static async Task WriteAsync(string attributesPath, string Tag, Element element, bool overwriteExistingFiles)
    {
        string attr = Path.Combine(attributesPath, $"{Tag}Attributes.cs");
        if (File.Exists(attr) && !overwriteExistingFiles)
        {
            return;
        }

        string attrContent;

        if (element.Attributes is null)
        {
            attrContent =
                $"""
                using DeskLite.Builder.Elements.Attributes.Primitives;

                namespace DeskLite.Builder.Elements.Attributes;

                public sealed record {Tag}Attributes : ElementAttributes<{Tag}>;

                """;
        }
        else
        {
            StringBuilder attrStringBuilder = new();
            attrStringBuilder
                .AppendLine(
                    $$"""
                    using DeskLite.Builder.Elements.Attributes.Primitives;

                    namespace DeskLite.Builder.Elements.Attributes;

                    public sealed record {{Tag}}Attributes : ElementAttributes<{{Tag}}>
                    {
                    """);

            foreach (string a in element.Attributes)
            {
                string? A = a.Capitalize();
                if (A is null)
                {
                    continue;
                }

                attrStringBuilder.AppendLine($"    public string? {A} {{ get; set; }}");
            }

            attrStringBuilder
                .AppendLine(
                    """
                    }
                    """);

            attrContent = attrStringBuilder.ToString();
        }

        await File.WriteAllTextAsync(
            attr,
            attrContent);
    }
}
