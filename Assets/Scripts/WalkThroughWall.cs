using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkThroughWall : MonoBehaviour
{
    void OnEnable(){
        gameObject.layer = LayerMask.NameToLayer("Not Solid");
    }

    void OnDisable(){
        gameObject.layer = LayerMask.NameToLayer("Default");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
