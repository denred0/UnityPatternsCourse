using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class CharacterVIew : MonoBehaviour
{
    private const string IsMovement = "IsMovement";
    private const string IsRunning = "IsRunning";
    private const string IsWorking = "IsWorking";
    private const string IsResting = "IsResting";

    private Animator _animator;

    public void Initialize() => _animator = GetComponent<Animator>();


    public void StartMovement() => _animator.SetBool(IsMovement, true);
    public void StopMovement() => _animator.SetBool(IsMovement, false);

    public void StartRunning() => _animator.SetBool(IsRunning, true);
    public void StopRunning() => _animator.SetBool(IsRunning, false);

    public void StartWorking() => _animator.SetBool(IsWorking, true);
    public void StopWorking() => _animator.SetBool(IsWorking, false);

    public void StartResting() => _animator.SetBool(IsResting, true);
    public void StopResting() => _animator.SetBool(IsResting, false);

}
