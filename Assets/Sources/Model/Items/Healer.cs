using System;

public class Healer : Item
{
    public readonly int Points;

    public Healer(int points)
    {
        if (points<0)
            throw new ArgumentOutOfRangeException(nameof(points));

        Points = points;
    }

    public event Action<int> Interacted;

    public override void Interact(Player player)
    {
        Interacted?.Invoke(Points);
    }
}
