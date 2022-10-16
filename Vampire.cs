using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Vampire : INPC
    {
        public void Speak()
        {
            Debug.Log("Vampire: You're just my type! ;)");
        }
    }
}
