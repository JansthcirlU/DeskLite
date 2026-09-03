
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

    string elem = Path.Combine(elementsPath, $"{Capitalize(tag)}.cs");
    if (!File.Exists(elem))
    {
        await File.WriteAllTextAsync(
            elem,
            $"""
            using DeskLite.Builder.Elements.Attributes;
            using DeskLite.Builder.Elements.Primitives;

            namespace DeskLite.Builder.Elements;

            public record {Capitalize(tag)}() : HtmlElement<{Capitalize(tag)}, {Capitalize(tag)}Attributes>("{tag}");
            """);
    }
    
    string attr = Path.Combine(attributesPath, $"{Capitalize(tag)}Attributes.cs");
    if (!File.Exists(attr))
    {
        await File.WriteAllTextAsync(
            attr,
            $"""
            using DeskLite.Builder.Elements.Attributes.Base;

            namespace DeskLite.Builder.Elements.Attributes;

            public sealed record {Capitalize(tag)}Attributes : ElementAttributes<{Capitalize(tag)}>;
            """);
    }

    string elementBuilderPath = Path.Combine(buildersPath, $"{Capitalize(tag)}Builders");
    if (!Directory.Exists(elementBuilderPath))
    {
        Directory.CreateDirectory(elementBuilderPath);
    }

    string build = Path.Combine(elementBuilderPath, $"I{Capitalize(tag)}Builder.cs");
    if (!File.Exists(build))
    {
        await File.WriteAllTextAsync(
            build,
            $$"""
            using DeskLite.Builder.Builders.Primitives;
            using DeskLite.Builder.Elements;
            using DeskLite.Builder.Elements.Attributes;

            namespace DeskLite.Builder.Builders.{{Capitalize(tag)}}Builders;

            public interface I{{Capitalize(tag)}}Builder : IElementBuilder<I{{Capitalize(tag)}}Builder, {{Capitalize(tag)}}Attributes, {{Capitalize(tag)}}>
            {

            }
            """);
    }
}

static string? Capitalize(string? s)
    => s switch
    {
        null => null,
        "" => "",
        string character when character.Length == 1 => character[0].ToString().ToUpperInvariant(),
        string longer => longer[0].ToString().ToUpperInvariant() + longer[1..]
    };