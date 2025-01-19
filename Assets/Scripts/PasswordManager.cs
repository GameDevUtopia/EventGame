using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PasswordManager : MonoBehaviour{
    public SceneLoader sceneLoader;
    public string scene; 
    public TMP_Text inputField;
    private string inputText;
    public string password = "abcde";
    void Update()
    {
        if (inputText == password){
            sceneLoader.Load(scene);
        }
    }
    public void GrabInputField(string input){
            inputText = input;

    }
}
