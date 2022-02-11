using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArchCoiorChanger : MonoBehaviour
{
    private Color[] colors;
    private float timer = 0;
    private int currentColor = 0;
    public Material material;

    // Start is called before the first frame update
    void Start()
    {
        // material = this.GetComponent<Renderer>().material;
        if (this.name.Equals("stripe1"))
        {
            Debug.Log("this is stripe1");
            colors = new Color[] { new Color(216f / 255f, 9f / 255f, 126f / 255f), new Color(40f / 255f, 56f / 255f, 207f / 255f), new Color(255f / 255f, 244f / 255f, 48f / 255f) };
        }
        if (this.name.Equals("stripe2"))
        {
            Debug.Log("this is stripe2");
            colors = new Color[] { new Color(140f / 255f, 87f / 255f, 156f / 255f), new Color(228f / 255f, 30f / 255f, 30f / 255f), new Color(255f / 255f, 255f / 255f, 255f / 255f) };
        }
        if (this.name.Equals("stripe3"))
        {
            Debug.Log("this is stripe3");
            colors = new Color[] { new Color(140f / 255f, 87f / 255f, 156f / 255f), new Color(0f / 255f, 0f / 255f, 0f / 255f), new Color(156f / 255f, 89f / 255f, 209f / 255f) };
        }
        if (this.name.Equals("stripe4"))
        {
            Debug.Log("this is stripe4");
            colors = new Color[] { new Color(36f / 255f, 70f / 255f, 142f / 255f), new Color(255f / 255f, 255f / 255f, 0f / 255f), new Color(0f / 255f, 0f / 255f, 0f / 255f) };
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 3)
        {
            Debug.Log("changingColor: " + this.name);
            currentColor += 1;
            if (currentColor > colors.Length - 1)
            {
                currentColor = 0;
            }
            material.SetColor("_BaseColor", colors[currentColor]);
            timer = 0;
        }
    }
}
