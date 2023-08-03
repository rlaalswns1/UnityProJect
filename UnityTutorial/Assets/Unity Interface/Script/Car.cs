using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    #region ����
    // �����͸� ������ �� �ִ� �޸� ������
    // �����ϴ� ���Դϴ�.

    // �ڷ����̶�?
    // �����͸� �����ϱ� ���� �������� ���¸�
    // �����ִ� ���Դϴ�.

    // �ڷ���      ũ��        ����
    // bool   ->  1 byte '��','����'�� ������ �� �ִ� �ڷ���
    // char   ->  1 byte �ϳ��� ���ڸ� �����ϴ� �ڷ���
    // short  ->  2 byte ������ �����ϴ� �ڷ���
    // int    ->  4 byte ������ �����ϴ� �ڷ���
    // long   ->  4 byte ������ �����ϴ� �ڷ���
    // float  ->  4 byte �Ǽ��� �����ϴ� �ڷ���
    // double ->  8 byte �Ǽ��� �����ϴ� �ڷ���

    // ������ �޸� ������ ���α׷��� ����� ������ �ٲ��,
    // ���� ���� ������ ���� �� ���� ������ �޸� ������ �����ϴ�.
    char character = 'A';

    public int integer = 100; 

    private float pi = 3.141592f;

    // ���� �����ڸ� �������� ������ private�̶�� ����
    // �����ڷ� ����˴ϴ�.
    string name = "Sonata";

    // ������ �̸� ��Ģ
    /*
    // 1. ������ �̸����� ���� ����� �� �����ϴ�.
    // ex) int int = 10;

    // 2. ������ �̸��� ���ڷ� ������ �� �����ϴ�.
    // ex) int 1value = 20;

    // 3. ������ �̸��� ��ҹ��ڸ� �����մϴ�.
    // ex) int data = 30;
    // ex) int DATA = 40;

    // 4. ������ �̸����� ������ ���Ե� �� �����ϴ�.
    // ex) int count down = 50;

    // 5. ������ �̸����� Ư�� ���ڸ� _�� ���˴ϴ�.
    // ex) int count_Down = 10;
    */

    private void Start()
    {
        // ������ ���α׷��� ����Ǵ� ���� ���� �ٲ� �� ������,
        // ���� ����Ǿ� �ִ� ���� ���� ����Ǵ� ���� ���� �������ϴ�.
        character = 'B';
        pi = 6.675f;
        name = "Avante";

        Debug.Log("character ������ �� : " + character);
        Debug.Log("integer ������ �� : " + integer);
        Debug.Log("pi ������ �� : " + pi);
        Debug.Log("name ������ �� : " + name);
    }


    #endregion

    #region �Լ�
    // �ϳ��� Ư���� ������ �۾��� �����ϱ�
    // ���� �������� ����� �ڵ��� �����Դϴ�.

    private void Stop()
    {
        Debug.Log("����");
    }

    private void Update()
    {
        // ���ǹ��̶�?
        // � ������ �־��� �� �ش� ���ǿ� ����
        // ������ �����ϵ��� �����ϴ� ��ɹ��Դϴ�.

        // if���̶�?
        // � Ư���� ������ ���Ͽ� ������ �´ٸ�
        // ����Ǵ� ��ɹ��Դϴ�.

        // GetKeyDown : KEY�� ������ ��
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
        else if(Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("�ڵ� ����");
        }
        else
        {
            Debug.Log("�õ� ����");
        }

        // else if �� 
        // if���� ������ Ʋ�� �� else if���� ������ �´ٸ�
        // ����Ǵ� ��ɹ��Դϴ�.

        // else 
        // if ���� else if ���� ������ �� Ʋ���� ����Ǵ�
        // ��ɹ��Դϴ�.
    }
    #endregion

}
