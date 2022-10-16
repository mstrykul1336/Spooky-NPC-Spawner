using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCFactory : MonoBehaviour
    {
        public INPC GetNPC(NPCType type)
        {
            switch (type)
            {
                case NPCType.Ghost:
                    INPC Ghost = new Ghost();
                    return Ghost;
                case NPCType.Farmer:
                    INPC farmer = new Farmer();
                    return farmer;
                case NPCType.Shopowner:
                    INPC shopowner = new Shopowner();
                    return shopowner;
                case NPCType.Vampire:
                    INPC Vampire = new Vampire();
                    return Vampire;
                case NPCType.Cat:
                    INPC Cat = new Cat();
                    return Cat;
                case NPCType.Monster:
                    INPC Monster = new Monster();
                    return Monster;
                case NPCType.Beetle:
                    INPC Beetle = new Beetle();
                    return Beetle;
            }
          return null;
        }
    }
}