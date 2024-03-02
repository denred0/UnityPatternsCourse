public class Damager
{
    private DamagerConfig _config;
    private int _damageAmount;

    public Damager(DamagerConfig config)
    {
        _config = config;
        _damageAmount = _config.DamageAmount;
    }

    public void Damage(IDamagable damagable)
    {
        damagable.TakeDamage(_damageAmount);
    }
}