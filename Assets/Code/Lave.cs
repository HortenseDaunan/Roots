using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lave : MonoBehaviour
{

    public GameObject ScriptHolder;
    public GameObject P2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "Player1")
        {
            ScriptHolder.GetComponent<Player1>().lave = true;
        }
        if (c.gameObject.name == "Player2")
        {
            P2.GetComponent<Player2>().lave = true;
        }


    }
}