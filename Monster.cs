using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Monster : INPC
    {
        public void Speak()
        {
            Debug.Log("Monster: Who won the prize for best dancer at the monster's disco? The boogieman!");
        }
    }
}