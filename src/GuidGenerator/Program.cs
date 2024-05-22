namespace GuidGenerator;

using System.Reflection;
using Common.Guids;
using GuidGenerator.Options;
using GuidGenerator.Properties;

/// <summary>
/// The entry class of the application.
/// </summary>
internal class Program
{
    private static readonly IGuidProvider GuidProvider = new GuidProvider();

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    public static void Main(string[] args)
    {
        try
        {
            ProgramOptions options = OptionsParser.Parse(args);

            if (options.DisplayHelp)
            {
                DisplayHelp();
                return;
            }

            if (options.DisplayVersion)
            {
                DisplayVersion();
                return;
            }

            GenerateGuids(options.NumGuids, options.Uppercase);
        }
        catch (InvalidOptionException ex)
        {
            Console.Error.WriteLine(ex.Message);
            DisplayHelp();
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// Generates the GUIDs.
    /// </summary>
    /// <param name="numGuids">The number of GUIDs to generate.</param>
    /// <param name="uppercase">Whether to generate the GUIDs in uppercase.</param>
    private static void GenerateGuids(int numGuids, bool uppercase)
    {
        for (int i = 0; i < numGuids; ++i)
        {
            string guid = GuidProvider.NewGuid().AsString();
            if (uppercase)
            {
                guid = guid.ToUpperInvariant();
            }

            Console.WriteLine(guid);
        }
    }

    /// <summary>
    /// Displays the help text for this application.
    /// </summary>
    private static void DisplayHelp()
    {
        Console.WriteLine(Resources.ProgramHelp);
    }

    /// <summary>
    /// Gets the current application version.
    /// </summary>
    private static void DisplayVersion()
    {
        Version? version = Assembly.GetEntryAssembly()?.GetName().Version;
        Console.WriteLine(version?.ToString() ?? "1.0.0");
    }
}
