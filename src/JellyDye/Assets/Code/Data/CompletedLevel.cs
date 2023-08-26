using System;

namespace Code.Data
{
  [Serializable]
  public class CompletedLevel
  {
    public int Index;
    public int Percentage;
    public string ResultImage;

    public CompletedLevel(int index, int percentage, string resultImage)
    {
      Index = index;
      Percentage = percentage;
      ResultImage = resultImage;
    }
  }
}