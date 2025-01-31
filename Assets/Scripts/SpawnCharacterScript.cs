using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnCharacterScript : MonoBehaviour
{
    [SerializeField] GameObject[] characters = new GameObject[4];

    void Start()
    {
        if (!PlayerPrefs.HasKey("Character"))
            return;

        Instantiate(characters[PlayerPrefs.GetInt("Character")]);
    }

}
