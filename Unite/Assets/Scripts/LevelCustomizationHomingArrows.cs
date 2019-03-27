using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class LevelCustomizationHomingArrows : MonoBehaviour
{
    //public GameObject obj1
    private Camera mainCamera;
    public GameObject arrow;
    private float spawnTime = 0;
    private int numberOfArrows;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        //mainCamera.transform.Rotate(Vector3.forward, 90.0f * Time.deltaTime);
        if (Time.time - spawnTime > 1)
        {
            
            int temp = numberOfArrows;
            while (temp > 0)
            {
                float xPos = Random.Range(-8.0f, -7.0f);
                float yPos = Random.Range(-3.0f, 3.0f);
                GameObject instance = Instantiate(arrow, new Vector3(xPos, yPos, 0f), Quaternion.identity) as GameObject;
                temp--;
            }

            spawnTime = Time.time;
            numberOfArrows += 1;

        }
        

    }

}

    

