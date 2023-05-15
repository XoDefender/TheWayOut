using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool active;
    private void Start()
    {
        Pause_Menu.gameObject.SetActive(false);
        active = false;
    }
    public GameObject Pause_Menu;
    // Update is called once per frame
    void Update()
    {
          ESC();
    }
    public void ESC()
    {
        if (Input.GetKey(KeyCode.Escape))
        {

            Debug.Log("+\n");
            int d = 0;
            for (long i = 0; i<500000000; i++)
                d= 0;
            active=!active;
            Pause_Menu.gameObject.SetActive(active);

        }
    }

    public void pause()
    {
        active=!active;
        Pause_Menu.gameObject.SetActive(active);
    }
}
