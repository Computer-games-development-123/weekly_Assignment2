using UnityEngine;

public class PulsingObject : MonoBehaviour
{
    [SerializeField] float baseScale = 1f;      // גודל בסיסי
    [SerializeField] float pulseAmplitude = 0.3f; // כמה הוא "מתנפח"
    [SerializeField] float pulseSpeed = 2f;    // מהירות פעימות

    Vector3 originalScale;

    void Start()
    {
        originalScale = Vector3.one * baseScale;
    }

    void Update()
    {
        float sinValue = Mathf.Sin(Time.time * pulseSpeed); // -1..1
        float scaleFactor = 1f + sinValue * pulseAmplitude; // למשל 0.7..1.3
        transform.localScale = originalScale * scaleFactor;
    }
}