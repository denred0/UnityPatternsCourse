using System.Collections.Generic;
using UnityEngine;

public class OneShotLimitedProjectilesPattern : IShootable {

    private int _currentProjectilesCount;

    public OneShotLimitedProjectilesPattern(int initialProjectilesCount) {
        _currentProjectilesCount = initialProjectilesCount;
    }

    public bool isNoProjectiles => _currentProjectilesCount == 0;

    public List<Vector3> GetProjectilesSpawnPoints(Vector3 initialProjectileSpawnPoint) {
        List<Vector3> projectilesSpawnPoints = new List<Vector3>();

        if (isNoProjectiles == false) {
            projectilesSpawnPoints.Add(initialProjectileSpawnPoint);
            _currentProjectilesCount -= 1;
            Debug.Log($"Projectiles left: {_currentProjectilesCount}");
        }

        return projectilesSpawnPoints;
    }

}
