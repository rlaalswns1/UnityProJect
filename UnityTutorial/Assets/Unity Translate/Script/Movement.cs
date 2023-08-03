using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1.0f;

    void Start()
    {
        
    }

    void Update()
    {
        #region �̵� ����
        // v = v0 + vt

        // transform.position : �ڽ��� ��ġ
        // Vector3.forward = new Vector(0,0,1); 

        // Time.deltaTime : �������� �Ϸ�Ǳ���� �ɸ��� �ð��Դϴ�.
        // transform.position += Vector3.forward * speed * Time.deltaTime;
        #endregion

        // Input.GetAxis( ) : �Ű����� Horizontal�� �־��ָ� 
        // x ��ǥ�� ���� ���� -1 ~ 1 ������ ���� ��ȯ�ϴ� �Լ��Դϴ�.
        // A, D, ��, ��
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        // ������ ����ȭ
        direction.Normalize();

        transform.Translate(direction * speed * Time.deltaTime);
    }
}
