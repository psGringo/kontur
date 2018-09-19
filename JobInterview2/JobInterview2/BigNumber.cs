using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobInterview2
{
    class BigNumber
    {
        public string Value { get; set; }

        public BigNumber(string str)
        {
            if (str[0] == '-') throw new ArgumentException("Отрицательное число");
            if (!IsDigitsOnly(str)) throw new ArgumentException("В аргументе не только цифры");
            if (str[0] == '0') throw new ArgumentException("Есть ведущие нули");
            if (str == "") throw new ArgumentException("Пустая строка");
            if (str.Contains(",") || str.Contains(".")) throw new ArgumentException("Не целое");
            Value = str;
        }

        public BigNumber(string a, string b)
        {
            int[] A = new int[a.Length];
            int[] B = new int[b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                A[i] = (int)Char.GetNumericValue(a[i]);
            }
            for (int i = 0; i < b.Length; i++)
            {
                B[i] = (int)Char.GetNumericValue(b[i]);
            }
            Value = Sum(A, B);
        }

        public static string Sum(int[] a, int[] b)
        {
            var rList = new List<int>();
            var rest = 0;
            Array.Reverse(a);
            Array.Reverse(b);

            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                var n1 = i < a.Length ? a[i] : 0;
                var n2 = i < b.Length ? b[i] : 0;
                var sum = n1 + n2 + rest;
                rList.Add(sum % 10);
                rest = sum / 10;
            }

            if (rest > 0)
                rList.Add(rest);
            // to array and reverse
            int[] resultArray = rList.ToArray();
            Array.Reverse(resultArray);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < resultArray.Length; i++)
            {
                sb.Append(resultArray[i]);
            }
            return sb.ToString();
        }


        public override string ToString()
        {
            return Value;
        }

        public static BigNumber operator +(BigNumber a, BigNumber b)
        {
            return new BigNumber(a.Value, b.Value);
        }
        //
        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }
            return true;
        }
    }
}
