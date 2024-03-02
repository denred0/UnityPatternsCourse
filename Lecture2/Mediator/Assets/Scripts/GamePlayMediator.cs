public class GamePlayMediator
{
    private Player _player;
    private HeadPanel _headPanel;
    private RestartPanel _restartPanel;
     
    public GamePlayMediator(Player player, HeadPanel headPanel, RestartPanel restartPanel)
    {
        _player = player;
        _player.HealthChanged += OnHealthChanged;
        _player.LevelChanged += OnLevelChanged;
        _player.Death += OnDeath;

        _headPanel = headPanel;

        _restartPanel = restartPanel;
        _restartPanel.Restart += OnRestart;
    }

    private void OnDeath()
    {
        _restartPanel.Show();
    }

    private void OnRestart()
    {
        _restartPanel.Hide();
        _player.SetDefaultValues();
    }

    private void OnHealthChanged(int health)
    { 
        _headPanel.SetHealthText(health);
    }

    private void OnLevelChanged(int level)
    {
        _headPanel.SetLevelText(level); 
    }
}
