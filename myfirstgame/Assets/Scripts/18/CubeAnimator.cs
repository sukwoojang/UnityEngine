using System.Collections;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using UnityEngine;

public class CubeAnimator : MonoBehaviour
{
    private Animator anim;

    [SerializeField]
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirx = Input.GetAxisRaw("Horizontal");
        float dirz = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(dirx, 0, dirz);

        anim.SetBool("Right", false);
        anim.SetBool("Up", false);
        anim.SetBool("Down", false);
        anim.SetBool("Left", false);

        if (direction != Vector3.zero)
        {
            this.transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);

            if(direction.x > 0)
            {
                anim.SetBool("Right", true);
            }
            else if(direction.x < 0)
            {
                anim.SetBool("Left", true);
            }
            else if(direction.z > 0)
            {
                anim.SetBool("Up", true);
            }
            else if(direction.z < 0)
            {
                anim.SetBool("Down", true);
            }
        }
    }
}
