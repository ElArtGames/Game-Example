using UnityEngine;

public class Mover : IUpdateable
{
    public Vector2 Position { get; private set; }
    public Vector2 Direction { get; private set; }
    private float _speed;

    public void Update(float deltaTime)
    {
        Move(_speed * Direction * deltaTime);
    }

   public void Move (Vector2 delta)
    {
        Vector2 newPosition = Position + delta;

        newPosition.x = Mathf.Repeat(newPosition.x, 1);
        newPosition.y = Mathf.Repeat(newPosition.y, 1);

        MoveTo(newPosition);
    }

    private void MoveTo(Vector2 newPosition)
    {
        Position = newPosition;
    }
}
