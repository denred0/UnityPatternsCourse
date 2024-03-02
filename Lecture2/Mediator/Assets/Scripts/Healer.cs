public class Healer
{
    private HealerConfig _config;
    private int _healAmount;

    public Healer(HealerConfig config)
    {
        _config = config;
        _healAmount = _config.HealAmount;
    }

    public void Heal(IHealable healable)
    {
        healable.Heal(_healAmount);
    }
}
