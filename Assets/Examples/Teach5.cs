namespace Examples
{
    public class Student
    {
        public string name;
        public int level;
        public int score;
        /// <summary>
        /// 构造方法  Constructor
        /// </summary>
        public Student()
        {
            
        }
        public Student(string n)
        {
            name = n;
        }
        //
        public Student(int level, string n)
        {
            name = n;
            this.level = level;
        }
    }
    public class Teach5
    {
        void Test()
        {
            // 实例化  instance  副本  instantiate
            Student a = new Student();
            a.name = "a";
            a.level = 3;

            Student b = new Student("b");
            
            
        }
    }
}