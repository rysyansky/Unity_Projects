using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollisionDec : MonoBehaviour
{
    
    static int DecCount = 100;
    // Start is called before the first frame update
    [SerializeField]
    private TMP_Text _space;
    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        DecCount--;
        _space.text = DecCount.ToString();
        print(DecCount);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
