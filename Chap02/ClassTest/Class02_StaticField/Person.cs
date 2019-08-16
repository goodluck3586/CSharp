using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_StaticField
{
    class Person
    {
        // 인스턴스  필드
        public int CountOfInstance;
        public string name;

        // 정적 필드
        static public int CountOfInstanceStatic;
        
        public Person(string name)
        {
            this.name = name;

            CountOfInstance++;
            CountOfInstanceStatic++;
        }
    }
}
