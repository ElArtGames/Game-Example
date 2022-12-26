using System;


public class Health: IDamageable
{
    public readonly int MaxValue;
    public int Value { get; private set; }

    public Health(int startValue, int maxValue)
    {
        if (startValue <= 0)
            throw new ArgumentOutOfRangeException(nameof(startValue));

        if (maxValue <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxValue));

        if (startValue > maxValue)
            throw new InvalidOperationException($"{nameof(startValue)} should be less than {nameof(maxValue)}");

        Value = startValue;
        MaxValue = maxValue;
    }

    public event Action Dying;
    public event Action Damaged;
    public event Action Healed;


    public void TakeDamage(int damage)
    {
        if (damage < 0)
            throw new ArgumentOutOfRangeException(nameof(damage));

        Value -= damage;

        if (TryDie())
            Dying?.Invoke();
        else 
            Damaged?.Invoke();
    }

    public void TakeHealing(int healingPoints)
    {
        if (healingPoints < 0)
            throw new ArgumentOutOfRangeException(nameof(healingPoints));

        Value += healingPoints;

        if (Value >= MaxValue)
            Value = MaxValue;

        Healed?.Invoke();
    }

    private bool TryDie()
    {
        if (Value < 0)
            Value = 0;

        return Value == 0;
    }
}
