using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Infinite : MonoBehaviour
{
    [SerializeField]
    public Transform datapoint;
    public Transform datapoint2;

    private Vector3 home;

    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        home = new Vector3(-40, -.25f, -18);
    }

    void Update() {
        if (i % 10 == 0) {
            Instantiate (datapoint, home, Quaternion.identity);
            Instantiate (datapoint2, home, Quaternion.identity);
        }
        i++;
    }
}


/*    void Update() {
        if (i % 10 == 0) {
            Instantiate (datapoint, home, Quaternion.identity);
            Instantiate (datapoint2, home, Quaternion.identity);
        }
        i++;
    } */