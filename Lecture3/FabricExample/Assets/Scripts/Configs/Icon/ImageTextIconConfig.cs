using System;
using UnityEngine;

[Serializable]
public class ImageTextIconConfig
{
    [SerializeField] private ImageTextIcon _iconPrefab;
    [SerializeField] private Sprite _sprite;
    [SerializeField] private string _text;

    public ImageTextIcon IconPrefab => _iconPrefab;

    public Sprite Sprite => _sprite;

    public string Text => _text;

}