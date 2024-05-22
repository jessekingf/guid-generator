﻿namespace GuidGenerator.Options;

/// <summary>
/// The exception thrown when an invalid program option is specified.
/// </summary>
/// <seealso cref="Exception" />
public class InvalidOptionException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOptionException"/> class.
    /// </summary>
    public InvalidOptionException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOptionException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    public InvalidOptionException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="InvalidOptionException"/> class.
    /// </summary>
    /// <param name="message">The message that describes the error.</param>
    /// <param name="innerException">The inner exception.</param>
    public InvalidOptionException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}
