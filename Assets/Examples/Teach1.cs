using System;
using UnityEngine;

namespace Examples
{
    public class Teach1 : MonoBehaviour
    {
        private void Start()
        {
            // Animal animal = new Animal();
            // animal.Eat();
            // animal.Walk();
            //
            // IEat a = new Animal();
            // a.Eat();
            // // a.Walk();
            //
            // IWalk b = new Animal();
            // // b.Eat();
            // b.Walk();

            IWalk c = new Cat();
            c.Walk();

            Dog e = c as Dog;
            if (e == null)
            {
                Debug.LogError("---> 猫不是狗");
            }
            else
            {
                e.Walk();

            }
            
            Cat d = new Cat();
            d.Walk();
        }
    }


    public interface IWalk
    {
        void Walk();
    }

    public interface IEat
    {
        void Eat();
    }

    public class Cat : Animal
    {
        public string catname = "cat";
        public override void Walk()
        {
            bool xiangjianfei = true;
            if (xiangjianfei)
            {
                base.Walk();
            }else
                Debug.Log(catname + "   walk");
        }
    }

    public class Dog
    {
        public void Walk()
        {
            
        }
    }

    public class Animal : IWalk, IEat
    {
        public string name = "animal";

        public virtual void Walk()
        {
            Debug.Log(name + "   walk");
        }

        public void Eat()
        {
            Debug.Log(name + "   eat");
        }
    }
}