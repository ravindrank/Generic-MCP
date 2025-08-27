using System.ComponentModel;
using System.Text.Json;
using ModelContextProtocol.Server;

/// <summary>
/// Provides a tool for making HTTP API calls.
/// </summary>
[McpServerToolType]
public static class APITool
{
    /// <summary>
    /// Accepts an HTTP endpoint and calls it, returning the result.
    /// </summary>
    /// <param name="endpoint">The URL of the HTTP endpoint to call.</param>
    /// <returns>The content of the HTTP response as a string.</returns>
    [McpServerTool, Description("Accepts an http end-point and calls it, returns the result.")]
    public static async Task<string> CallAPI(string endpoint)
    {
        string result = string.Empty;
        // Create a HttpClient instance
        using (var client = new HttpClient())
        {

            // Set the base address
            client.BaseAddress = new Uri(endpoint);

            // Set the Accept header
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            // Make the GET request
            var response = await client.GetAsync(endpoint);

            // Check the status code
            if (response.IsSuccessStatusCode)
            {
                // Read the response content
                result = await response.Content.ReadAsStringAsync();
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
        return result;
    } 
   
}
