using SimpleTCP;
using System.Text.Json;

namespace ManagementApp
{
    public class Login
    {
        public static async Task<bool> Try(string username, string password) 
        {
            bool result = true;

            string[] data = {"login", username, password};

            SimpleTcpClient client = new SimpleTcpClient();

            await Task.Run(() => 
            {
                try
                {
                    client.Connect("127.0.0.1", 2323);
                    SimpleTCP.Message msg = client.WriteLineAndGetReply(JsonSerializer.Serialize(data), TimeSpan.FromSeconds(5));
                    if (msg != null)
                    {
                        client.Disconnect();
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch
                {
                    result = false;
                }
            });
            return result;
        }
    }
}
