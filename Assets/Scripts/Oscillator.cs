using UnityEngine;

public class Oscillator : MonoBehaviour
{
    [SerializeField] Vector3 movementDirection = Vector3.right; // כיוון התנודה
    [SerializeField] float distance = 3f;        // מרחק מקסימלי לכל צד
    [SerializeField] float period = 2f;          // כמה זמן ל"סיבוב" מלא של הסינוס

    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        if (period <= 0f) return;

        float cycles = Time.time / period;               // כמה מחזורים עברו
        float sinValue = Mathf.Sin(cycles * 2f * Mathf.PI); 
        // sin בין -1 ל+1, מאיץ ומאט אוטומטית

        float offset = sinValue * distance;
        transform.position = startPos + movementDirection.normalized * offset;
    }
}
