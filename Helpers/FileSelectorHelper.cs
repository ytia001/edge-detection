namespace ImageEdgeDetection.Helpers
{
  using System;
  using System.IO;

  public class FileSelectorHelper
  {
    // Method to obtain the file path of the image
    public static string GetImagePath()
    {
      string imagePath = "";
      
      while (true)
      {
        Console.Write("Enter image path manually (eg: './examples/chair.jpg'): ");
        imagePath = Console.ReadLine()?.Trim() ?? "";

        // Returns only if image path exists & its a jpg/jpeg file
        if (validateFilePath(imagePath))
        {
          return imagePath;
        }
        else
        {
          Console.WriteLine("Invalid path or file type. Please enter a valid JPG image path.");
        }
      }
    }

    // Verify if the file path exists and its of type jpg/jpeg
    private static bool validateFilePath(string imagePath){
      return File.Exists(imagePath) && (imagePath.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) || imagePath.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase));
    }
  }
}

