using System;
using System.Collections.Generic;
using UnityEngine;

namespace Examples
{
    public class Teach2 : MonoBehaviour
    {
        ShowCls ss = new ShowCls();

        private void Start()
        {
            ss.Show(new MyCat());
            ss.Show(new MyDog());
            
            
            List<int> a = new List<int>(){1,2,3,4};
            List<MyDog> b = new List<MyDog>()
            {
                new MyDog(),new MyDog()
            };
            
            a.Add(1);
            
            b.Add(new MyDog());
            
        }
    }

    public class ShowCls
    {
        // public void Show(MyDog a)
        // {
        //     a.Walk();
        // }
        //
        // public void Show(MyCat b)
        // {
        //     b.Walk();
        // }

        public void Show(IWalk w)
        {
            w.Walk();
        }

        public void Show<Q>(Q t) where Q:IWalk
        {
           t.Walk();
           t.ToString();
        }

        public void Add(int i)
        {
            
        }

        public void Add(MyDog i)
        {
            
        }
        
        public void Add<T>(T a){}
        
        
    }


    public class MyDog:IWalk
    {
        public void Walk()
        {
            Debug.Log("dog  walk");
        }
    }

    public class MyCat:IWalk
    {
        public void Walk()
        {
            Debug.Log("cat  walk");

        }
    }
}