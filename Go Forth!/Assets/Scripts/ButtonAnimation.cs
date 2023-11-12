using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimation : MonoBehaviour
{
    // Variables
    public float scaleSpeed = 1.0f;
    public float maxScale = 1.0f;
    public float minScale = 0.5f;
    private bool scalingDown = true;

    // Update is called once per frame
    void Update()
    {
        if (scalingDown)
        {
            // Scale down from 1.0 to minScale
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(minScale, minScale, 1), scaleSpeed * Time.deltaTime);

            // Check if the scale is close to the target scale
            if (transform.localScale.x <= minScale + 0.1f)
            {
                scalingDown = false;
            }
        }
        else
        {
            // Scale up from minScale to 1.0
            transform.localScale = Vector3.Lerp(transform.localScale, Vector3.one, scaleSpeed * Time.deltaTime);

            // Check if the scale is close to the target scale
            if (transform.localScale.x >= maxScale - 0.1f)
            {
                scalingDown = true;
            }
        }
    }
}
