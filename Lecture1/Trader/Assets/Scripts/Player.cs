using System;
using UnityEngine;

public class Player : MonoBehaviour, IReputationPicker {

    [SerializeField] private float _movingSpeed;

    private Vector3 _lastDirection;

    public int Reputation { get; private set; }

    private void Update() {
        HandleMovement();
    }

    public void AddReputation(int reputationAmount) {
        if (reputationAmount < 0)
            throw new ArgumentException(nameof(reputationAmount));

        Reputation += reputationAmount;
        Debug.Log(Reputation);
    }

    private void HandleMovement() {
        Vector2 inputVector = GameInput.Instance.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, inputVector.y);

        float moveDistance = _movingSpeed * Time.deltaTime;
        transform.position += moveDir * moveDistance;

        float rotationSpeed = 10f;
        if (moveDir != Vector3.zero)
            _lastDirection = moveDir;

        transform.forward = Vector3.Slerp(transform.forward, _lastDirection, Time.deltaTime * rotationSpeed);
    }


}
