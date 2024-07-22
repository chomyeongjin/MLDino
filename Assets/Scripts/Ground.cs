using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject player;
    float speed;

    //bool isDelete = false;

    // Start is called before the first frame update
    void Start()
    {
        speed = 4.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);

        if(gameObject.transform.position.x > 25)
        {
            Destroy(gameObject);
        }
    }
}
