using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    public GameObject ground;

    float timer;
    float waiting;

    float xPos;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        waiting = 2.0f;

        xPos = -13;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > waiting)
        {
            GSpawn();
            timer = 0;
        }
    }

    void GSpawn()
    {
        Instantiate(ground, new Vector3(xPos, 0, 0), Quaternion.identity);
        xPos += -13;
    }

    void OSpawn()
    {

    }
}
