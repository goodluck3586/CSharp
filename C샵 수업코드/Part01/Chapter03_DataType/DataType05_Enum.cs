class Program
    {
        // 열거형(같은 범주에 속하는 여러 개의 상수 선언), 0부터 순차적으로 값이 부여되나 명시적으로 설정 가능
        enum Day { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        enum GenderType { 남자, 여자 };

        static void Main(string[] args)
        {
            GenderType gender = GenderType.남자;
            int genderNum = 1;
            Console.WriteLine($"성별 : {gender}, enum값: {(int)gender}, {(GenderType)genderNum}");

            /********** 열거형(enum) : 명명된 상수 집합 **********/
            // 열거형은 기본 형식이 모든 정수 계열 형식이 명명 된 상수의 집합
            Day today = Day.Mon;
            Console.WriteLine("today: {0}, {1}", today, (int)today);
            Console.WriteLine("{0}, {0:d}", Day.Sun);
            Console.WriteLine("{0}, {0:d}", Day.Mon);
            Console.WriteLine("{0}, {0:d}", Day.Tue);
            Console.WriteLine($"Day.Mon.GetType() : {Day.Mon.GetType()}");

            Console.WriteLine("숫자를 입력하세요");
            int yoil = int.Parse(Console.ReadLine());
            WhatDayUsingNumber(yoil);
        }

        static void WhatDayUsingNumber(int i)
        {
            Console.WriteLine((Day)i);
            Day day = (Day)i;
            day = Day.Sun;

            switch (day)
            {
                case Day.Sun:
                    Console.WriteLine(Day.Sun);
                    break;
            }
        }
    }