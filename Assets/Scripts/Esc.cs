using UnityEngine;

public class Esc : MonoBehaviour
{
    public GameObject panel;

    void Update()
    {
        // Check if the "Esc" key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
              Time.timeScale = 0;
            panel.SetActive(true);
        }
    }
}
