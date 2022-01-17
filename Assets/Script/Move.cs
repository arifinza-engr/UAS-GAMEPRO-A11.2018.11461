using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnGUI()
    {
        GUI.Label(new Rect(Screen.width / 2, Screen.width / 2, 200, 30), "Selamat Datang Di Game");
    }
}
