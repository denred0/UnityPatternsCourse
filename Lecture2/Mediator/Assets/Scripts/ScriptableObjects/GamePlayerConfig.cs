using UnityEngine;

[CreateAssetMenu(fileName = "GamePlayerConfig", menuName = "Configs/GamePlayerConfig")]
public class GamePlayerConfig : ScriptableObject
{
    [SerializeField] private PlayerConfig _playerConfig;
    [SerializeField] private HealerConfig _healerConfig;
    [SerializeField] private DamagerConfig _damagerConfig;

    [SerializeField, Range(10, 50)] private int _increaseExperienceAmount;

    public PlayerConfig PlayerConfig => _playerConfig;

    public HealerConfig HealerConfig => _healerConfig;

    public DamagerConfig DamagerConfig => _damagerConfig;

    public int IncreaseExperienceAmount => _increaseExperienceAmount;

}
