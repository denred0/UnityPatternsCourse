public class Health
{
    private int _currentHealth;

    public Health()
    {
    }

    public void SetInitialHealth(int initialHealth)
    {
        _currentHealth += initialHealth;
    }

    public int CurrentHealth => _currentHealth;

    public void DecreaseHealth(int decreaseAmount)
    {
        if (_currentHealth - decreaseAmount < 0)
        {
            _currentHealth = 0;
        } else
        {
            _currentHealth -= decreaseAmount;
        }
    }

    public void IncreaseHealth(int increaseAmount)
    {
        _currentHealth += increaseAmount;
    }

}
