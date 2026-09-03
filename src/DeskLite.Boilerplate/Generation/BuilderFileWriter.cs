using System.Text;

namespace DeskLite.Boilerplate.Generation;

public static class BuilderFileWriter
{
    public static async Task WriteAsync(string elementBuilderPath, string Tag, Element element, bool overwriteExistingFiles)
    {
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

                    internal sealed class {{Tag}}Builder : I{{Tag}}Builder
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

                        internal sealed class {{Tag}}Builder : I{{Tag}}Builder
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
    }
}
