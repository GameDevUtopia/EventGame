using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class SceneLoader: MonoBehaviour 
{
    public GameObject loadingScreen;
    public Slider slider;
    public void Load (string scene){
       StartCoroutine(LoadAsync(scene));
    }
    IEnumerator LoadAsync (String scene){
        loadingScreen.SetActive(true);

        AsyncOperation op = SceneManager.LoadSceneAsync(scene);
       
        while(!op.isDone){
            float progress = Mathf.Clamp01(op.progress/.9f);
            slider.value = progress;
            yield return null;
        }
    }
    
}
