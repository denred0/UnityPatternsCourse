using UnityEngine;

public class IconFabric
{
    public ImageIcon Get(ImageIconConfig iconConfig, Vector3 position)
    {
        ImageIcon icon = Object.Instantiate(iconConfig.IconPrefab, position, Quaternion.identity);
        icon.SetSprite(iconConfig.Sprite);
        return icon;
    }

    public ImageTextIcon Get(ImageTextIconConfig iconConfig, Vector3 position)
    {
        ImageTextIcon icon = Object.Instantiate(iconConfig.IconPrefab, position, Quaternion.identity);
        icon.SetSprite(iconConfig.Sprite);
        icon.SetText(iconConfig.Text);
        return icon;
    }

}
