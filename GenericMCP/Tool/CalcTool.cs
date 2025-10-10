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
    public static long? AddNumbers(long num1, long num2)
    {
        long? sum = null;
        try
        {
            sum = num1 + num2;
        }
        catch(Exception ex) {
            // Not sure yet this exception handling even works
            Console.WriteLine($"Exception occurred:{ex.Message}");
            sum = null;
            throw;
        }
        return sum;
    }
}
