namespace ImageEdgeDetection.Factories
{
  using System;
  using ImageEdgeDetection.EdgeDetectors;
  using ImageEdgeDetection.Interfaces;

  public static class EdgeDetectionFactory
  {
    public static IEdgeDetector GetEdgeDetector(string method)
    { 
      // Returns the relevant edge detector object given the method input
      // If the method does not exist, will return an exception
      // In here, we can adjust and set each edge detection's parameters
      return method.ToLower() switch
      {
        "sobel" => new SobelEdgeDetector(),
        "prewitt" => new PrewittEdgeDetector(),
        _ => throw new ArgumentException("Invalid method. Please choose 'sobel' or 'prewitt'.")
      };
    }
  }
}
