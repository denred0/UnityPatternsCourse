using System.Collections.Generic;
using UnityEngine;

public interface IShootable {

    List<Vector3> GetProjectilesSpawnPoints(Vector3 initialProjectileSpawnPoint);

}
