using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public static class ExtensionMethods
    {
        public static GameObject Tags(this GameObject obj)
        {
             return obj.GetComponent<Tags>();
        }

    public static bool HasTag(this GameObject obj,string tag)
    {
        return obj.GetComponent<Tags>().;
    }
}

