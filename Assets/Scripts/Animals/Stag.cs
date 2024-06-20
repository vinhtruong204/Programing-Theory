using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Stag : Animal
{

    // Start is called before the first frame update
    void Start()
    {
        point = 30;
    }

    // POLYMORPHISM
    protected override void makeSound()
    {
        Debug.Log("Deer");
    }
}
