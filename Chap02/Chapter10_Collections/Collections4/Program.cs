using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Hashtable, Dictionary
 * (key, value)의 쌍으로 이루어진 데이터) */
namespace Collections4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Hashtable
            Hashtable ht = new Hashtable()
            {
                [1]="하나",
                [2]= "둘",
                [3]= "셋"
            };

            ht.Add("Name", "아이유");
            ht["Age"] = 26;
            PrintHashtable(ht);

            if (ht.ContainsKey("Name"))
                ht["Name"] = "장만월";
            else
                ht.Add("Name", "장만월");
            PrintHashtable(ht);

            if (ht.ContainsValue("넷"))
                Console.WriteLine("값이 이미 존재합니다.");
            else
                ht.Add(4, "넷");
            PrintHashtable(ht);
            #endregion

            #region Dictionary
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                [1]="하나",
                [2]="둘"
            };
            dic[3] = "셋";
            PrintDictionary(dic);

            if (dic.ContainsKey(1))
                dic[1] = "핫";
            else
                dic.Add(1, "핫");
            PrintDictionary(dic);

            if (dic.ContainsValue("넷"))
                Console.WriteLine("넷 값이 이미 존재합니다.");
            else
                dic.Add(4, "넷");
            PrintDictionary(dic);
            #endregion
        }

        static void PrintHashtable(Hashtable ht)
        {
            foreach (var item in ht.Keys)
            {
                Console.Write($"{ht[item]} ");
            }
            Console.WriteLine('\n');
        }

        static void PrintDictionary(Dictionary<int, string> dic)
        {
            foreach (var item in dic.Keys)
            {
                Console.Write($"{dic[item]} ");
            }
            Console.WriteLine('\n');
        }
    }
}
