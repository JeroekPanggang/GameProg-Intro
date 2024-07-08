using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitApp : MonoBehaviour
{

    public void Start()
    {
        Invoke("QuitApplication", 11f);
    }
    public void QuitApplication()
    {
        Application.Quit();
        Debug.Log("Aku Keluar");
    }

}
