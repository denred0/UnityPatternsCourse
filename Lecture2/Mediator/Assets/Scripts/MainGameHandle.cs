using UnityEngine;

public class MainGameHandle : MonoBehaviour
{
    private Player _player;
    private GamePlayerConfig _config;
    private Healer _healer;
    private Damager _damager;

    public void Initialize(Player player, Healer healer, Damager damager, GamePlayerConfig config)
    {
        _player = player;
        _config = config;
        _healer = healer;
        _damager = damager;
    }

    private void Update()
    {
        GameInputHandle();
    }

    private void GameInputHandle()
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
