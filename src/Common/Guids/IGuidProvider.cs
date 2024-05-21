namespace Common.Guids;

/// <summary>
/// Provides functionality for generating GUIDs.
/// </summary>
public interface IGuidProvider
{
    /// <summary>
    /// Generates a new GUID.
    /// </summary>
    /// <returns>A newly generated GUID.</returns>
    Guid NewGuid();
}
