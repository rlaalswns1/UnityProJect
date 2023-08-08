using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour
{
    #region �迭
    //���� �ڷ����� ������� �̷���� ���� ����

    private int[] buffer = new int[3];

    #endregion

    private int count = 0;
    public Transform [] pointBuffer;
    public NavMeshAgent navMeshAgent;

    void Start()
    {
        //�迭�� ��� ù��° ���Ҵ� 0���� �����ϸ�, �迭�� ���ϴ� ���ҿ�
        //���ϴ� ���� ����

        //�迭�� ũ��� ��������
        //�Ǵ� �������� ������ �޸� ������ ����
        for (int i = 0; i < buffer.Length; i++)
        {
            Debug.Log(buffer[1]);
        }

        //InvokeRepeating : Ư���� �ð����� �Լ��� �ݺ������� ȣ���ϴ� �Լ�
        InvokeRepeating(nameof(IncreaseCount), 0, 5);
    }

    public void IncreaseCount()
    {
        count++;
        count = count % pointBuffer.Length;
    }

    void Update()
    {
        navMeshAgent.SetDestination(pointBuffer[count].position);
    }
}
