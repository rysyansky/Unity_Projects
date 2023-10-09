using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeactObj : MonoBehaviour
{
    bool sex = true;
    //public Button byton;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(sex);
    }
    public void OnButtonClick()
    {
        if (sex)
        {
            sex = false;
            gameObject.SetActive(sex);
        }
        else
        {
            sex = true;
            gameObject.SetActive(sex);
        }
    }
}
