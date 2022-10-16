using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Pattern.FactoryMethod
{
    public class Ghost : INPC
    {
        public void Speak()
        {
            Debug.Log("Ghost: Where do ghosts buy their halloween candy? At the ghost-ery store!");
        }
    }
}