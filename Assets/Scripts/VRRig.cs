using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class VRRig : MonoBehaviour
{
    public GameObject Body;
    public Vector3 BodyOffset;
    public Transform VRBody;
    public Transform VRHead;
    public float rotateSpeed;
    void Start()
    {
       
    }

    
    void LateUpdate()
    {
        Body.transform.position = VRBody.position + BodyOffset;
        Quaternion quat = new Quaternion(0, VRHead.rotation.y, 0, VRHead.rotation.w);
        Body.transform.rotation = Quaternion.Lerp(Body.transform.rotation, quat, rotateSpeed * Time.deltaTime);
    }
}
