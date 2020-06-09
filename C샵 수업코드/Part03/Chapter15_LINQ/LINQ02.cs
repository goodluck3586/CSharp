/* 488p 예제 */
namespace LINQ02_SimpleLinq
{
    // Profile 데이터 저장 클래스
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    class Program
    { 
        static void Main(string[] args)
        {
            // 1. 데이터 소스(Profile 객체 배열)
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height = 186 },
                new Profile() { Name = "김태희", Height = 158 },
                new Profile() { Name = "고현정", Height = 172 },
                new Profile() { Name = "이문세", Height = 178 },
                new Profile() { Name = "하동훈", Height = 171 }
            };

            #region 단순 추출 쿼리
            // 2. 쿼리 만들기(키 순서대로 오름차순 정렬된 이름만 가져오는 쿼리)
            var profileList1 = from profile in arrProfile
                               orderby profile.Height
                               select profile.Name;

            // 3. 쿼리 실행(출력)
            foreach (var profile in profileList1)
                Console.WriteLine($"Name : {profile}");
            Console.WriteLine();
            #endregion

            #region 필터, 정렬 사용 쿼리
            // 2. 쿼리 만들기(키가 175 이하인 사람의 profile만을 오름차순으로 정렬하는 쿼리) 
            var profileList2 = from profile in arrProfile
                            where profile.Height < 175
                            orderby profile.Height
                            select profile;

            // 3. 쿼리 실행
            foreach (var profile in profileList2)
                Console.WriteLine($"{profile.Name}, {profile.Height}cm");
            Console.WriteLine();
            #endregion

            #region 무명형식 사용 쿼리
            // 2. 쿼리 만들기(키가 175 이하인 사람의 profile만을 오름차순으로 정렬하는 쿼리)
            // 단, Height(cm)를 InchHeight(inch)로 변환한 무명 형식 생성
            var profileList3 = from profile in arrProfile
                               where profile.Height < 175
                               orderby profile.Height
                               select new { Name = profile.Name, centiHeight=profile.Height, InchHeight = profile.Height * 0.393 };

            // 3. 쿼리 실행
            foreach (var profile in profileList3)
                Console.WriteLine($"{profile.Name}, {profile.centiHeight}cm, {profile.InchHeight:F1}inch");
            #endregion
        }
    }
}