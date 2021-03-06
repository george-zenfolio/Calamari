using Calamari.Integration.Packages;

namespace Calamari.Deployment.Conventions
{
    public interface IExtractPackage
    {
        void ExtractToStagingDirectory(PathToPackage pathToPackage, IPackageExtractor customPackageExtractor = null);
        void ExtractToEnvironmentCurrentDirectory(PathToPackage pathToPackage);
        void ExtractToApplicationDirectory(PathToPackage pathToPackage, IPackageExtractor customPackageExtractor = null);
    }
}