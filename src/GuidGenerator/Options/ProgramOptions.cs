namespace GuidGenerator.Options;

/// <summary>
/// Represents the program options.
/// </summary>
public class ProgramOptions
{
    /// <summary>
    /// Gets or sets a value indicating whether to display the application help documentation.
    /// </summary>
    public bool DisplayHelp
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether to display the application version.
    /// </summary>
    public bool DisplayVersion
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets the number of GUIDs to generate.
    /// </summary>
    public int NumGuids
    {
        get;
        set;
    }

    /// <summary>
    /// Gets or sets a value indicating whether the GUIDs should be generated in uppercase.
    /// </summary>
    public bool Uppercase
    {
        get;
        set;
    }
}
