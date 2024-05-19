using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;

namespace MazeGame_Ex5
{
    internal class HighScoreService
    {
        private HttpClient httpClient;

        public HighScoreService()
        {
            httpClient = new HttpClient();
        }

        public class PostData
        {
            public string HighScore { get; set; }
        }

        public async Task<string> getHighScore(string serverUrl)
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(serverUrl);
                response.EnsureSuccessStatusCode();

                string highScore = await response.Content.ReadAsStringAsync();
                return highScore;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }

        public async Task<string> updateHighScore(string serverUrl, double data)
        {
            try

            {
                Console.WriteLine(data);
                // Create the content for the POST request with string data
                HttpContent content = new StringContent(data.ToString(), Encoding.UTF8, "text/plain");

                // Make the POST request
                HttpResponseMessage response = await httpClient.PostAsync(serverUrl, content);

                // Ensure the request was successful
                response.EnsureSuccessStatusCode();

                // Read and return the response content
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
                return null;
            }
        }
    }
}
