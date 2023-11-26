using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    //health of npc
    public int health = 5;
    //level of npc
    public int level = 1;
    //speed of npc
    public float speed = 1.2f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������ ���������� ���� Vector3 � ��������� � �� ������� NPC
        Vector3 newPosition = transform.position;
        //������ �������� NPC �� ��� z �������� �������� NPC � ������� ����� �������
        newPosition.z += speed * Time.deltaTime;
        //������ ������� NPC �� ����� ��������, ������������ �����
        transform.position = newPosition;
    }
}
