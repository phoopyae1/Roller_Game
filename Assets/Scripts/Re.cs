   using UnityEngine;
    using UnityEngine.SceneManagement;
    using System.Collections;
    
    public class Re : MonoBehaviour {
    
    	 public void RestartGame()
        {
        // Reload the current scene
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex - 1);
        }
    }