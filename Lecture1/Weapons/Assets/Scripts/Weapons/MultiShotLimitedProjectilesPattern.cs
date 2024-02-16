using System;
using System.Collections.Generic;
using UnityEngine;

public class MultiShotLimitedProjectilesPattern : IShootable {

    private int _currentProjectilesCount;
    private int _projectilesPerShot;
    private float _projectilesOffset;

    public MultiShotLimitedProjectilesPattern(int initialProjectilesCount, int projectilesPerShot, float projectilesOffset) {
        _currentProjectilesCount = initialProjectilesCount;
        _projectilesPerShot = projectilesPerShot;
        _projectilesOffset = projectilesOffset;
    }

    public bool isNoProjectiles => _currentProjectilesCount == 0;

    public List<Vector3> GetProjectilesSpawnPoints(Vector3 initProjectileSpawnPoint) {
        List<Vector3> projectilesSpawnPoints = new List<Vector3>();

        if (isNoProjectiles == false) {
            
            int remainProjectiles = _currentProjectilesCount - _projectilesPerShot;

            int currentShotProjectiles = 0;
            if (remainProjectiles > 0) {
                currentShotProjectiles = _projectilesPerShot;
            } else {
                currentShotProjectiles = _currentProjectilesCount;
            }

            int halfOfList = currentShotProjectiles / 2;

            for (int i = 0; i < currentShotProjectiles; i++) {
                Vector3 spawnPointLeft = new Vector3(initProjectileSpawnPoint.x, initProjectileSpawnPoint.y, initProjectileSpawnPoint.z + _projectilesOffset * i * (-1));
                projectilesSpawnPoints.Add(spawnPointLeft);
                _currentProjectilesCount -= 1;
            }

            if (currentShotProjectiles % 2 == 0) {
                for (int i = 0; i < projectilesSpawnPoints.Count; i++) {
                    projectilesSpawnPoints[i] = new Vector3(
                        projectilesSpawnPoints[i].x,
                        projectilesSpawnPoints[i].y,
                        projectilesSpawnPoints[i].z + _projectilesOffset * halfOfList - _projectilesOffset / 2);

                }
            } else {
                for (int i = 0; i < projectilesSpawnPoints.Count; i++) {
                    projectilesSpawnPoints[i] = new Vector3(
                        projectilesSpawnPoints[i].x,
                        projectilesSpawnPoints[i].y,
                        projectilesSpawnPoints[i].z + _projectilesOffset * halfOfList);
                }
            }
        }

        Debug.Log($"Projectiles left: {_currentProjectilesCount}");

        return projectilesSpawnPoints;
    }
}
