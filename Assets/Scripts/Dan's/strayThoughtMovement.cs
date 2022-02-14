using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strayThoughtMovement : MonoBehaviour
{
    Rigidbody thisThought;
    Vector3 randomDirection;
    float time = 0;
    public float interval = 1;
    public float moveSpeed = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreLayerCollision(6, 0);
        thisThought = this.GetComponent<Rigidbody>();
        randomDirection = Random.onUnitSphere; // generate a new random direction
        thisThought.AddForce(randomDirection * moveSpeed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > interval) {
            randomDirection = Random.onUnitSphere; // generate a new random direction
            thisThought.AddForce(randomDirection * moveSpeed, ForceMode.VelocityChange);
            time = 0;
        }
        if ((Vector3.Distance(thisThought.position, Vector3.zero) > 32) || (-5 > thisThought.position.y || thisThought.position.y > 10))
        {
            thisThought.AddForce(-thisThought.position.normalized * moveSpeed, ForceMode.VelocityChange);
        }
        thisThought.velocity = new Vector3(Mathf.Clamp(thisThought.velocity.x, -moveSpeed, moveSpeed),
                              Mathf.Clamp(thisThought.velocity.y, -moveSpeed, moveSpeed),
                              Mathf.Clamp(thisThought.velocity.z, -moveSpeed, moveSpeed));
    }
}
