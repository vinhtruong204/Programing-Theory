using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Cow : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        point = 20;
    }

    // POLYMORPHISM
    protected override void makeSound()
    {
        Debug.Log("EERRRRRR");
    }


}
