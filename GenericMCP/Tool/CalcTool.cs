using ModelContextProtocol.Server;
using System.ComponentModel;

namespace GenericMCP.Tool;

/// <summary>
/// Provides a tool to calculate.
/// </summary>
[McpServerToolType]
public class CalcTool
{
    /// <summary>
    /// Adds two numbers and sends back to the client.
    /// </summary>
    /// <param name="num1">Number1.</param>
    /// <param name="num2">Number1.</param>
    /// <returns>Sum of two numbers.</returns>
    [McpServerTool, Description("Sends Sum back to the client.")]
    public static int AddNumbers(int num1, int num2) => num1+num2;

}
