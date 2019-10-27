using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread05_lock
{
    class NumClass
    {
        public int Number { get; set; }

        // 공유 자원에 대해 스레드 동기화 처리가 되지 않은 함수
        public void IncreaseNum1(object obj)
        {
            NumClass nc = obj as NumClass;
            for (int i = 0; i < 100000; i++)   // 숫자가 커질수록 잘못된 예측할 수 없는 결과가 나옴.
            {
                nc.Number++;
            }

            // 1. 메모리의 힙 영역에서 number 변수에 해당하는 값을 가져온다.
            // 2. 가져온 값에 1을 더한다.
            // 3. 1이 더해진 새로운 값을 메모리의 힙 영역에 저장한다.
        }

        // 공유 자원에 대해 스레드 동기화 처리가 되어 있는 함수
        public void IncreaseNum2(object obj)
        {
            NumClass nc = obj as NumClass;
            for (int i = 0; i < 100000; i++)
            {
                lock (nc)  // 한 순간에 오직 한 개의 스레드만 접근 허용
                {
                    nc.Number++;
                }
            }
        }
    }
}
