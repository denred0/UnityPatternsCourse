using System.Collections.Generic;
using UnityEngine;

public class OneShotUnlimitedProjectilesPattern : IShootable {

    public List<Vector3> GetProjectilesSpawnPoints(Vector3 initialProjectileSpawnPoint) {
        List<Vector3> projectilesSpawnPoints = new List<Vector3>();

        projectilesSpawnPoints.Add(initialProjectileSpawnPoint);
        Debug.Log("Endless projectiles");

        return projectilesSpawnPoints;
    }

}
