using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace PkkCode
{
    public class SceneLoader {
        public static IEnumerator loadSceneLate(string sceneName, float seconds){
            yield return new WaitForSeconds(seconds);
            SceneManager.LoadScene(sceneName);
        }
    }
}


