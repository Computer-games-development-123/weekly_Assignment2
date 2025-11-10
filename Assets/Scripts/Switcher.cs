using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    void Update()
    {
        // 1 = מעבר לסצנה של הרכיבים (PartA)
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("PartA");
        }

        // 2 = מעבר לסצנה של המיני-מפה (PartB)
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("PartB");
        }
    }
}
