public class Player : IDamageable
{
    private Health _health;
    private IArmor _armor;
    private IArmor _defaultArmor;

    public Player(Health health, IArmor armor)
    {
        _health = health;
        _armor = _defaultArmor = armor;
    }

    public void TakeDamage(int damage)
    {
        _health.TakeDamage(_armor.ReduceDamage(damage));
    }

    public void SetTempArmor(IArmor tempArmor)
    {
        _armor = tempArmor;
    }

    public void SetDefaultArmor()
    {
        _armor = _defaultArmor;
    }
}
