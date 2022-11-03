using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public GameObject SolarSystem;
public  Vector3 OrbitTurn=new Vector3(0,360,0);
public float MercuryTurnSpeed=120f;
public float[] OrbitSpeeds={0, 600f, 200f, 120f, 66.66667f, 10.34483f, 4.067797f, 1.426873f, 0.728155f, 0.483286f};

        
    void Start()
    {
        /* for(int i=1;i<SolarSystem.transform.childCount; i++){
            SolarSystem.gameObject.transform.GetChild(i).transform.GetChild(0).localScale*= 5;
        } */

    }
    
    void Update()
    {
        for(int i=1;i<SolarSystem.transform.childCount; i++){
            SolarSystem.gameObject.transform.GetChild(i).transform.Rotate(0 , OrbitSpeeds[i]*Time.deltaTime , 0 , Space.Self);
        }
    }
}
