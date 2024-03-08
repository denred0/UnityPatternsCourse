using UnityEngine;

public class FabricExample : MonoBehaviour
{
    [SerializeField] private IconSpawner _iconSpawner;

    void Start()
    {
        _iconSpawner.Spawn();
    }

}
