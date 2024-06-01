using UnityEngine;
using UnityEngine.UI;

public class ChangeColorOnMap : MonoBehaviour
{
    public static ChangeColorOnMap Instance; // Singleton instance
    public Color newColor; // New color to be set
    [SerializeField] private Image imageComponent; // Reference to the Image component

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ChangeColor()
    {
        if (imageComponent != null)
        {
            imageComponent.color = newColor;
        }
    }
}
