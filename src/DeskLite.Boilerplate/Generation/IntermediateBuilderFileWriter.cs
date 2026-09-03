namespace DeskLite.Boilerplate.Generation;

public static class IntermediateBuilderFileWriter
{
    public static async Task WriteAsync(string elementBuilderPath, string Tag, Element element, bool overwriteExistingFiles)
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
}
