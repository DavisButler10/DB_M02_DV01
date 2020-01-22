using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client1 : MonoBehaviour
{
    public NPCSpawner m_SpawnerNPC;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            m_SpawnerNPC.SpawnVillagers();
        }
    }
}
