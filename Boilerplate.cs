using System.Text;

string projectPath = Path.Combine("src", "DeskLite.Builder");
string elementsPath = Path.Combine(projectPath, "Elements");
string attributesPath = Path.Combine(elementsPath, "Attributes");
string buildersPath = Path.Combine(projectPath, "Builders");

bool overwriteExistingFiles = true;

Element[] tags = [
    new("a", null, null),
    new("abbr", null, null),
    new("address", null, null),
    new("area", null, null),
    new("article", null, null),
    new("aside", null, null),
    new("audio", null, null),
    new("b", null, null),
    new("base", null, null),
    new("bdi", null, null),
    new("bdo", null, null),
    new("blockquote", null, null),
    new("body", null, null),
    new("br", null, null),
    new("button", null, null),
    new("canvas", null, null),
    new("caption", null, null),
    new("cite", null, null),
    new("code", null, null),
    new("col", null, null),
    new("colgroup", null, null),
    new("data", null, null),
    new("datalist", null, null),
    new("dd", null, null),
    new("del", null, null),
    new("details", null, null),
    new("dfn", null, null),
    new("dialog", null, null),
    new("div", null, null),
    new("dl", null, null),
    new("dt", null, null),
    new("em", null, null),
    new("embed", null, null),
    new("fieldset", null, null),
    new("figcaption", null, null),
    new("figure", null, null),
    new("footer", null, null),
    new("form", null, null),
    new("h1", null, null),
    new("h2", null, null),
    new("h3", null, null),
    new("h4", null, null),
    new("h5", null, null),
    new("h6", null, null),
    new("head", ["title"], null),
    new("header", null, null),
    new("hgroup", null, null),
    new("hr", null, null),
    new("html", ["head", "body"], ["version", "xmlns"]),
    new("i", null, null),
    new("iframe", null, null),
    new("img", null, null),
    new("input", null, null),
    new("ins", null, null),
    new("kbd", null, null),
    new("label", null, null),
    new("legend", null, null),
    new("li", null, null),
    new("link", null, null),
    new("main", null, null),
    new("map", null, null),
    new("mark", null, null),
    new("menu", null, null),
    new("meta", null, null),
    new("meter", null, null),
    new("nav", null, null),
    new("noscript", null, null),
    new("object", null, null),
    new("ol", null, null),
    new("optgroup", null, null),
    new("option", null, null),
    new("output", null, null),
    new("p", null, null),
    new("picture", null, null),
    new("pre", null, null),
    new("progress", null, null),
    new("q", null, null),
    new("rp", null, null),
    new("rt", null, null),
    new("ruby", null, null),
    new("s", null, null),
    new("samp", null, null),
    new("script", null, null),
    new("search", null, null),
    new("section", null, null),
    new("select", null, null),
    new("selectedcontent", null, null),
    new("slot", null, null),
    new("small", null, null),
    new("source", null, null),
    new("span", null, null),
    new("strong", null, null),
    new("style", null, null),
    new("sub", null, null),
    new("summary", null, null),
    new("sup", null, null),
    new("table", null, null),
    new("tbody", null, null),
    new("td", null, null),
    new("template", null, null),
    new("textarea", null, null),
    new("tfoot", null, null),
    new("th", null, null),
    new("thead", null, null),
    new("time", null, null),
    new("title", null, null),
    new("tr", null, null),
    new("track", null, null),
    new("u", null, null),
    new("ul", null, null),
    new("var", null, null),
    new("video", null, null),
    new("wbr", null, null)
];

foreach (Element element in tags.Where(t => t.Name == "html" || t.Name == "head" || t.Name == "body" || t.Name == "title"))
{
    string tag = element.Name;
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
                using DeskLite.Builder.Elements.Attributes.Base;

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
                    using DeskLite.Builder.Elements.Attributes.Base;

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
                using DeskLite.Builder.Elements;
                using DeskLite.Builder.Elements.Attributes;

                namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                public interface I{{Tag}}Builder : IElementBuilder<I{{Tag}}Builder, {{Tag}}Attributes, {{Tag}}>
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
                    using DeskLite.Builder.Elements;
                    using DeskLite.Builder.Elements.Attributes;

                    namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                    public interface I{{Tag}}Builder : IElementBuilder<I{{Tag}}Builder, {{Tag}}Attributes, {{Tag}}>
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

                """;
        }
        else
        {
            StringBuilder builderImplementationStringBuilder = new();
            builderImplementationStringBuilder
                .AppendLine(
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
                        public {{Tag}} Build()
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
                using DeskLite.Builder.Elements;
                using DeskLite.Builder.Elements.Attributes;

                namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                public interface I{{Tag}}{{Property}}Builder : IIntermediateBuilder<I{{Tag}}Builder, {{Tag}}Attributes, {{Tag}}, I{{Property}}Builder, {{Property}}Attributes, {{Property}}>
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
                using DeskLite.Builder.Elements;
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

                    public IElementBuilder<I{{Property}}Builder, {{Property}}Attributes, {{Property}}> AsBuilder()
                        => this;

                    public {{Property}} Build()
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
