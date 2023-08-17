using System;

namespace Code.Data
{
  [Serializable]
  public class CompletedLevel
  {
    public int Index;
    public int Percentage;

    public CompletedLevel(int index, int percentage)
    {
      Index = index;
      Percentage = percentage;
    }
  }
}