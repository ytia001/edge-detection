namespace ImageEdgeDetection.EdgeDetectors
{
  using Emgu.CV;
  using Emgu.CV.Cuda;
  using Emgu.CV.CvEnum;
  using Emgu.CV.Structure;
  using ImageEdgeDetection.Interfaces;

  public class PrewittEdgeDetector : IEdgeDetector
  { 
    // properties for PrewittEdgeDetector
    public DepthType depth {get; set;} = DepthType.Cv64F;

    public Mat DetectEdges(Mat image)
    { 
      // Ensure the image is float type for proper processing
      image.ConvertTo(image, depth);

      // Initialize the matrices variables
      Mat prewittX = new Mat(image.Size, depth, 1);
      Mat prewittY = new Mat(image.Size, depth, 1);
      Mat prewittCombined = new Mat(image.Size, depth, 1);

      // Define prewitt kernels for x and y 
      Mat xKernel = new Mat(3, 3, depth, 1);
      xKernel.SetTo(new float[] { -1, 0, 1, -1, 0, 1, -1, 0, 1 });

      Mat yKernel = new Mat(3, 3, depth, 1);
      yKernel.SetTo(new float[] { -1, -1, -1, 0, 0, 0, 1, 1, 1 });

      // Apply prewitt kernel to the x and y matrices to get the gradient
      CvInvoke.Filter2D(image, prewittX, xKernel, new System.Drawing.Point(-1, -1));
      CvInvoke.Filter2D(image, prewittY, yKernel, new System.Drawing.Point(-1, -1));

      // Obtain the resulting matrix from the x and y matrix
      Mat squaredX = new Mat(image.Size, depth, 1);
      Mat squaredY = new Mat(image.Size, depth, 1);
      CvInvoke.Pow(prewittX, 2, squaredX);
      CvInvoke.Pow(prewittY, 2, squaredY);
      CvInvoke.Add(squaredX, squaredY, prewittCombined);
      CvInvoke.Sqrt(prewittCombined, prewittCombined);

      return prewittCombined;
    }
  }
}
