using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Player_Score : MonoBehaviour {


    private double CalculateScore(Vector3 pos, GameObject obj1,bool helper)
    {
        double shape2_posY = Math.Round(GameObject.FindGameObjectWithTag("shape2").transform.position.y, 3);
        double shape1_posY = Math.Round(GameObject.FindGameObjectWithTag("shape1").transform.position.y, 3);
        float size = obj1.transform.localScale.y;
        double errorFit = Math.Abs(shape1_posY - shape2_posY);
        double percentage = Math.Round(Math.Abs(size - errorFit) * 100 / size, 2);

        if (percentage > 99.5 && helper)
        {
            pos.y = (float)shape2_posY;
            transform.position = pos;
            helper = false;
        }

        return percentage;

    }

	public void ShowScore(Vector3 pos, GameObject obj1, bool helper)
    {
        double percentage = CalculateScore(pos, obj1,helper);
        percentage = Convert.ToInt32(percentage);
        GmManager.instance.score.text = ("Fitting " + percentage + "%");
        GmManager.instance.scoreList.Add(percentage);
        Debug.Log("Fit percentage is " + percentage + "%");
        
    }

    public void ShowExactScore(double percentage)
    {
        GmManager.instance.score.text = ("Fitting " + percentage + "%");
        GmManager.instance.scoreList.Add(percentage);

    }

   
}
