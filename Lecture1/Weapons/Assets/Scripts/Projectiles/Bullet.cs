using UnityEngine;

public class Bullet : MonoBehaviour, IProjectile {

    [SerializeField] private float _movingSpeed;
    [SerializeField] private float _fireDistance;
    
    private Vector3 _initialBulletSpawnPoint;

    private void Awake() {
        _initialBulletSpawnPoint = transform.position;
    }

    private void Update() {
        MoveProjectile();
        DetectFireDistance();
    }

    public void SetSpeed(float speed) {
        _movingSpeed = speed;
    }

    private void DetectFireDistance() {
        if (Vector3.Distance(transform.position, _initialBulletSpawnPoint) > _fireDistance) {
            Destroy(gameObject);
        }
    }

    private void MoveProjectile() {
        transform.Translate(Vector3.right * _movingSpeed * Time.deltaTime);
    }
}
