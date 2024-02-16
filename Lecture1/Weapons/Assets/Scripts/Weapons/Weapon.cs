using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    [Header("Projectile data")]
    [SerializeField] private Bullet _projectilePrefab;
    [SerializeField] private Transform _projectileSpawnPoint;
    [SerializeField] private float _projectileSpeed;

    private IShootable _shootable;

    public void SetWeaponPattern(IShootable shootable) {
        _shootable = shootable;
    }

    public void MakeShot() {
        if (_shootable == null)
            return;

        List<Vector3> projectilesSpawnPoints = _shootable.GetProjectilesSpawnPoints(_projectileSpawnPoint.position);

        foreach (Vector3 projectileSpawnPoint in projectilesSpawnPoints) {
            IProjectile projectile = Instantiate(_projectilePrefab, projectileSpawnPoint, Quaternion.identity);
            projectile.SetSpeed(_projectileSpeed);
        }
    }

}
