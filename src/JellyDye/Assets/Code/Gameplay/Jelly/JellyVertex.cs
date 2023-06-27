using UnityEngine;

namespace Code.Gameplay.Jelly
{
  public class JellyVertex
  {
    public int Id;
    public Vector3 Position;
    public Vector3 Velocity;
    public Vector3 Force;

    public JellyVertex(int id, Vector3 position)
    {
      Id = id;
      Position = position;
    }

    public void Shake(Vector3 target, float mass, float stiffness, float damping)
    {
      Force = (target - Position) * stiffness;
      Velocity = (Velocity + Force / mass) * damping;
      Position += Velocity;
      if ((Velocity + Force + Force / mass).magnitude < 0.001f)
        Position = target;
    }
  }
}