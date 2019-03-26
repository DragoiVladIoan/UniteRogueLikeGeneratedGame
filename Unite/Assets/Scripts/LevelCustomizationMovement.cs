using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCustomizationMovement : MonoBehaviour
{
    public  GameObject  obj2;
    private string direction = "up";
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (direction == "up")
        {
            if (pos.y < 3.0f)
            {
                pos.y += 8 * Time.deltaTime;
            }
            else
            {
                direction = "down";
                pos.y -= 8 * Time.deltaTime;
            }

        }
        else
        {
            if (pos.y > -3.0f)
            {
                pos.y -= 8 * Time.deltaTime;
            }
            else
            {
                direction = "up";
                pos.y += 8 * Time.deltaTime;
            }
        }
        transform.position = pos;

    }
}
