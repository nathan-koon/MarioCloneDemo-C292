using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision){
        Debug.Log("Enter");
    }

    private void OnCollisionExit2D(Collision2D collision){
        Debug.Log("Exit");
    }

    private void OnCollisionStay2D(Collision2D collision){
        Debug.Log("Stay");
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
