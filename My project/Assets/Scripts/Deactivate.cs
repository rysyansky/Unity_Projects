using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deactivate : MonoBehaviour
{
    bool dsbl = true;
    //public Button byton;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(dsbl);
    }
    public void OnButtonClick()
    {
        if (dsbl)
        {
            dsbl = false;
            gameObject.SetActive(dsbl);
        }
        else
        {
            dsbl = true;
            gameObject.SetActive(dsbl);
        }
    }
}
