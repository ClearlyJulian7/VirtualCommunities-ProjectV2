using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateLocationFixer : MonoBehaviour
{
    public int rotateBy;

    // Start is called before the first frame update
    void Start()
    {
        rotateBy = Random.Range(0, 4) * 90;
        this.transform.SetPositionAndRotation(this.transform.position, Quaternion.Euler(0, rotateBy, 0));
    }

    // Update is called once per frame
    void Update()
    {
        rotateBy = Random.Range(0, 4) * 90;
    }

    public void rotateGates()
    {
        this.transform.SetPositionAndRotation(this.transform.position, Quaternion.Euler(0, rotateBy, 0));
    }
}
