using System;
using UnityEngine;

[Serializable]
public class ImageIconConfig
{
    [SerializeField] private ImageIcon _iconPrefab;
    [SerializeField] private Sprite _sprite;

    public ImageIcon IconPrefab => _iconPrefab;

    public Sprite Sprite => _sprite;

}