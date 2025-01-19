using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void EnableOnClick(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void DisableOnClick(GameObject obj)
    {
        obj.SetActive(false);
    }
}
