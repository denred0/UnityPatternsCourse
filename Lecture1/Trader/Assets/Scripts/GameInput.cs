using UnityEngine;

public class GameInput : MonoBehaviour {

    private PlayerInputActions _playerInputActions;

    public static GameInput Instance { get; private set; }


    private void Awake() {
        Instance = this;
        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Enable();
    }

    public Vector2 GetMovementVectorNormalized() {
        Vector2 inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;

        return inputVector;
    }

}
