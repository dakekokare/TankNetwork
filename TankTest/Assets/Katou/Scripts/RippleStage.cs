using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Deform;

public class RippleStage : MonoBehaviour
{
    //変形
    private RippleDeformer ripple;
    private float now = 0;
    // Start is called before the first frame update
    void Start()
    {
        ripple = GetComponent<RippleDeformer>();
    }

    // Update is called once per frame
    void Update()
    {
        //毎フレームメッシュコライダーを付けはずしする
        Destroy(GetComponent<MeshCollider>());
        gameObject.AddComponent<MeshCollider>();


        //now = Mathf.Repeat(now + Time.deltaTime * 360f, 360f);

        //変形
        now += Time.deltaTime;
        ripple.Frequency = now;
    }
}
