using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCustomizationFlip : MonoBehaviour
{
    private float flipTime = 0;
    public  Player_Move playerMove;
    
    // Start is called before the first frame update
    void Start()
    {
        playerMove = GetComponent<Player_Move>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - flipTime > 1.5)
        {
            
            Vector3 pos = transform.position;
            pos.x = -pos.x;
            pos.y = -pos.y;
            transform.position = pos;
            flipTime = Time.time;
            if (playerMove.direction == "right")
            {
                GetComponent<SpriteRenderer>().flipX = true;
                playerMove.direction = "left";
            }
            else
            {
                GetComponent<SpriteRenderer>().flipX = false;
                playerMove.direction = "right";
            }
            

        }

        
       
    }
}
