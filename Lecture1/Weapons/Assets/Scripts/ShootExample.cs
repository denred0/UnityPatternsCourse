using UnityEngine;

public class ShootExample : MonoBehaviour {

    [Header("Weapon data")]
    [SerializeField] private Weapon _weapon;
    
    [Header("Projectile data")]
    [SerializeField] private int _projectilesAmount;
    [SerializeField] private int _projectilesPerShot;
    [SerializeField] private float _projectilesOffset;

    private void Awake() {
        SetInitialWeapon();
    }

    private void SetInitialWeapon() {
        Debug.Log("One shot, limited projectiles");
        _weapon.SetWeaponPattern(new OneShotLimitedProjectilesPattern(_projectilesAmount));
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            Debug.Log("One shot, limited projectiles");
            _weapon.SetWeaponPattern(new OneShotLimitedProjectilesPattern(_projectilesAmount));
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            Debug.Log("One shot, unilimited projectiles");
            _weapon.SetWeaponPattern(new OneShotUnlimitedProjectilesPattern());
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            Debug.Log("Multishot, limited projectiles");
            _weapon.SetWeaponPattern(new MultiShotLimitedProjectilesPattern(_projectilesAmount, _projectilesPerShot, _projectilesOffset));
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            _weapon.MakeShot();
        }
    }
}
