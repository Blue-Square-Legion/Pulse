using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{

    public float value;
    public GameObject needle;
    
    private float startPosition = 220f;
       private float endPosition;
    void Start()
    { 
        float x =CarController.steeringAxis; }


  public void  UpdateNeedle()
    {
         value = Mathf.Sin(Time.deltaTime)*100f;
       // var value = Mathf.Lerp(-1f, 1f, .02f);
      // float desiredPosition = startPosition - endPosition;
        //float temp = CarController.speed / 180;
      //  needle.transform.eulerAngles = new Vector3(0f, 0f,(startPosition - temp * desiredPosition));
        needle.transform.eulerAngles = new Vector3(0f, 0f, SinMovementZ());
    }
    public float SinMovementZ()
    {
        return transform.position.z - Mathf.Sin(Time.time * 10) * 10 * Time.deltaTime;
    }
        void Update()
    {
        value =800*(SinMovementZ());
        needle.transform.eulerAngles = new Vector3(0f, 0f, value);
    }
}