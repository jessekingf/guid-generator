namespace Common.Guids;

/// <summary>
/// Extends the <see cref="Guid"/> class.
/// </summary>
public static class GuidExtensions
{
    /// <summary>
    /// Returns the GUID as a string.
    /// </summary>
    /// <param name="guid">The unique identifier.</param>
    /// <returns>The GUID as a string.</returns>
    public static string AsString(this Guid guid)
    {
        return guid.ToString();
    }
}
