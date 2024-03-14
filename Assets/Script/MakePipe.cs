using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float TimeDiff;

    float timer = 0;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > TimeDiff)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = new Vector3(2.7f, Random.Range(-2.8f, 3.74f), 0);
            timer = 0;
        }
    }
}
