using System;

public class Shield : Item
{
    public readonly int ShieldSeconds;
    private readonly int _strength;

    public Shield(int seconds, int strength)
    {
        if (seconds < 0)
            throw new ArgumentOutOfRangeException(nameof(seconds));

        if (strength < 0)
            throw new ArgumentOutOfRangeException(nameof(strength));

        ShieldSeconds = seconds;
        _strength = strength;
    }

    public event Action Interacted;

    public override void Interact()
    {
        Interacted?.Invoke();
    }
}
