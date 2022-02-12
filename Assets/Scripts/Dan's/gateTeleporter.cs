using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateTeleporter : MonoBehaviour
{
    public GameObject gateRotator;
    public Transform[] childrenTransforms;
    private Vector3 nextPosition;
    // Start is called before the first frame update
    void Start()
    {
        childrenTransforms = this.transform.parent.GetComponentsInChildren<Transform>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            gateRotator.GetComponent<gateLocationFixer>().rotateGates();
            nextPosition = childrenTransforms[Random.Range(1, 5)].position;
            other.transform.SetPositionAndRotation(nextPosition - nextPosition.normalized, Quaternion.identity);
            other.transform.LookAt(Vector3.zero);
        }
    }

}
