using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//��� ������ ������������, ������� ����� ��������������. 
//��������� ��������: ����� �����, ������� ��������, �������, �������? � ����� ������� ���� �������
[System.Serializable]
public class UserInfo
{
    public int CurrentAge;  //������� �������
    public int MaxAge;      // ������������ ������� � ����������� �� ����
    public int Result;      // ������� ��������
    public int ResultMax;   // �� ������� �������
    public string Sex;      // ���
}

public class UserData : MonoBehaviour
{
    public UserInfo userInfo;
    public static UserData Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            transform.parent = null;
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
