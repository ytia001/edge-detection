namespace EdgeDetectionProject.Interfaces
{
  using Emgu.CV;

  public interface IEdgeDetector
  {
    Mat DetectEdges(Mat image);
  }
}
