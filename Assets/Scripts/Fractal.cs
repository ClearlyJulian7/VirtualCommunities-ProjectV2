using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fractal : MonoBehaviour
{
    public static int count = 0;
    public static int ringer = 0;
    public float timer = 0;

    public Fractal parent;

    [SerializeField]
    float objects = 150;
    [SerializeField]
    int radius = 5;
    [SerializeField]
    GameObject first;

    // Start is called before the first frame update
    void Start()
    {
        if (this.transform.parent != null)
        {
            parent = this.GetComponentInParent<Fractal>();
            // timer = parent.timer - 1.25f;
            timer = parent.timer - 1f;
        }
        name = "Fractal " + count;
        if (ringer > 2)
        {
            ringer = 0;
        }
        count += 1;
        float radians = ((2 * Mathf.PI) / objects * count);
        float vertical = Mathf.Sin(radians);
        float horizontal = Mathf.Cos(radians);

        Vector3 spawnDir = new Vector3(horizontal, 0, vertical);

        Vector3 spawnPos;

        if (ringer == 0)
        {
            spawnPos = Vector3.zero + spawnDir * radius;
        }
        else if (ringer == 1)
        {
            spawnPos = Vector3.zero + spawnDir * (radius + 1);
        }
        else if (ringer == 2)
        {
            spawnPos = Vector3.zero + spawnDir * (radius + 2);
        }
        else
        {
            spawnPos = Vector3.zero + spawnDir * radius;
        }

        ringer += 1;
        if (count < objects)
        {
            Fractal child = Instantiate(this, spawnPos, Quaternion.identity);
            child.transform.SetParent(transform, false);
            child.transform.SetPositionAndRotation(spawnPos, Quaternion.identity);
        }
        else
        {
            return;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (this.name == "Fractal 0")
        {
            this.timer += Time.deltaTime;
            this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, Mathf.Abs(Mathf.Sin(((timer * 72) % 360) * (Mathf.PI / 180))), this.transform.position.z), Quaternion.identity);
        }
        else
        {
            this.timer += Time.deltaTime;
            this.transform.SetPositionAndRotation(new Vector3(this.transform.position.x, Mathf.Abs(Mathf.Sin((float)(((timer) * 72 % 360) * (Mathf.PI / 180)))), this.transform.position.z), Quaternion.identity);
        }
    }
}