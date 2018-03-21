using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace PictureServer
{
   internal static class PictureHelper
   {
      internal static IEnumerable<string> GetFileList()
      {
         // Remove the directory path from the filename.
         return from fileName in Directory.GetFiles(
               Properties.Settings.Default.PictureDirectory)              
                     select Path.GetFileName(fileName);
      }

      //internal static byte[] GetPictureBytes(string fileName)
      //{
      //   FileInfo fileInfo = new FileInfo(fileName);
      //   byte[] buffer = new byte[fileInfo.Length];
      //   using (FileStream stream = fileInfo.OpenRead())
      //   {
      //      stream.Read(buffer, 0, buffer.Length);
      //   }
      //   return buffer;
      //}

      internal static byte[] GetFileListBytes()
      {
         try
         {
            // LIST request - return list
            IEnumerable<string> files = PictureHelper.GetFileList();

            StringBuilder responseMessage = new StringBuilder();
            foreach (string s in files)
            {
               responseMessage.Append(s);
               responseMessage.Append(":");
            }
            return Encoding.ASCII.GetBytes(
                  responseMessage.ToString());
         }
         catch (DirectoryNotFoundException ex)
         {
            Console.WriteLine(ex.Message);
            throw;
         }
      }

   }
}
