using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Cat : INPC
    {
        public void Speak()
        {
            Debug.Log("Cat: Happy Meowloween! Purrrranormal cativity!");
        }
    }
}