using UnityEngine;

namespace Tests
{
    public class Main :MonoBehaviour
    {
        private void Start()
        {
            Person tom = new Person();
            tom.Move();
            tom.Eat();
            tom.DoSomething();
        }
    }
}