using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // ��]���x

    // Start is called before the first frame update
    void Start()
    {
        // �t���[�����[�g���U�O�ɌŒ肷��
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        // �}�E�X�������ꂽ���]���x��ݒ肷��
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 30;
        }

        // ��]���x�Ԃ�A���[���b�g����]������
        transform.Rotate(0, 0, this.rotSpeed);

        // ���[���b�g������������
        this.rotSpeed *= 0.96f;
    }
}
