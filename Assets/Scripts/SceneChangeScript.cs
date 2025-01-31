using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeScript : MonoBehaviour
{
    void Start()
    {
        if (PlayerPrefs.HasKey("CharacterConfirmation"))
        {
            loadMainGame();
        }
    }

    public void selectCharacter(int i)
    {
        PlayerPrefs.SetInt("Character", i);
        Debug.Log("Selected");
    }

    public void loadMainGame()
    {
        if (!PlayerPrefs.HasKey("Character"))
            return;
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);
        //PlayerPrefs.SetInt("CharacterConfirmation", 1);
        Debug.Log("Confirmed");
    }
}
