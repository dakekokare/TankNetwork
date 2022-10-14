using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Deform;

public class RippleStage : MonoBehaviour
{
    //�ό`
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
        //���t���[�����b�V���R���C�_�[��t���͂�������
        Destroy(GetComponent<MeshCollider>());
        gameObject.AddComponent<MeshCollider>();


        //now = Mathf.Repeat(now + Time.deltaTime * 360f, 360f);

        //�ό`
        now += Time.deltaTime;
        ripple.Frequency = now;
    }
}
