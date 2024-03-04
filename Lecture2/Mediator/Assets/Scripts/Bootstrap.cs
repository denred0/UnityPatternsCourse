using UnityEngine;

public class Bootstrap : MonoBehaviour
{
    [SerializeField] private GamePlayerConfig _config;
    [SerializeField] private HeadPanel _headPanel;
    [SerializeField] private RestartPanel _restartPanel;
    [SerializeField] private MainGameHandle _mainGameHandle;

    private void Awake()
    {
        Player player = new Player(
          _config.PlayerConfig.InitialLevel, _config.PlayerConfig.InitialHealth, _config.PlayerConfig.NextLevelExperience);
        GamePlayMediator gamePlayMediator = new GamePlayMediator(player, _headPanel, _restartPanel);
        player.SetDefaultValues();

        Healer healer = new Healer(_config.HealerConfig);
        Damager damager = new Damager(_config.DamagerConfig);

        _restartPanel.Hide();

        _mainGameHandle.Initialize(player, healer, damager, _config);
    }
}
