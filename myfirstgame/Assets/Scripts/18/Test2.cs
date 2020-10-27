using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private Rigidbody myrigid;
    private Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        myrigid = GetComponent<Rigidbody>();
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //myrigid.velocity = new Vector3(0, 0, 1); // =Vector3.forward;
            //myrigid.angularVelocity = new Vector3(1, 0, 0);
            //myrigid.mass = 21;
            //myrigid.drag = 21;
            //myrigid.angularDrag = 21;
            //myrigid.maxAngularVelocity = 100;
            //myrigid.angularVelocity = Vector3.right * 100;
            //myrigid.isKinematic = true;
            //myrigid.useGravity = true;
            //myrigid.MovePosition(transform.forward * Time.deltaTime);
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //myrigid.MoveRotation(Quaternion.Euler(rotation)); // Quarternion
            //moveposition & moverotationd 은 물리적 법칙에 상관없이 적용 그러지않으려면 아래와 같이
            //myrigid.AddForce(Vector3.forward); //물리적 법칙 적용
            //myrigid.AddTorque(Vector3.up); // 물리적 법칙 적용 회전
            //myrigid.AddExplosionForce(10,this.transform.right, 10); // 폭발강도, 폭발위치, 폭발반경
            //move는 물리법칙 무시 강제이동 등, add는 물리법칙 적용
        }
    }
}
