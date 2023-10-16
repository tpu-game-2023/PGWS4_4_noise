using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Material mt;
    float count = 0.0f;
    bool a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (!a) count += Time.deltaTime;
            mt.SetFloat("_t", count);
        }
    }
    void Pause(bool b = true) { a = b; }
}
