using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //Vector3 rotation;
    [SerializeField] // inspector창에 강제로 띄우기 private로 선언되어있어도 가능
    private GameObject go_camera;

    void Start()
    {
        //rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime; // 60분의 1
            //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime); // 위와 동일
            //this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;
            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);
            //rotation = rotation + new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.rotation = Quaternion.Euler(rotation); //rotation 함수는 4원수 Euler 메서드로 변환
            //Debug.Log(transform.eulerAngles);
            //this.transform.localScale = this.transform.localScale + new Vector3(2,2,2) * Time.deltaTime;
            //Debug.Log(transform.localScale);
            //moveSpeed * transform.forward * Time.deltaTime; // forward는 right, up 과 더불어 정규화 벡터(방향만을 알려주는 녀석 new Vector3(0,0,1)
            //this.transform.LookAt(go_camera.transform.position); // 오브젝트를 바라보게 하는 메서드
            transform.RotateAround(go_camera.transform.position, Vector3.up, 100 * Time.deltaTime);
        }
    }
}
