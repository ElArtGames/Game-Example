using System;

public class Booster : Item
{
    public readonly float BoostSeconds;

    public Booster(float boostSeconds)
    {
        if (boostSeconds < 0)
            throw new ArgumentOutOfRangeException(nameof(boostSeconds));


        BoostSeconds = boostSeconds;
    }

    public event Action Interacted;
    public override void Interact()
    {
        Interacted?.Invoke();
    }
}
