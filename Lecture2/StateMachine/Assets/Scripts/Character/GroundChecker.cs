using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private LayerMask _ground;
    [SerializeField, Range(0.1f, 1f)] private float _distanceToCheck;

    public bool IsTouch { get; private set; }

    private void Update() => IsTouch = Physics.CheckSphere(transform.position, _distanceToCheck, _ground);
}
