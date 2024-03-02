using TMPro;
using UnityEngine;

public class HeadPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _levelText;
    [SerializeField] private TextMeshProUGUI _healthText;

    public void Show() => this.gameObject.SetActive(true);
    public void Hide() => this.gameObject.SetActive(false);

    public void SetLevelText(int level)
    {
        _levelText.text = $"Level: {level}";
    }

    public void SetHealthText(int health)
    {
        _healthText.text = $"Health: {health}";
    }
}
