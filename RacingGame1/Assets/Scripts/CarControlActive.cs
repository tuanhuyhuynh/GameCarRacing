using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class CarControlActive : MonoBehaviour
{
    public GameObject CarControl;
    public GameObject DreamCar01;

    public static int SecondCount1;
    public static float MilliCount1;
    public static bool Check;
    // Start is called before the first frame update
    void Start()
    {        
        CarControl.GetComponent<CarController>().enabled = false;
        DreamCar01.GetComponent<CarAIControl>().enabled = false;
    }
    private void Update()
    {
        MilliCount1 += Time.deltaTime * 10;
        if (MilliCount1 >= 10)
        {
            MilliCount1 = 0;
            SecondCount1 += 1;
        }

        if (SecondCount1 == 3)
        {
            Check = true;
        }
        if (Check == true)
        {
            CarControl.GetComponent<CarController>().enabled = true;
            DreamCar01.GetComponent<CarAIControl>().enabled = true;
        }
    }
}
