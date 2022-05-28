using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PkkCode
{
    public class SceneLoader {
        public static IEnumerator loadSceneLate(string sceneName, float seconds){
            Debug.Log("WAITING TO LOAD SCENE...");
            yield return new WaitForSeconds(seconds);
            Debug.Log("COMPLETE LOADING SCENE.");
            SceneManager.LoadScene(sceneName);
        }

        public static IEnumerator LoadSceneAsync(string sceneName) {
            // The Application loads the Scene in the background as the current Scene runs.
            // This is particularly good for creating loading screens.
            // You could also load the Scene by using sceneBuildIndex. In this case Scene2 has
            // a sceneBuildIndex of 1 as shown in Build Settings.

            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName);

            // Wait until the asynchronous scene fully loads
            while (!asyncLoad.isDone) {
                yield return null;
            }
        }
    }
}


