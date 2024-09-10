using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{   

    [SerializeField] private float moveSpeed;
    [SerializeField] private float moveDistance;
    private Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        Debug.Log(startPosition);
    }

    // Update is called once per frame
    void Update()
    {
        LoopPlatform();
    }

    private bool isMovingRight = true;
    private void LoopPlatform(){

        if(isMovingRight){
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }else{
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }

        if (transform.position.x >= startPosition.x + moveDistance){
            isMovingRight = false;
        }
        else if(transform.position.x <= startPosition.x - moveDistance){
            isMovingRight = true;
        }
    }

}
