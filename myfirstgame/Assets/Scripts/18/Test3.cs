using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    private BoxCollider col;
    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    /* void Update()
     {
         if (Input.GetKeyDown(KeyCode.W))
         {
             //Debug.Log("col bounds" + col.bounds);
             //Debug.Log("col.bounds.extents" + col.bounds.extents);
             //Debug.Log("col bounds extents x" + col.bounds.extents.x);
             //Debug.Log("col size" + col.size);
             //Debug.Log("col center" + col.center);
         }
         if (Input.GetMouseButtonDown(0))//0은 좌 1은 우버튼
         {
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit hitinfo;
             if(col.Raycast(ray, out hitinfo, 100)){
                 this.transform.position = hitinfo.point;
             }
         }
     }*/
    private void OnTriggerEnter(Collider other)
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        other.transform.position = new Vector3(0, 2, 0);
    }
    private void OnTriggerStay(Collider other)
    {
        other.transform.position += new Vector3(0, 0, 0.01f);
    }
    private void OnCollisionEnter(Collision collision)// is triger 여부에 따라 달라짐
    {
        
    }
}

