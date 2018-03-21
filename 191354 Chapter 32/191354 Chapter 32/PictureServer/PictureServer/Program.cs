using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace PictureServer
{
   class Program
   {
      static void Main()
      {
         TcpListener listener = new TcpListener(IPAddress.Any,
            Properties.Settings.Default.Port);
         listener.Start();
         Console.WriteLine("Server running...");

         while (true)
         {
            const int bufferSize = 8192;

            TcpClient client = listener.AcceptTcpClient();
            NetworkStream clientStream = client.GetStream();

            byte[] buffer = new byte[bufferSize];
            int readBytes = 0;
            readBytes = clientStream.Read(buffer, 0, bufferSize);

            string request = Encoding.ASCII.GetString(buffer).Substring(
                  0, readBytes);

            if (request.StartsWith("LIST", StringComparison.Ordinal))
            {
               // LIST request - return list
               byte[] responseBuffer = PictureHelper.GetFileListBytes();

               clientStream.Write(responseBuffer, 0, responseBuffer.Length);
            }
            else if (request.StartsWith("FILE", StringComparison.Ordinal))
            {
               // FILE request - return file

               // get the filename
               string[] requestMessage = request.Split(':');
               string filename = requestMessage[1];

               byte[] data = File.ReadAllBytes(Path.Combine(
                     Properties.Settings.Default.PictureDirectory, filename));

               // Send the picture to the client.
               clientStream.Write(data, 0, data.Length);
            }
            clientStream.Close();
         }

      }
   }
}
