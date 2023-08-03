using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region Ŭ����
    // ����� ���� ������ �������� �Ӽ��� �Լ��� ���ԵǾ�
    // ������, Ŭ������ ���� ��ü�� �����Ͽ� �����ϰ� ����� �� �ִ�
    // ����ü�Դϴ�.
public class Item
{
    // �����ڶ�?
    // Ŭ������ �ν��Ͻ��� �����Ǵ� �������� �ڵ�����
    // ȣ��Ǵ� Ư���� ��� �Լ��Դϴ�.
    public Item()
    {
        Debug.Log("Item�� �����Ǿ����ϴ�.");
    }
}

#endregion

public class Monster : MonoBehaviour
{
    Item item = new Item();

    public GameObject prefab;

    public void Create()
    {
        // prefab : �����ϰ� ���� ���� ������Ʈ
        // new Vector3(0,0,-5) : ���� ������Ʈ�� �������� �� (��ġ)
        // Quaternion.Euler(0,180,0) : ���� ������Ʈ�� �������� �� (ȸ��)

        int x = Random.Range(0, 10); // 0 ~ 9 ������ ������ �� 
        int y = Random.Range(0, 5);  // 0 ~ 4 ������ ������ ��
        int z = Random.Range(-5, 0); // -5 ~ -1 ������ ������ �� 

        Instantiate(prefab, new Vector3(x, y, z), Quaternion.Euler(0, 180, 0));
    }
}
