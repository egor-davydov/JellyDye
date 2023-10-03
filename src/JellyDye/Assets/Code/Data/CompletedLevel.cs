using System;

namespace Code.Data
{
  [Serializable]
  public class CompletedLevel
  {
    public string Id;
    public int Percentage;

    public CompletedLevel(string id, int percentage)
    {
      Id = id;
      Percentage = percentage;
    }
  }
}