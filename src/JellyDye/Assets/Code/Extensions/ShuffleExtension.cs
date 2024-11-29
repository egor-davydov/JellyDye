using System.Collections.Generic;
using UnityEngine;

namespace Code.Extensions
{
  public static class ShuffleExtension
  {
    public static List<T> Shuffle<T>(this List<T> list) =>
      ShuffleList(list);

    private static List<T> ShuffleList<T>(List<T> list)
    {
      for (int i = list.Count - 1; i >= 1; i--)
      {
        int j = Random.Range(0, i + 1);
        (list[j], list[i]) = (list[i], list[j]);
      }

      return list;
    }
  }
}