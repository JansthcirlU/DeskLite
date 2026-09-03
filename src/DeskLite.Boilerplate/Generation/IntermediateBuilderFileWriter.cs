using System.Text;

namespace DeskLite.Boilerplate.Generation;

public static class IntermediateBuilderFileWriter
{
    public static async Task WriteAsync(
        string elementBuilderPath,
        string Tag,
        Element element,
        IReadOnlyDictionary<string, Element> tags,
        bool overwriteExistingFiles)
    {
        foreach (string property in element.Properties!)
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
                StringBuilder intermediateBuilderImplementationStringBuilder = new();
                intermediateBuilderImplementationStringBuilder
                    .AppendLine(
                        $$"""
                        using DeskLite.Builder.Builders.{{Property}}Builders;
                        using DeskLite.Builder.Builders.Primitives;
                        using DeskLite.Builder.Elements.Attributes;

                        namespace DeskLite.Builder.Builders.{{Tag}}Builders;

                        internal sealed class {{Tag}}{{Property}}Builder : I{{Tag}}{{Property}}Builder, I{{Property}}Builder
                        {
                            public I{{Property}}Builder Attributes(Action<{{Property}}Attributes> attributes)
                            {
                                throw new NotImplementedException();
                            }

                        """);

                if (tags.TryGetValue(property, out Element? propertyElement) && propertyElement.Properties is string[] nestedProperties)
                {
                    foreach (string nestedProperty in nestedProperties)
                    {
                        string? NestedProperty = nestedProperty.Capitalize();
                        if (NestedProperty is null)
                        {
                            continue;
                        }

                        intermediateBuilderImplementationStringBuilder
                            .AppendLine(
                                $$"""
                                    public I{{Property}}{{NestedProperty}}Builder {{NestedProperty}}()
                                    {
                                        throw new NotImplementedException();
                                    }

                                """);
                    }
                }

                intermediateBuilderImplementationStringBuilder
                    .AppendLine(
                        $$"""
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

                await File.WriteAllTextAsync(
                    intermediateBuilderImplementation,
                    intermediateBuilderImplementationStringBuilder.ToString());
            }
        }
    }
}
