using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public GameObject SolarSystem;
public bool PlanetsX5=true;
public float speed=1f;
public float[] OrbitSpeeds={0, 600f, 200f, 120f, 66.66667f, 10.34483f, 4.067797f, 1.426873f, 0.728155f, 0.483286f};
GameObject[] Orbits=new GameObject[10];
Transform[] OrbitTransforms=new Transform[10];


    void Start()
    {
        for(int i=0;i<SolarSystem.transform.childCount; i++){
            Orbits[i]=SolarSystem.gameObject.transform.GetChild(i).gameObject;
            OrbitTransforms[i]=SolarSystem.gameObject.transform.GetChild(i).transform;
        }


        if(PlanetsX5){
            for(int i=1;i<Orbits.Length; i++){
                Orbits[i].transform.GetChild(0).localScale*= 5;
            }
        }
    }
    
    void Update()
    {
        for(int i=1;i<SolarSystem.transform.childCount; i++){
            OrbitTransforms[i].Rotate(0 , speed*OrbitSpeeds[i]*Time.deltaTime , 0 , Space.Self);
        }

        OrbitTransforms[3].GetChild(0).GetChild(0).transform.Rotate(0 , speed*1604.396f*Time.deltaTime , 0 , Space.Self);

    }
}
