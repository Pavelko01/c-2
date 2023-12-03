using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRun : MonoBehaviour
{
    public int Healht = 5;
    public int levell = 6;

    public float speed = 1.2f;
    private Vector3 newPosition;
   
    

    // Start is called before the first frame update
    void Start()
    {
        //imba
        Healht += levell;
        print("Здоровье куба ="+Healht);
        
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
