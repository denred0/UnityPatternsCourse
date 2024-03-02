using System;

public class Player : IHealable, IDamagable
{
    public event Action<int> HealthChanged;
    public event Action<int> LevelChanged;
    public event Action Death;

    private int _level;
    private int _initialLevel;
    private int _initialHealth;
    private int _experience;
    private int _nextLevelExperience;

    private Health _health;

    public Player(int initialLevel, int initialHeatlh, int nextLevelExperience)
    {
        _initialLevel = initialLevel;

        _initialHealth = initialHeatlh;
        _health = new Health();

        _nextLevelExperience = nextLevelExperience;
    }

    public void SetDefaultValues() {
        _health.SetInitialHealth(_initialHealth);
        HealthChanged?.Invoke(_health.CurrentHealth);
        
        SetInitialLevel();
        LevelChanged?.Invoke(_level);
    }

    public void Heal(int healAmount)
    {
        _health.IncreaseHealth(healAmount);
        HealthChanged?.Invoke(_health.CurrentHealth);
    }

    public void TakeDamage(int damageAmount)
    {
        _health.DecreaseHealth(damageAmount);
        HealthChanged?.Invoke(_health.CurrentHealth);

        if (_health.CurrentHealth <= 0)
        {
            Death?.Invoke();
        }
    }

    public void IncreaseExperince(int experienceAmount)
    {
        _experience += experienceAmount;

        if (_experience >= _nextLevelExperience)
        {
            _level += 1;
            _experience = 0;
            LevelChanged?.Invoke(_level);
        }
    }

    private void SetInitialLevel() {
        _level = _initialLevel;
    }

}
