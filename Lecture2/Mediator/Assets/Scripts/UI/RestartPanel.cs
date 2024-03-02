using System;
using UnityEngine;
using UnityEngine.UI;

public class RestartPanel : MonoBehaviour
{
    public event Action Restart;

    [SerializeField] private Button _restart;

    public void Show() => this.gameObject.SetActive(true);
    public void Hide() => this.gameObject.SetActive(false);

    private void OnEnable()
    {
        _restart.onClick.AddListener(OnRestartClick);
    }

    private void OnDisable()
    {
        _restart?.onClick.RemoveListener(OnRestartClick);
    }

    private void OnRestartClick()
    {
        Restart?.Invoke();
    }
}
