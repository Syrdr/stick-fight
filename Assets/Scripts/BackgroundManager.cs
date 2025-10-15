using UnityEngine.UI;
using UnityEngine;

public class BackgroundManager : MonoBehaviour
{
    [SerializeField] private Sprite[] backgroundSprites;
    public BackgroundType currentBackgroundType;

    void Awake()
    {
        Image image = GetComponent<Image>();
        switch(currentBackgroundType)
        {
            case BackgroundType.Coastal_City:
                if (backgroundSprites != null && backgroundSprites.Length > 0)
                {
                    image.sprite = backgroundSprites[0];
                }
                break;
            case BackgroundType.Port:
                if (backgroundSprites != null && backgroundSprites.Length > 1)
                {
                    image.sprite = backgroundSprites[1];
                }
                break;
            case BackgroundType.Night_City:
                if (backgroundSprites != null && backgroundSprites.Length > 2)
                {
                    image.sprite = backgroundSprites[2];
                }
                break;
            default:
                if (backgroundSprites != null && backgroundSprites.Length > 0)
                {
                    image.sprite = backgroundSprites[0];
                }
                break;
        }
        if (image != null && backgroundSprites != null && backgroundSprites.Length > 0)
        {
            image.sprite = backgroundSprites[0];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//[System.Flags]
public enum BackgroundType: short
{
    Coastal_City,
    Port,
    Night_City,
}