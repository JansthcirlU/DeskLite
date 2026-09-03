using System.Text;

string projectPath = Path.Combine("src", "DeskLite.Builder");
string elementsPath = Path.Combine(projectPath, "Elements");
string attributesPath = Path.Combine(elementsPath, "Attributes");
string buildersPath = Path.Combine(projectPath, "Builders");

bool overwriteExistingFiles = true;

Dictionary<string, Element> tags = new()
{
    ["a"] = new("a", null, ["download", "href", "type"]),
    ["abbr"] = new("abbr", null, null),
    ["address"] = new("address", null, null),
    ["area"] = new("area", null, null),
    ["article"] = new("article", null, null),
    ["aside"] = new("aside", null, null),
    ["audio"] = new("audio", null, null),
    ["b"] = new("b", null, null),
    ["base"] = new("base", null, null),
    ["bdi"] = new("bdi", null, null),
    ["bdo"] = new("bdo", null, null),
    ["blockquote"] = new("blockquote", null, null),
    ["body"] = new("body", null, null),
    ["br"] = new("br", null, null),
    ["button"] = new("button", null, null),
    ["canvas"] = new("canvas", null, null),
    ["caption"] = new("caption", null, null),
    ["cite"] = new("cite", null, null),
    ["code"] = new("code", null, null),
    ["col"] = new("col", null, null),
    ["colgroup"] = new("colgroup", null, null),
    ["data"] = new("data", null, null),
    ["datalist"] = new("datalist", null, null),
    ["dd"] = new("dd", null, null),
    ["del"] = new("del", null, null),
    ["details"] = new("details", null, null),
    ["dfn"] = new("dfn", null, null),
    ["dialog"] = new("dialog", null, null),
    ["div"] = new("div", null, null),
    ["dl"] = new("dl", null, null),
    ["dt"] = new("dt", null, null),
    ["em"] = new("em", null, null),
    ["embed"] = new("embed", null, null),
    ["fieldset"] = new("fieldset", null, null),
    ["figcaption"] = new("figcaption", null, null),
    ["figure"] = new("figure", null, null),
    ["footer"] = new("footer", null, null),
    ["form"] = new("form", null, null),
    ["h1"] = new("h1", null, null),
    ["h2"] = new("h2", null, null),
    ["h3"] = new("h3", null, null),
    ["h4"] = new("h4", null, null),
    ["h5"] = new("h5", null, null),
    ["h6"] = new("h6", null, null),
    ["head"] = new("head", ["title"], null),
    ["header"] = new("header", null, null),
    ["hgroup"] = new("hgroup", null, null),
    ["hr"] = new("hr", null, null),
    ["html"] = new("html", ["head", "body"], ["version", "xmlns"]),
    ["i"] = new("i", null, null),
    ["iframe"] = new("iframe", null, null),
    ["img"] = new("img", null, null),
    ["input"] = new("input", null, null),
    ["ins"] = new("ins", null, null),
    ["kbd"] = new("kbd", null, null),
    ["label"] = new("label", null, null),
    ["legend"] = new("legend", null, null),
    ["li"] = new("li", null, null),
    ["link"] = new("link", null, null),
    ["main"] = new("main", null, null),
    ["map"] = new("map", null, null),
    ["mark"] = new("mark", null, null),
    ["menu"] = new("menu", null, null),
    ["meta"] = new("meta", null, null),
    ["meter"] = new("meter", null, null),
    ["nav"] = new("nav", null, null),
    ["noscript"] = new("noscript", null, null),
    ["object"] = new("object", null, null),
    ["ol"] = new("ol", null, null),
    ["optgroup"] = new("optgroup", null, null),
    ["option"] = new("option", null, null),
    ["output"] = new("output", null, null),
    ["p"] = new("p", null, null),
    ["picture"] = new("picture", null, null),
    ["pre"] = new("pre", null, null),
    ["progress"] = new("progress", null, null),
    ["q"] = new("q", null, null),
    ["rp"] = new("rp", null, null),
    ["rt"] = new("rt", null, null),
    ["ruby"] = new("ruby", null, null),
    ["s"] = new("s", null, null),
    ["samp"] = new("samp", null, null),
    ["script"] = new("script", null, null),
    ["search"] = new("search", null, null),
    ["section"] = new("section", null, null),
    ["select"] = new("select", null, null),
    ["selectedcontent"] = new("selectedcontent", null, null),
    ["slot"] = new("slot", null, null),
    ["small"] = new("small", null, null),
    ["source"] = new("source", null, null),
    ["span"] = new("span", null, null),
    ["strong"] = new("strong", null, null),
    ["style"] = new("style", null, null),
    ["sub"] = new("sub", null, null),
    ["summary"] = new("summary", null, null),
    ["sup"] = new("sup", null, null),
    ["table"] = new("table", null, null),
    ["tbody"] = new("tbody", null, null),
    ["td"] = new("td", null, null),
    ["template"] = new("template", null, null),
    ["textarea"] = new("textarea", null, null),
    ["tfoot"] = new("tfoot", null, null),
    ["th"] = new("th", null, null),
    ["thead"] = new("thead", null, null),
    ["time"] = new("time", null, null),
    ["title"] = new("title", null, null),
    ["tr"] = new("tr", null, null),
    ["track"] = new("track", null, null),
    ["u"] = new("u", null, null),
    ["ul"] = new("ul", null, null),
    ["var"] = new("var", null, null),
    ["video"] = new("video", null, null),
    ["wbr"] = new("wbr", null, null)
};

