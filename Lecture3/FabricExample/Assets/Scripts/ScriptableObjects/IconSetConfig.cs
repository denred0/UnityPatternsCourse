using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "IconSetConfig", menuName = "Configs/IconSetConfig")]
public class IconSetConfig : ScriptableObject
{
    [SerializeField] private IconType _iconType;

    [SerializeField] private List<ImageIconConfig> _imageIconIconConfigs;
    [SerializeField] private List<ImageTextIconConfig> _imageTextIconIconConfigs;

    [SerializeField] private Vector3 _startingPosition;
    [SerializeField] private int _offset;

    public IconType IconType => _iconType;

    public List<ImageIconConfig> ImageIconConfigs => _imageIconIconConfigs;
    public List<ImageTextIconConfig> ImageTextIconConfigs => _imageTextIconIconConfigs;

    public Vector2 StartingPosition => _startingPosition;

    public int Offset => _offset;
}