using SimpleTCP;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementApp
{
    public class Logic
    {
        public static async Task ConnectToServer(string[] dataToSend) //Get data after clicking search button
        {
            SimpleTcpClient client = new(); //create client object
            await Task.Run(() => //new task handling the connection
            {
                try
                {
                    client.Connect("127.0.0.1", 2323); //connecting client to the server
                    SimpleTCP.Message msg = client.WriteLineAndGetReply(JsonSerializer.Serialize(dataToSend), TimeSpan.FromSeconds(15));

                    Receiver(msg);

                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd w trakcie pobierania danych");
                }
            });
        }

        static void Receiver(SimpleTCP.Message message)
        {
            
        }

        static void ShowData(List<string>? clientData)
        {
            //create new window 
            var popup = new Form();
            popup.MinimumSize = new Size(600, 300);
            popup.MaximumSize = new Size(600, 300);
            //

            //create a label, which will be used to display the data
            Label info = new();
            info.Text = "Numer klienta: " + clientData[1] + "\r\n" + "Imie: " + clientData[2] + "\r\n" + "Nazwisko: " + clientData[3] + "\r\n" + "\r\n" + "Wypożyczone kiążki: " + "\r\n" + clientData[4];
            info.Location = new Point(0, 0);
            info.AutoSize = true;
            info.Font = new Font("Arial", 10);
            //

            popup.Controls.Add(info); //add label to popup window
            popup.ShowDialog(); //show window
        }
    }
}
