using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Windows.Media.Imaging;

namespace PictureClient
{
   /// <summary>
   /// Interaction logic for Window1.xaml
   /// </summary>
   public partial class PictureClientWindow : Window
   {
      private const int bufferSize = 8192;

      public PictureClientWindow()
      {
         InitializeComponent();
         this.buttonGetPictureList.Click += new RoutedEventHandler(buttonGetPictureList_Click);
         this.buttonGetPicture.Click += new RoutedEventHandler(buttonGetPicture_Click);
         
      }

      void buttonGetPicture_Click(object sender, RoutedEventArgs e)
      {
         // Connect to the server.
         TcpClient client = ConnectToServer();

         NetworkStream clientStream = client.GetStream();

         string request = "FILE:" + this.listFiles.SelectedItem.ToString();
         byte[] requestBuffer = Encoding.ASCII.GetBytes(request);
         clientStream.Write(requestBuffer, 0, requestBuffer.Length);

         byte[] responseBuffer = new byte[bufferSize];
         MemoryStream memStream = new MemoryStream();
         int bytesRead = 0;
         do
         {
            bytesRead = clientStream.Read(responseBuffer, 0, bufferSize);
            memStream.Write(responseBuffer, 0, bytesRead);
            
         } while (bytesRead > 0);
         clientStream.Close();
         client.Close();

         BitmapImage bitmapImage = new BitmapImage();
         memStream.Seek(0, SeekOrigin.Begin);
         bitmapImage.BeginInit();
         bitmapImage.StreamSource = memStream;
         bitmapImage.EndInit();

         pictureBox.Source = bitmapImage;
      }

      private TcpClient ConnectToServer()
      {
         // Connect to the server.
         TcpClient client = new TcpClient();
         
         IPHostEntry host = Dns.GetHostEntry(
            Properties.Settings.Default.Server);
         var address= (from h in host.AddressList
                  where h.AddressFamily == AddressFamily.InterNetwork
                  select h).First();
         client.Connect(address.ToString(), 
            Properties.Settings.Default.ServerPort);

         return client;
      }

      void buttonGetPictureList_Click(object sender, RoutedEventArgs e)
      {
         // Connect to the server.
         TcpClient client = ConnectToServer();

         // Send a request to the server.
         NetworkStream clientStream = client.GetStream();
         string request = "LIST";
         byte[] requestBuffer = Encoding.ASCII.GetBytes(request);
         clientStream.Write(requestBuffer, 0, requestBuffer.Length);

         // Read the response from the server.
         byte[] responseBuffer = new byte[bufferSize];
         MemoryStream memStream = new MemoryStream();
         int bytesRead = 0;
         do
         {
            bytesRead = clientStream.Read(responseBuffer, 0, bufferSize);
            memStream.Write(responseBuffer, 0, bytesRead);
            
         } while (bytesRead > 0);
         clientStream.Close();
         client.Close();

         byte[] buffer = memStream.GetBuffer();
         string response = Encoding.ASCII.GetString(buffer).TrimEnd('\0');
         this.DataContext = response.Split(':');
      }
   }
}
