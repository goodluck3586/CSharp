
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* group by into로 데이터 분류하기(494p 예제) */
namespace LINQ04_groupby
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public string Gender { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 데이터 소스
            Profile[] arrProfile =
            {
                new Profile() { Name = "정우성", Height = 186, Gender = "남성" },
                new Profile() { Name = "김태희", Height = 158, Gender = "여성"  },
                new Profile() { Name = "고현정", Height = 172, Gender = "여성"  },
                new Profile() { Name = "이문세", Height = 178, Gender = "남성"  },
                new Profile() { Name = "하동훈", Height = 171, Gender = "남성"  }
            };

            #region 성별로 분류
            // 2. 쿼리 만들기: 성별로 분류된 그룹
            var profileList1 = from profile in arrProfile
                               group profile by profile.Gender;  // group A by B => A를 B에 따라 그룹화
            // 쿼리를 group 절로 종료하면 (Key 멤버, 해당 키로 그룹화된 아이템)이 생성된다.

            // 3. 쿼리 실행(출력)
            PrintLinqList<string>(profileList1);
            #endregion

            #region 키로 분류
            //  2. 쿼리 만들기(이름으로 그룹 분류, 같은 이름이 3명 이상인 그룹만 추출)
            var profileList2 = from profile in arrProfile
                               orderby profile.Height
                               group profile by profile.Height < 175;

            // 3. 쿼리 실행(출력)
            PrintLinqList<bool>(profileList2);
            #endregion

            #region 키로 분류(키 175미만과 175이상 그룹으로 구분)했을 때 3명 이상인 그룹만(그룹 필터링)
            //  2. 쿼리 만들기(이름으로 그룹 분류, 같은 이름이 3명 이상인 그룹만 추출)
            // group A by B into C => A를 B에 따라 분류하여 C에 저장
            var profileList3 = from profile in arrProfile
                               orderby profile.Height
                               group profile by profile.Height < 175 into g
                               where g.Count() >= 3
                               select g;

            // 3. 쿼리 실행(출력)
            PrintLinqList<bool>(profileList3);
            #endregion

            #region 키로 그룹화하고 그룹은 (Name과 inchHeight)로 이루어짐.
            //  2. 쿼리 만들기(이름으로 그룹 분류, 같은 이름이 3명 이상인 그룹만 추출)
            // group A by B into C => A를 B에 따라 분류하여 C에 저장
            var profileList4 = from profile in arrProfile
                               orderby profile.Height
                               group new { Name = profile.Name, inchHeight = profile.Height * 0.393 } by profile.Height < 175;

            // 3. 쿼리 실행(출력)
            foreach (var Group in profileList4)
            {
                Console.WriteLine($"그룹명: {Group.Key}");
                foreach (var item in Group)
                {
                    Console.WriteLine($" {item.Name}, {item.inchHeight:F1}inch");
                }
                Console.WriteLine();
            }
            #endregion
        }

        // LINQ 쿼리 출력 메소드(이름, 키)
        static void PrintLinqList<T>(IEnumerable<IGrouping<T, Profile>> list)
        {
            foreach (var Group in list)
            {
                Console.WriteLine($"그룹명: {Group.Key}");
                foreach (var item in Group)
                {
                    Console.WriteLine($" {item.Name}, {item.Height}");
                }
                Console.WriteLine();
            }
        }
    }
}

// 대륙에 속한 나라의 개수가 50개 이상인 대륙의 이름과 나라의 숫자를 출력
// select continent, count(*) from country group by continent having count(*)>50;

// 인구 수가 10억명 이상인 대륙의 이름과 인구 수 합계를 출력하시오.
// select continent, sum(population) from country group by continent having sum(population)>1000000000;
