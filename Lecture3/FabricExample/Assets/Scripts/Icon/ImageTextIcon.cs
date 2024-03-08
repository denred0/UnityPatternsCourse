using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ImageTextIcon : BaseIcon
{
    [SerializeField] private Image _image;
    [SerializeField] private TextMeshProUGUI _text;

    public override void SetSprite(Sprite sprite)
    {
        _image.sprite = sprite; 
    }

    public void SetText(string text)
    {
        _text.text = text;
    }
    
}
