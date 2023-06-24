using UnityEngine;

namespace Generics.Scripts
{
    public class Result : MonoBehaviour
    {
        public void Start()
        {
            Soldier<int> John = new Soldier<int>(1, "John", 10);
            Soldier<int> Bob = new Soldier<int>(1, "Bob", 10);
            Officer<string> Bryan = new Officer<string>("23", "Bryan");
            Army<Soldier<int>> Marines = new Army<Soldier<int>>(John);
            Army<Officer<string>> IT = new Army<Officer<string>>(Bryan);
            
            Debug.Log("John: " + John.Name);
            Debug.Log("Bob: " + Bob.Name);
            
            
            IT.Swap(ref John, ref Bob);
            
            
            Debug.Log("John: " + John.Name);
            Debug.Log("Bob: " + Bob.Name);

            Debug.Log(Marines.Military.Name);
            Debug.Log(IT.Military.Name);
        }
    }
}