foreach ((string tag, Element element) in tags)
{
    Console.WriteLine($"Adding {tag}...");

    string? Tag = tag.Capitalize();

    if (string.IsNullOrWhiteSpace(Tag))
    {
        continue;
    }

    string elem = Path.Combine(elementsPath, $"{Tag}.cs");
    if (!File.Exists(elem) || overwriteExistingFiles)
    {
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
    
    string attr = Path.Combine(attributesPath, $"{Tag}Attributes.cs");
    if (!File.Exists(attr) || overwriteExistingFiles)
    {
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

    string elementBuilderPath = Path.Combine(buildersPath, $"{Tag}Builders");
    if (!Directory.Exists(elementBuilderPath))
    {
        Directory.CreateDirectory(elementBuilderPath);
    }

    string builderInterface = Path.Combine(elementBuilderPath, $"I{Tag}Builder.cs");
    if (!File.Exists(builderInterface) || overwriteExistingFiles)
    {
        string builderInterfaceContents;
        if (element.Properties is null)
        {
            builderInterfaceContents =
                $$"""
                using DeskLite.Builder.Builders.Primitives;
                using DeskLite.Builder.Elements.Attributes;

                namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                public interface I{{Tag}}Builder : IElementBuilder<I{{Tag}}Builder, {{Tag}}Attributes, Elements.{{Tag}}>
                {

                }

                """;
        }
        else
        {
            StringBuilder builderInterfaceStringBuilder = new();
            builderInterfaceStringBuilder
                .AppendLine(
                    $$"""
                    using DeskLite.Builder.Builders.Primitives;
                    using DeskLite.Builder.Elements.Attributes;

                    namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                    public interface I{{Tag}}Builder : IElementBuilder<I{{Tag}}Builder, {{Tag}}Attributes, Elements.{{Tag}}>
                    {
                    """);
            
            foreach (string property in element.Properties)
            {
                string? Property = property.Capitalize();
                if (Property is null)
                {
                    continue;
                }

                builderInterfaceStringBuilder
                    .AppendLine($"    I{Tag}{Property}Builder {Property}();");
            }
            
            builderInterfaceStringBuilder
                .AppendLine(
                    """
                    }
                    """);
            builderInterfaceContents = builderInterfaceStringBuilder.ToString();
        }

        await File.WriteAllTextAsync(
            builderInterface,
            builderInterfaceContents);
        
    }

    string builderImplementation = Path.Combine(elementBuilderPath, $"{Tag}Builder.cs");
    if (!File.Exists(builderImplementation) || overwriteExistingFiles)
    {
        string builderImplementationContents;

        if (element.Properties is null)
        {
            builderImplementationContents =
                $$"""
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

                    public Elements.{{Tag}} Build()
                    {
                        throw new NotImplementedException();
                    }
                }

                """;
        }
        else
        {
            StringBuilder builderImplementationStringBuilder = new();
            builderImplementationStringBuilder
                .AppendLine(
                    $$"""
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

                    """);
            
            foreach (string property in element.Properties)
            {
                string? Property = property.Capitalize();
                if (Property is null)
                {
                    continue;
                }

                builderImplementationStringBuilder
                    .AppendLine(
                        $$"""
                            public I{{Tag}}{{Property}}Builder {{Property}}()
                            {
                                throw new NotImplementedException();
                            }

                        """);
            }

            builderImplementationStringBuilder    
                .AppendLine(
                    $$"""
                        public Elements.{{Tag}} Build()
                        {
                            throw new NotImplementedException();
                        }
                    }
                    """);
            
            builderImplementationContents = builderImplementationStringBuilder.ToString();
        }

        await File.WriteAllTextAsync(
            builderImplementation,
            builderImplementationContents);
    }

    if (element.Properties is null)
    {
        continue;
    }

    foreach (string property in element.Properties)
    {
        string? Property = property.Capitalize();

        if (property is null)
        {
            continue;
        }

        string intermediateBuilderInterface = Path.Combine(elementBuilderPath, $"I{Tag}{Property}Builder.cs");
        if (!File.Exists(intermediateBuilderInterface) || overwriteExistingFiles)
        {
            await File.WriteAllTextAsync(
                intermediateBuilderInterface,
                $$"""
                using DeskLite.Builder.Builders.{{Property}}Builders;
                using DeskLite.Builder.Builders.Primitives;
                using DeskLite.Builder.Elements.Attributes;

                namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                public interface I{{Tag}}{{Property}}Builder : IIntermediateBuilder<I{{Tag}}Builder, {{Tag}}Attributes, Elements.{{Tag}}, I{{Property}}Builder, {{Property}}Attributes, Elements.{{Property}}>
                {

                }

                """);
            
        }

        string intermediateBuilderImplementation = Path.Combine(elementBuilderPath, $"{Tag}{Property}Builder.cs");
        if (!File.Exists(intermediateBuilderImplementation) || overwriteExistingFiles)
        {
            await File.WriteAllTextAsync(
                intermediateBuilderImplementation,
                $$"""
                using DeskLite.Builder.Builders.{{Property}}Builders;
                using DeskLite.Builder.Builders.Primitives;
                using DeskLite.Builder.Elements.Attributes;

                namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                internal class {{Tag}}{{Property}}Builder : I{{Tag}}{{Property}}Builder, I{{Property}}Builder
                {
                    public I{{Property}}Builder Attributes(Action<{{Property}}Attributes> attributes)
                    {
                        throw new NotImplementedException();
                    }

                    public I{{Tag}}Builder Done()
                    {
                        throw new NotImplementedException();
                    }

                    public IElementBuilder<I{{Property}}Builder, {{Property}}Attributes, Elements.{{Property}}> AsBuilder()
                        => this;

                    public Elements.{{Property}} Build()
                    {
                        throw new NotImplementedException();
                    }
                }
                
                """);
        }
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

// Types
public record Element(string Name, string[]? Properties, string[]? Attributes);
