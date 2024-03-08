using UnityEngine;
using UnityEngine.UI;

public class ImageIcon: BaseIcon
{
    [SerializeField] private Image _image;

    public override void SetSprite(Sprite sprite)
    {
        _image.sprite = sprite;
    }

}
