using UnityEngine;

namespace Code.Services
{
  public class ParentsProvider
  {
    public Transform ParentForOther { get; private set; }
    public Transform ParentForGameplay { get; private set; }
    public Transform ParentForUI { get; private set; }

    public void Initialize(Transform parentForOther, Transform parentForGameplay, Transform parentForUI)
    {
      ParentForUI = parentForUI;
      ParentForGameplay = parentForGameplay;
      ParentForOther = parentForOther;
    }
  }
}