using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    [System.Serializable]
    public class MyData
    {
        public int publicVarible;
        [SerializeField]
        private string privateVariable;
    }


    [SerializeField]
    private MyData[] myArray;
}
