namespace Common.Guids;

using System;

/// <summary>
/// Provides functionality for generating GUIDs.
/// </summary>
public class GuidProvider : IGuidProvider
{
    /// <summary>
    /// Generates a new GUID.
    /// </summary>
    /// <returns>A newly generated GUID.</returns>
    public Guid NewGuid()
    {
        return Guid.NewGuid();
    }
}
