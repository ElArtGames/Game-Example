public class Player : IDamageable, IUpdateable
{
    private Health _health;
    private IArmor _armor;
    private IArmor _defaultArmor;

    private float _timeToEnd;
    private bool _underEffect;

    public Player(Health health, IArmor armor)
    {
        _health = health;
        _armor = _defaultArmor = armor;
    }

    public void TakeDamage(int value)
    {
        _health.TakeDamage(_armor.ReduceDamage(value));
    }

    public void SetTempArmor(IArmor tempArmor, float durationSeconds)
    {
        _armor = tempArmor;
        _timeToEnd = durationSeconds;
        _underEffect = true;
    }

    public void Update(float deltaTime)
    {
        if (_underEffect)
            _timeToEnd -= deltaTime;

        if (_timeToEnd <= 0)
            SetDefaultArmor();
    }

    private void SetDefaultArmor()
    {
        _armor = _defaultArmor;
        _underEffect = false;
    }

}
