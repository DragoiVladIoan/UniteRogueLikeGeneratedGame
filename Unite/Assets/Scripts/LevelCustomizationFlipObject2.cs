using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCustomizationFlipObject2 : MonoBehaviour
{
    private float flipTime = 0;
    private bool turn = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
            if(turn)
                GetComponent<SpriteRenderer>().flipX = false;
            else
                GetComponent<SpriteRenderer>().flipX = true;
            turn = !turn;
        }
    }
}
