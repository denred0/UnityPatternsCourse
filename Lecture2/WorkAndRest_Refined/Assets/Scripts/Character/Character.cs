using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour
{
    [SerializeField] private CharacterConfig _config;
    [SerializeField] private CharacterVIew _view;

    private CharacterStateMachine _stateMachine;
    private CharacterController _characterController;

    public CharacterController Controller => _characterController;
    public CharacterConfig Config => _config;
    public CharacterVIew View => _view;

    private void Awake()
    {
        _view.Initialize();
        _characterController = GetComponent<CharacterController>();
        _stateMachine = new CharacterStateMachine(this);
    }

    private void Update()
    {
        _stateMachine.Update();
    }

}
