using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{

    // OnCollisionEnter : �浹�� ���� �� ȣ��Ǵ� �Լ�
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹...");
    }

    // OnCollisionEnter : �浹 ���� �� ȣ��Ǵ� �Լ�
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ��...");
    }

    // OnCollisionExit : �浹�� ����� �� ȣ��Ǵ� �Լ�
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹 ����");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹 ��...");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹 ����...");
        }
    }
}
