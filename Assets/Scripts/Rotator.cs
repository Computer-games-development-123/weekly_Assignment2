using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Vector3 rotationAxis = new Vector3(0f, 0f, 1f); // ברירת מחדל: סביב ציר Z
    [SerializeField] float rotationSpeed = 90f; // מעלות בשנייה

    void Update()
    {
        transform.Rotate(rotationAxis.normalized * rotationSpeed * Time.deltaTime);
    }
}
