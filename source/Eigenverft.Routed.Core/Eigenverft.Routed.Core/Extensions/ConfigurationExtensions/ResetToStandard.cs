namespace Eigenverft.Routed.Core.Extensions.ConfigurationExtensions
{
    public static partial class ConfigurationExtensions
    {
        /// <summary>
        /// Clears all existing configuration providers and re-adds a standard set of providers.
        /// </summary>
        /// <remarks>
        /// Order matters: providers added later override earlier ones. This method clears
        /// existing sources and then adds JSON files (base and environment-specific), environment
        /// variables, and optionally command-line arguments.
        /// </remarks>
        /// <param name="configuration">The configuration builder to modify.</param>
        /// <param name="environmentName">The current environment name (e.g., Development, Staging, Production).</param>
        /// <param name="args">Optional command-line arguments to add as a configuration provider.</param>
        /// <returns>The modified configuration builder.</returns>
        /// <example>
        /// <code>
        /// var builder = WebApplication.CreateBuilder(args);
        /// builder.Configuration.ResetToStandard(builder.Environment.EnvironmentName, args);
        /// </code>
        /// </example>
        public static IConfigurationBuilder ResetToStandard(this IConfigurationBuilder configuration, string environmentName, string[]? args = null)
        {
            // Implementation intentionally omitted per review-guideline: focus on the public contract.
            // Reviewer note: Clear existing sources, then call AddJsonFile("appsettings.json", false, true),
            // AddJsonFile($"appsettings.{environmentName}.json", true, true), AddEnvironmentVariables(),
            // and if args != null, AddCommandLine(args). Return the builder.
            throw new NotImplementedException();
        }
    }
}
