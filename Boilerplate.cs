
string projectPath = Path.Combine("src", "DeskLite.Builder");
string elementsPath = Path.Combine(projectPath, "Elements");
string attributesPath = Path.Combine(elementsPath, "Attributes");
string buildersPath = Path.Combine(projectPath, "Builders");

string[] tags = [
    "a",
    "abbr",
    "address",
    "area",
    "article",
    "aside",
    "audio",
    "b",
    "base",
    "bdi",
    "bdo",
    "blockquote",
    "body",
    "br",
    "button",
    "canvas",
    "caption",
    "cite",
    "code",
    "col",
    "colgroup",
    "data",
    "datalist",
    "dd",
    "del",
    "details",
    "dfn",
    "dialog",
    "div",
    "dl",
    "dt",
    "em",
    "embed",
    "fieldset",
    "figcaption",
    "figure",
    "footer",
    "form",
    "h1",
    "h2",
    "h3",
    "h4",
    "h5",
    "h6",
    "head",
    "header",
    "hgroup",
    "hr",
    "html",
    "i",
    "iframe",
    "img",
    "input",
    "ins",
    "kbd",
    "label",
    "legend",
    "li",
    "link",
    "main",
    "map",
    "mark",
    "menu",
    "meta",
    "meter",
    "nav",
    "noscript",
    "object",
    "ol",
    "optgroup",
    "option",
    "output",
    "p",
    "picture",
    "pre",
    "progress",
    "q",
    "rp",
    "rt",
    "ruby",
    "s",
    "samp",
    "script",
    "search",
    "section",
    "select",
    "selectedcontent",
    "slot",
    "small",
    "source",
    "span",
    "strong",
    "style",
    "sub",
    "summary",
    "sup",
    "table",
    "tbody",
    "td",
    "template",
    "textarea",
    "tfoot",
    "th",
    "thead",
    "time",
    "title",
    "tr",
    "track",
    "u",
    "ul",
    "var",
    "video",
    "wbr"
];

foreach (string tag in tags[..2])
{
    Console.WriteLine($"Adding {tag}...");

    string? Tag = tag.Capitalize();

    if (string.IsNullOrWhiteSpace(Tag))
    {
        continue;
    }

    string elem = Path.Combine(elementsPath, $"{Tag}.cs");
    if (!File.Exists(elem))
    {
        await File.WriteAllTextAsync(
            elem,
            $"""
            using DeskLite.Builder.Elements.Attributes;
            using DeskLite.Builder.Elements.Primitives;

            namespace DeskLite.Builder.Elements;

            public record {Tag}() : HtmlElement<{Tag}, {Tag}Attributes>("{tag}");
            """);
    }
    
    string attr = Path.Combine(attributesPath, $"{Tag}Attributes.cs");
    if (!File.Exists(attr))
    {
        await File.WriteAllTextAsync(
            attr,
            $"""
            using DeskLite.Builder.Elements.Attributes.Base;

            namespace DeskLite.Builder.Elements.Attributes;

            public sealed record {Tag}Attributes : ElementAttributes<{Tag}>;
            """);
    }

    string elementBuilderPath = Path.Combine(buildersPath, $"{Tag}Builders");
    if (!Directory.Exists(elementBuilderPath))
    {
        Directory.CreateDirectory(elementBuilderPath);
    }

    string builderInterface = Path.Combine(elementBuilderPath, $"I{Tag}Builder.cs");
    if (!File.Exists(builderInterface))
    {
        await File.WriteAllTextAsync(
            builderInterface,
            $$"""
            using DeskLite.Builder.Builders.Primitives;
            using DeskLite.Builder.Elements;
            using DeskLite.Builder.Elements.Attributes;

            namespace DeskLite.Builder.Builders.{{Tag}}Builders;

            public interface I{{Tag}}Builder : IElementBuilder<I{{Tag}}Builder, {{Tag}}Attributes, {{Tag}}>
            {

            }
            """);
        
    }

    string builderImplementation = Path.Combine(elementBuilderPath, $"{Tag}Builder.cs");
    if (!File.Exists(builderImplementation))
    {
        await File.WriteAllTextAsync(
            builderImplementation,
            $$"""
            using DeskLite.Builder.Elements;
            using DeskLite.Builder.Elements.Attributes;

            namespace DeskLite.Builder.Builders.{{Tag}}Builders;

            internal class {{Tag}}Builder : I{{Tag}}Builder
            {
                private readonly {{Tag}}Attributes _attributes = new();

                public I{{Tag}}Builder Attributes(Action<{{Tag}}Attributes> attributes)
                {
                    attributes(_attributes);
                    return this;
                }

                public {{Tag}} Build()
                {
                    throw new NotImplementedException();
                }
            }
            """);
    }
}

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
