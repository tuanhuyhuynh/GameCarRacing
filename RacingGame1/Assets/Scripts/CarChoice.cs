using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour
{
    //1 = red , 2 = blue
    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject GreenBody;
    public int CarImport;
    // Start is called before the first frame update
    void Start()
    {
        CarImport = GlobalCar.CarType;
        if(CarImport == 1)
        {
            RedBody.SetActive(true);
        }
        if (CarImport == 2)
        {
            BlueBody.SetActive(true);
        }
        if (CarImport == 3)
        {
            GreenBody.SetActive(true);
        }
    }
}
