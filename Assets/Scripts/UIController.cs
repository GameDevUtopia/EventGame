using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public void EnableOnClick(GameObject obj)
    {
        obj.SetActive(true);
    }
    public void DisableOnClick(GameObject obj)
    {
        obj.SetActive(false);
    }
}
