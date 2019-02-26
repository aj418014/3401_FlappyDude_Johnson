using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    public GameObject pipe;
    public float speed = 3.0f;
    public float despawnXPosition = -3;
    
    void Update()
    {
        transform.Translate(new Vector2(-speed* Time.deltaTime, 0));
        if (transform.position.x < despawnXPosition)
            Destroy(pipe);

    }
}
