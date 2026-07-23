using System.Reflection;

namespace ScrabbleSK.Services
{
    public class VersionService
    {
        public string Version { get; }

        public VersionService()
        {
            var assembly = typeof(Program).Assembly;
            // Try informational version first
            var info = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>()?.InformationalVersion;
            if (!string.IsNullOrEmpty(info))
            {
                // If informational version contains metadata (like +commitHash), strip it
                var clean = info!;
                var plusIndex = clean.IndexOf('+');
                if (plusIndex >= 0)
                    clean = clean.Substring(0, plusIndex);
                Version = clean;
                return;
            }

            // Fall back to assembly version
            Version = assembly.GetName().Version?.ToString() ?? "0.0.0";
        }
    }
}
