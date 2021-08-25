using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    private int i = 3;
    private int ranNumber;
    
    // Start is called before the first frame update
    void Start()
    {
        //se the random number
        ranNumber = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);
        //deactivate the red game object if meet the condition
        if (gameObject.tag == "Red" && i == 100)
        {
            gameObject.SetActive(false);
        }
        //deactivate the blue game object if meet the condition
        if (gameObject.tag == "Blue" && i == ranNumber)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
