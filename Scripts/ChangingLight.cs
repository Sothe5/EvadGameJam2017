using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangingLight : MonoBehaviour {

    public float timeToChangeLight = 30;
    public Light changedLight;
    public Color day;
    public Color night;

    private int material;
    private float timer;
    private bool changed;
    private Color dayMinusNight;
    private Color nightMinusDay;

    // Use this for initialization
    void Start () {
        material = Random.Range(0, 2);
        dayMinusNight = day - night;
        nightMinusDay = night - day;
        if(material == 0)
        {
            changedLight.color = day;
        }
        else
        {
            changedLight.color = night;
        }

    }
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer >= timeToChangeLight)
        {
            if(material == 0)
            {
                if (changedLight.color.r <= night.r
                    && changedLight.color.g <= night.g
                    && changedLight.color.b >= night.b)
                {
                    changed = true;
                }
                else
                {
                    changedLight.color -= dayMinusNight / 3 * Time.deltaTime;
                }
            }
            else if(material == 1)
            {
                if (changedLight.color.r >= day.r 
                    && changedLight.color.g >= day.g 
                    && changedLight.color.b <= day.b)
                {
                    changed = true;
                }
                else
                {
                    changedLight.color -= nightMinusDay/3 * Time.deltaTime;
                }
            }
            if (changed)
            {
                material = (material + 1) % 2;
                timer = 0;
                changed = false;
            }
        }
	}
}
