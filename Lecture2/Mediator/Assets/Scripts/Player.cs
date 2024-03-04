using System;

public class Player : IHealable, IDamagable
{
    public event Action<int> HealthChanged;
    public event Action<int> LevelChanged;
    public event Action Death;

    private int _experience;
    private int _nextLevelExperience;

    private Health _health;
    private PlayerLevel _level;

    public Player(int initialLevel, int initialHeatlh, int nextLevelExperience)
    {
        _health = new Health(initialHeatlh);

        _level = new PlayerLevel(initialLevel);

        _nextLevelExperience = nextLevelExperience;
    }

    public void SetDefaultValues() {
        _health.ResetHealth();
        HealthChanged?.Invoke(_health.Value);

        _level.ResetLevel();
        LevelChanged?.Invoke(_level.Value);
    }

    public void Heal(int healAmount)
    {
        _health.Add(healAmount);
        HealthChanged?.Invoke(_health.Value);
    }

    public void TakeDamage(int damageAmount)
    {
        _health.Reduce(damageAmount);
        HealthChanged?.Invoke(_health.Value);

        if (_health.Value <= 0)
        {
            Death?.Invoke();
        }
    }

    public void IncreaseExperince(int experienceAmount)
    {
        _experience += experienceAmount;

        if (_experience >= _nextLevelExperience)
        {
            _level.Add(1);
            _experience = 0;
            LevelChanged?.Invoke(_level.Value);
        }
    }

}
