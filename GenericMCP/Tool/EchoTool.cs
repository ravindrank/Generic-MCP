using System.ComponentModel;
using System.Text.Json;
using ModelContextProtocol.Server;

/// <summary>
/// Provides tools for echoing and reversing messages.
/// </summary>
[McpServerToolType]
public static class EchoTool
{
    /// <summary>
    /// Echoes the message back to the client.
    /// </summary>
    /// <param name="message">The message to echo.</param>
    /// <returns>A string containing the echoed message.</returns>
    [McpServerTool, Description("Echoes the message back to the client.")]
    public static string Echo(string message) => $"Hello from C#: {message}";

    /// <summary>
    /// Echoes in reverse the message sent by the client.
    /// </summary>
    /// <param name="message">The message to reverse and echo.</param>
    /// <returns>A string containing the reversed message.</returns>
    [McpServerTool, Description("Echoes in reverse the message sent by the client.")]
    public static string ReverseEcho(string message) => new string(message.Reverse().ToArray());
}

