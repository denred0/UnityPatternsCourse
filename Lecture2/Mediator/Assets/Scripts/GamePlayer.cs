using UnityEngine;

public class GamePlayer : MonoBehaviour
{
    [SerializeField] private GamePlayerConfig _config;
    [SerializeField] private HeadPanel _headPanel;
    [SerializeField] private RestartPanel _restartPanel;

    private Player _player;
    private Healer _healer;
    private Damager _damager;
    private GamePlayMediator _gamePlayMediator;

    private void Awake()
    {
        _player = new Player(
            _config.PlayerConfig.InitialLevel, _config.PlayerConfig.InitialHealth, _config.PlayerConfig.NextLevelExperience);
        _gamePlayMediator = new GamePlayMediator(_player, _headPanel, _restartPanel); 
        _player.SetDefaultValues();

        _healer = new Healer(_config.HealerConfig);
        _damager = new Damager(_config.DamagerConfig);

        _restartPanel.Hide();
    }

    private void Update()
    {
        PlayGame();
    }

    private void PlayGame()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            _healer.Heal(_player);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            _damager.Damage(_player);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _player.IncreaseExperince(_config.IncreaseExperienceAmount);

        }
    }

}
