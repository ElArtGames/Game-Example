using System;

public class Shield : Item
{
    public readonly int duration;
    private readonly int _strength;

    public Shield(int seconds, int strength)
    {
        if (seconds < 0)
            throw new ArgumentOutOfRangeException(nameof(seconds));

        if (strength < 0)
            throw new ArgumentOutOfRangeException(nameof(strength));

        duration = seconds;
        _strength = strength;
    }

    public event Action Interacted;

    public override void Interact(Player player)
    {
        player.SetTempArmor(new ShieldArmor(_strength), duration);
        Interacted?.Invoke();
    }

   
}
