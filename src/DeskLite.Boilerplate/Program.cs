using DeskLite.Boilerplate;
using DeskLite.Boilerplate.Generation;

string repoRoot = RepoRoot.Find();
string projectPath = Path.Combine(repoRoot, "src", "DeskLite.Builder");
string elementsPath = Path.Combine(projectPath, "Elements");
string attributesPath = Path.Combine(elementsPath, "Attributes");
string buildersPath = Path.Combine(projectPath, "Builders");

bool overwriteExistingFiles = true;

await BoilerplateGenerator.RunAsync(HtmlTags.All, elementsPath, attributesPath, buildersPath, overwriteExistingFiles);
