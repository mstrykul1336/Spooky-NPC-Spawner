using UnityEngine;
using TMPro;

namespace Pattern.FactoryMethod
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner m_SpawnerNPC;
        public GameObject shopkeepbroom;
        public GameObject drac;
        public GameObject ghost;
        public GameObject cat;
        public GameObject pumpkin;
        public GameObject monster;
        public int tracksecret;
        public GameObject SHOP;
        public GameObject UNLOCK;
        public TextMeshProUGUI secret;
        public GameObject Button;
        public GameObject giphy;

        public void Update()
        {

            if (tracksecret >= 5)
            {
                SHOP.SetActive(false);
                UNLOCK.SetActive(true);
                secret.text = ("Try hitting left control!");
                Button.SetActive(true);
                giphy.SetActive(true); 
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(false);

            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                m_SpawnerNPC.SpawnShopkeeper();
                shopkeepbroom.SetActive(true);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(false);
                tracksecret += 1;
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                m_SpawnerNPC.SpawnGhost();
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(true);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(false);
                tracksecret += 1;
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                m_SpawnerNPC.SpawnFarmer();
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(true);
                monster.SetActive(false);
                tracksecret += 1;
            }

            if (Input.GetKeyDown(KeyCode.V))
            {
                m_SpawnerNPC.SpawnVampire();
                shopkeepbroom.SetActive(false);
                drac.SetActive(true);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(false);
            }

            if (Input.GetKeyDown(KeyCode.C))
            {
                m_SpawnerNPC.SpawnCat();
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(true);
                pumpkin.SetActive(false);
                monster.SetActive(false);
            }
            
            if (Input.GetKeyDown(KeyCode.M))
            {
                m_SpawnerNPC.SpawnMonster();
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(true);
                tracksecret += 1;
            }

            if (Input.GetKeyDown(KeyCode.LeftControl) )
            {
                m_SpawnerNPC.SpawnBeetle();
                shopkeepbroom.SetActive(false);
                drac.SetActive(false);
                ghost.SetActive(false);
                cat.SetActive(false);
                pumpkin.SetActive(false);
                monster.SetActive(false);
            }
        }

        //void OnGUI()
        //{
            //GUI.color = Color.black;
            //GUI.Label(new Rect(10, 10, 200, 20), "Press S to spawn NPCs.");
        //}
    }
}