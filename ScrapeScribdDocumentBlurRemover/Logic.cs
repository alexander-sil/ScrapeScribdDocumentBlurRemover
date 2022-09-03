using System;
using System.Net;

namespace ScrapeScribdDocumentBlurRemover
{
    public static class Logic
    {
        public static void Execute()
        {

        }

        public static void ScrapeHTML()
        {

        }

        public static string GetResponse(string url)
        {
            try
            {
                using (HttpClient http = new HttpClient())
                {
                    http.DefaultRequestHeaders.Add("User-Agent", "Twitterbot/1.0");
                    HttpResponseMessage response = http.GetAsync(url).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        Console.WriteLine("An exception has been thrown. " + e.Message);
                        return "<p>TEST</p>";
                    }
                    return response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception has been thrown. " + e.Message);
                return "<p>TEST</p>";
            }
        }
    }
}

