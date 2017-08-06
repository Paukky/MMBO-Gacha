using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play_Button : MonoBehaviour
{
    public void Button_Click()
    {
        Debug.Log("CLICKED BOI");
        SceneManager.LoadScene(1);
    }
}
