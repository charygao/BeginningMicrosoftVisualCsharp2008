using System;
using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Microsoft.Win32;

namespace FtpClient
{
   /// <summary>
   /// Interaction logic for FtpClientWindow.xaml
   /// </summary>
   public partial class FtpClientWindow : Window
   {
      private string serverDirectory;

      public FtpClientWindow()
      {
         InitializeComponent();
         this.buttonOpen.Click += new RoutedEventHandler(buttonOpen_Click);
         this.buttonOpenDirectory.Click += new RoutedEventHandler(buttonOpenDirectory_Click);
         this.buttonGetFile.Click += new RoutedEventHandler(buttonGetFile_Click);
         listFiles.SelectionChanged += new SelectionChangedEventHandler(listFiles_SelectionChanged);
      }

      void listFiles_SelectionChanged(object sender, SelectionChangedEventArgs e)
      {
         this.buttonGetFile.IsEnabled = true;
         this.buttonOpenDirectory.IsEnabled = true;
      }

      void buttonGetFile_Click(object sender, RoutedEventArgs e)
      {
         Cursor currentCursor = this.Cursor;

         FtpWebResponse response = null;
         Stream inStream = null;
         Stream outStream = null;
         try
         {
            this.Cursor = Cursors.Wait;

            Uri baseUri = new Uri(textServer.Text);

            string fileName = listFiles.SelectedItem.ToString().Trim();
            string fullFileName = System.IO.Path.Combine(serverDirectory, fileName);

            Uri uri = new Uri(baseUri, fullFileName);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(
               textUserName.Text, passwordBox.Password);
            request.Method = WebRequestMethods.Ftp.DownloadFile;
            request.UseBinary = checkBoxBinary.IsChecked ?? false;

            response = (FtpWebResponse)request.GetResponse();

            inStream = response.GetResponseStream();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = fileName;

            if (saveFileDialog.ShowDialog() == true)
            {
               outStream = File.OpenWrite(saveFileDialog.FileName);
               byte[] buffer = new byte[8192];
               int size = 0;
               while ((size = inStream.Read(buffer, 0, 8192)) > 0)
               {
                  outStream.Write(buffer, 0, size);
               }
            }
           
         }
         catch (WebException ex)
         {
            MessageBox.Show(ex.Message, "Error FTP Client", 
               MessageBoxButton.OK, MessageBoxImage.Error);
         }
         finally
         {
            if (inStream != null)
               inStream.Close();
            if (outStream != null)
               outStream.Close();
            if (response != null)
               response.Close();

            this.Cursor = currentCursor;
         }
      }

      void buttonOpenDirectory_Click(object sender, RoutedEventArgs e)
      {
         Cursor currentCursor = this.Cursor;
         FtpWebResponse response = null;
         Stream stream = null;
         try
         {
            this.Cursor = Cursors.Wait;

            string subDirectory = listFiles.SelectedItem.ToString().Trim();
            if (serverDirectory != null)
            {
               serverDirectory = System.IO.Path.Combine(serverDirectory, subDirectory);
            }
            else
            {
               serverDirectory = subDirectory;
            }

            Uri baseUri = new Uri(textServer.Text);
            Uri uri = new Uri(baseUri, serverDirectory);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(uri);
            request.Credentials = new NetworkCredential(textUserName.Text,
               passwordBox.Password);

            request.Method = WebRequestMethods.Ftp.ListDirectory;
            response = (FtpWebResponse)request.GetResponse();

            stream = response.GetResponseStream();
            FillDirectoryList(stream);
         }
         catch (WebException ex)
         {
            MessageBox.Show(ex.Message, "Error FTP Client",
                  MessageBoxButton.OK, MessageBoxImage.Error);
         }
         finally
         {
            if (response != null)
               response.Close();
            if (stream != null)
               stream.Close();

            this.Cursor = currentCursor;
         }
      }

      void buttonOpen_Click(object sender, RoutedEventArgs e)
      {
         Cursor currentCursor = this.Cursor;
         FtpWebResponse response = null;
         Stream stream = null;
         try
         {
            this.Cursor = Cursors.Wait;

            // create the FtpWebRequest object
            FtpWebRequest request =
               (FtpWebRequest)WebRequest.Create(textServer.Text);
            request.Credentials = new NetworkCredential(textUserName.Text,
               passwordBox.Password);
            request.Method = WebRequestMethods.Ftp.ListDirectory;

            // Send the request to the server.
            response = (FtpWebResponse)request.GetResponse();

            // Read the response and fill the ListBox
            stream = response.GetResponseStream();
            FillDirectoryList(stream);

            serverDirectory = null;
            buttonOpenDirectory.IsEnabled = false;
            buttonGetFile.IsEnabled = false;

         }
         catch (WebException ex)
         {
            MessageBox.Show(ex.Message, "Error FTP Client", MessageBoxButton.OK,
               MessageBoxImage.Error);
         }
         catch (IOException ex)
         {
            MessageBox.Show(ex.Message, "Error FTP Client", MessageBoxButton.OK,
               MessageBoxImage.Error);
         }
         finally
         {
            if (response != null)
               response.Close();
            if (stream != null)
               stream.Close();
            this.Cursor = currentCursor;
         }
      }



      private void FillDirectoryList(Stream stream)
      {
         StreamReader reader = new StreamReader(stream);
         string content = reader.ReadToEnd();
         string[] files = content.Split('\n');
         this.DataContext = files;
         reader.Close();
      }
   }
}
