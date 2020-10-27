using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_anim : MonoBehaviour
{
    private Animation anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            //anim.Play("Cube2");
            //anim.PlayQueued("Cube2");
            anim.Blend("Cube2");
            //anim.CrossFade("Cube2");
            /*if (!anim.IsPlaying("Cube2"))
            {
                anim.Play("Cube2");
            }*/
            //anim.Stop();
            //anim.wrapMode = WrapMode.Loop; 


        }
    }
}
