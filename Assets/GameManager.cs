using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
public GameObject MercuryOrbit;
public  Vector3 MercuryTurn=new Vector3(0,360,0);
public float MercuryTurnSpeed=0.1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        MercuryOrbit.transform.Rotate(0 , MercuryTurnSpeed*Time.deltaTime , 0 , Space.Self);
        
    }
}
