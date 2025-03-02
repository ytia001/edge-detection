namespace ImageEdgeDetection
{
  using System;
  using Emgu.CV;
  using Emgu.CV.CvEnum;
  using ImageEdgeDetection.Factories;
  using ImageEdgeDetection.EdgeDetectors;
  using ImageEdgeDetection.Interfaces;

  public class EdgeDetectionProcessor
  {
    // The method to process edge detection
    // Takes in the imagePath and the edge detection method 
    // It will then proces the image with the edge detection method and display it 
    public static void Process(string imagePath, string method)
    {   
      // Reads the image store in imagePath and ensure its modify it to grayscale 
      Mat image = CvInvoke.Imread(imagePath, ImreadModes.Grayscale);

      // Apply Gaussian blur to reduce noise in the image before processing it with edge detection
      Mat blurredImage = new Mat();
      CvInvoke.GaussianBlur(image, blurredImage, new System.Drawing.Size(3, 3), 1.0);

      // Initialize the desired edge detector given by user 
      IEdgeDetector edgeDetector = EdgeDetectionFactory.GetEdgeDetector(method);

      // Perform edge detection on the image 
      Mat edges = edgeDetector.DetectEdges(blurredImage);

      // Display the origianal and the processed image for edge detection
      CvInvoke.Imshow("Grayscale Image", image);
      CvInvoke.Imshow("Edge Detected Image", edges);
      CvInvoke.WaitKey(0);
    }
  }
}
