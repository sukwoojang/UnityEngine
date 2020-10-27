using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physicstest : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private GameObject go_BulletPretab;
    private float createTime = 1f;
    private float currentCreateTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentCreateTime += Time.deltaTime;
        if(currentCreateTime >= createTime)
        {
            currentCreateTime = 0;
            RaycastHit hitinfo;

            if (Physics.Raycast(this.transform.position, this.transform.forward, out hitinfo, 10f, layerMask))
            {
                if (hitinfo.transform.tag == "Player")
                {
                    Instantiate(go_BulletPretab, transform.position, Quaternion.LookRotation(hitinfo.transform.position - transform.position));
                }
            }
        
            Debug.Log(hitinfo.transform.name);
        }
    }
}
