namespace ImageEdgeDetection.EdgeDetectors
{
  using Emgu.CV;
  using Emgu.CV.CvEnum;
  using ImageEdgeDetection.Interfaces;

  public class SobelEdgeDetector : IEdgeDetector
  {
    // Properties for Sobel parameters
    public DepthType Depth { get; set; } = DepthType.Cv64F; 
    public int KernelSize { get; set; } = 3; 

    // Constructor (allows user to set custom paramters values)
    public SobelEdgeDetector(DepthType depth = DepthType.Cv64F, int kernelSize = 3)
    {
      Depth = depth;
      KernelSize = kernelSize;
    }
    public Mat DetectEdges(Mat image)
    {
      Mat sobelX = new Mat();
      Mat sobelY = new Mat();
      Mat sobelXY = new Mat();

      // Apply the Sobel operator to detect edges in the X, Y, and both directions.
      CvInvoke.Sobel(image, sobelX, Depth, 1, 0, KernelSize);
      CvInvoke.Sobel(image, sobelY, Depth, 0, 1, KernelSize);
      CvInvoke.Sobel(image, sobelXY, Depth, 1, 1, KernelSize);

      return sobelXY;
    }
  }
}
