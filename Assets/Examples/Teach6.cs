using UnityEngine;

namespace Examples
{
    public class Teach6:MonoBehaviour
    {
        public Teach6()
        {
            
        }
    }

    public class Test
    {
        void TestMono()
        {
            Teach6 t6 = new Teach6();

            GameObject a = new GameObject();

            Teach6 tt = a.AddComponent<Teach6>();
        }
    }
}