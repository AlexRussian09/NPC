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
        //создаём переменную вида Vector3 и сщхраняем в неё позицию NPC
        Vector3 newPosition = transform.position;
        //меняем поззицию NPC по оси z согласно скорости NPC и времени между кадрами
        newPosition.z += speed * Time.deltaTime;
        //меняем позицию NPC на новое значение, рассчитанное между
        transform.position = newPosition;
    }
}
