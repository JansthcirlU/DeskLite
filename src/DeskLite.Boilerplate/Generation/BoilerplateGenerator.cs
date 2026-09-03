namespace DeskLite.Boilerplate.Generation;

public static class BoilerplateGenerator
{
    public static async Task RunAsync(
        IReadOnlyDictionary<string, Element> tags,
        string elementsPath,
        string attributesPath,
        string buildersPath,
        bool overwriteExistingFiles)
    {
        foreach ((string tag, Element element) in tags)
        {
            Console.WriteLine($"Adding {tag}...");

            string? Tag = tag.Capitalize();

            if (string.IsNullOrWhiteSpace(Tag))
            {
                continue;
            }

            await ElementFileWriter.WriteAsync(elementsPath, tag, Tag, element, overwriteExistingFiles);
            await AttributesFileWriter.WriteAsync(attributesPath, Tag, element, overwriteExistingFiles);

            string elementBuilderPath = Path.Combine(buildersPath, $"{Tag}Builders");
            if (!Directory.Exists(elementBuilderPath))
            {
                Directory.CreateDirectory(elementBuilderPath);
            }

            await BuilderFileWriter.WriteAsync(elementBuilderPath, Tag, element, overwriteExistingFiles);

            if (element.Properties is null)
            {
                continue;
            }

            await IntermediateBuilderFileWriter.WriteAsync(elementBuilderPath, Tag, element, overwriteExistingFiles);
        }
    }
}
