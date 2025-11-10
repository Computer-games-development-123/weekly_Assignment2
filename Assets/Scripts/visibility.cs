using UnityEngine;

public class ToggleVisibility : MonoBehaviour
{
    [SerializeField] KeyCode toggleKey = KeyCode.H;

    SpriteRenderer objRenderer;

    void Awake()
    {
        objRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if (objRenderer != null)
            {
                objRenderer.enabled = !objRenderer.enabled;
            }
        }
    }
}
