using System;
using UnityEngine;

public class IconSpawner : MonoBehaviour
{
    [SerializeField] private IconSetConfig _iconSetConfig;
    [SerializeField] private GameObject _parent;

    public void Spawn()
    {
        IconFabric iconFabric = new IconFabric();

        switch (_iconSetConfig.IconType)
        {
            case IconType.ImageOnly:
                SpawnImageIcons(iconFabric, _iconSetConfig, _parent);
                break;
            case IconType.ImageAndText:
                SpawnTextImageIcons(iconFabric, _iconSetConfig, _parent);
                break;
            default:
                throw new ArgumentException(nameof(_iconSetConfig.IconType));
        }
    }

    private void SpawnImageIcons(IconFabric iconFabric, IconSetConfig iconSetConfig, GameObject parent)
    {
        Vector3 iconPosition = iconSetConfig.StartingPosition;

        foreach (ImageIconConfig iconConfig in iconSetConfig.ImageIconConfigs)
        {
            ImageIcon icon = iconFabric.Get(iconConfig, iconPosition);
            icon.transform.SetParent(parent.transform, false);

            iconPosition = GetNewIconPosition(iconPosition, iconSetConfig.Offset);
        }
    }

    private void SpawnTextImageIcons(IconFabric iconFabric, IconSetConfig iconSetConfig, GameObject parent)
    {
        Vector3 iconPosition = iconSetConfig.StartingPosition;

        foreach (ImageTextIconConfig iconConfig in iconSetConfig.ImageTextIconConfigs)
        {
            ImageTextIcon  icon = iconFabric.Get(iconConfig, iconPosition);
            icon.transform.SetParent(parent.transform, false);

            iconPosition = GetNewIconPosition(iconPosition, iconSetConfig.Offset);
        }
    }

    public Vector3 GetNewIconPosition(Vector3 iconPosition, int offset) => new Vector3(iconPosition.x + offset, iconPosition.y, 0);
}
