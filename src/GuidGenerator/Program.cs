namespace GuidGenerator;

using Common.Guids;

/// <summary>
/// The entry class of the application.
/// </summary>
internal class Program
{
    private static readonly IGuidProvider GuidProvider = new GuidProvider();

    /// <summary>
    /// Defines the entry point of the application.
    /// </summary>
    public static void Main()
    {
        Console.WriteLine(GuidProvider.NewGuid().AsString());
    }
}
