namespace GuidGenerator.Options;

using GuidGenerator.Properties;

/// <summary>
/// Parses the command line arguments.
/// </summary>
public static class OptionsParser
{
    /// <summary>
    /// Parses the program options from the command-line arguments.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    /// <returns>The program options.</returns>
    public static ProgramOptions Parse(string[] args)
    {
        ProgramOptions options = new();
        foreach (string arg in args ?? Array.Empty<string>())
        {
            if (string.IsNullOrEmpty(arg))
            {
                continue;
            }

            if (arg.StartsWith('-'))
            {
                switch (arg.ToLowerInvariant())
                {
                    case "--help":
                    case "-h":
                        options.DisplayHelp = true;
                        continue;
                    case "--upper":
                    case "-u":
                        options.Uppercase = true;
                        continue;
                    case "--version":
                    case "-v":
                        options.DisplayVersion = true;
                        continue;
                    default:
                        throw new InvalidOptionException(string.Format(Resources.InvalidOption, arg));
                }
            }

            // Not a switch, assume it is the number of GUIDs to generate.
            // If it is already set, too many arguments have been passed.
            if (options.NumGuids > 0)
            {
                throw new InvalidOptionException(string.Format(Resources.InvalidOption, arg));
            }

            if (int.TryParse(arg, out int numGuids)
                && numGuids > 0)
            {
                options.NumGuids = numGuids;
            }
        }

        if (options.NumGuids < 1)
        {
            options.NumGuids = 1;
        }

        return options;
    }
}
