using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;

        private INPC m_Farmer;
        private INPC m_Ghost;
        private INPC m_Shopowner;
        private INPC m_Vampire;
        private INPC m_Cat;
        private INPC m_Monster;
        private INPC m_Beetle;

        public void SpawnShopkeeper()
        {
            /** 
            We don't want to specify the class to instiate for each type of villager.
            Instead, we ask the factory to "manufacture" it for us.
            **/

            //m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            //m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);

            //m_Beggar.Speak();
            //m_Farmer.Speak();
            m_Shopowner.Speak();
        }

        public void SpawnFarmer(){

            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Farmer.Speak();
        }

        public void SpawnGhost(){

            m_Ghost = m_Factory.GetNPC(NPCType.Ghost);
            m_Ghost.Speak();
        }

        public void SpawnVampire(){

            m_Vampire = m_Factory.GetNPC(NPCType.Vampire);
            m_Vampire.Speak();
        }

        
        public void SpawnCat(){

            m_Cat = m_Factory.GetNPC(NPCType.Cat);
            m_Cat.Speak();
        }

        public void SpawnMonster(){

            m_Monster = m_Factory.GetNPC(NPCType.Monster);
            m_Monster.Speak();
        }

        public void SpawnBeetle(){

            m_Beetle = m_Factory.GetNPC(NPCType.Beetle);
            m_Beetle.Speak();
        }
    }
}