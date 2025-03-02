namespace ImageEdgeDetection
{
  using System;
  using ImageEdgeDetection.Helpers;
  using Emgu.CV;
  using Emgu.CV.CvEnum;

  class Program
  {
      static void Main()
      {   
          // Prompt user for image path, think can modify this for pop up selection of image instead 
          string imagePath = FileSelectorHelper.GetImagePath() ?? "";
          
          // Enable user to select the edge detection method to process on the image 
          Console.Write("Choose edge detection method (sobel/prewitt): ");
          string method = Console.ReadLine() ?? "";
          
          // Carry out the edge detection process, if there is error, display the error 
          try
          {
            EdgeDetectionProcessor.Process(imagePath, method);
          }
          catch (Exception ex)
          {
            Console.WriteLine($"Error: {ex.Message}");
          }
      }
  }
}
