using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using SuntabuAndMoontabu;

namespace SuntabuAndMoontabu
{
    public class BaseElement
    {
    }

    /// <summary>
    /// 类
    /// </summary>
    public class Teach4 : BaseElement
    {
        /// <summary>
        /// 字段 Field    类内变量  作用域
        /// 
        /// </summary>
        public string str1 = "";// float int 

        /// <summary>
        /// 初始化   initialize
        /// </summary>
        public int num2 = 1;

        /// <summary>
        /// 数组 array
        /// </summary>
        public int[] myarray = { 1,3,4,5,2};

        /// <summary>
        /// 列表  list
        /// </summary>
        public List<int> mylist = new List<int>() {1, 3, 5, 3};
        
        
        

        /// <summary>
        /// 方法 Method
        /// </summary>
        public void Met()
        {
            /// 方法内变量
            int num1 = 0;
            
            Debug.Log(myarray[1]);
            Debug.Log(mylist[0]);

            List<int> a = myarray.ToList();
            int[] b = mylist.ToArray();
        }

        /// <summary>
        /// 属性 Property
        /// </summary>
        public string str2
        {
            get;
            set;
        }

        public string str2_get()
        {
            return "";
        }

        public void str2_set()
        {
            
        }
    }
}