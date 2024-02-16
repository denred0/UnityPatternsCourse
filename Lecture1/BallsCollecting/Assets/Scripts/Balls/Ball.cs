using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    [SerializeField] private BallType _ballType;

    [Header("Materials")]
    [SerializeField] private Material _redMaterial;
    [SerializeField] private Material _greenMaterial;
    [SerializeField] private Material _whiteMaterial;


    public static Dictionary<BallType, int> BallTypesCountDict = new Dictionary<BallType, int>(){
        { BallType.White, 0},
        { BallType.Red, 0},
        { BallType.Green, 0}
    };

    public enum BallType {
        White,
        Red,
        Green
    };

    public BallType CurrentBallType => _ballType;

    private Renderer _renderer;

    private void Awake() {
        _renderer = GetComponent<Renderer>();
        SetBallMaterial();
    }

    private void SetBallMaterial() {
        if (_ballType == BallType.White) {
            _renderer.material = _whiteMaterial;
            BallTypesCountDict[BallType.White] = BallTypesCountDict[BallType.White] + 1;
        } else if (_ballType == BallType.Red) {
            _renderer.material = _redMaterial;
            BallTypesCountDict[BallType.Red] = BallTypesCountDict[BallType.Red] + 1;
        } else if (_ballType == BallType.Green) {
            _renderer.material = _greenMaterial;
            BallTypesCountDict[BallType.Green] = BallTypesCountDict[BallType.Green] + 1;
        }
    }
}
