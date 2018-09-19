using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace JobInterview2
{
    class BigNumber2
    {
        // !!! в hackerrank не смог подключить using System.Numerics;
        // В студии скомпилировалось и работает.       
        BigInteger Value { get; set; } = 0;

        public BigNumber2(string str)
        {
            if (str[0] == '-') throw new ArgumentException("Отрицательное число");
            if ((str[0] == '0') || (str[1] == '1')) throw new ArgumentException("Есть ведущие нули");
            if (str == "") throw new ArgumentException("Пустая строка");
            if (str.Contains(",") || str.Contains(".")) throw new ArgumentException("Не целое");
            if (!IsDigitsOnly(str)) throw new ArgumentException("В аргументе не только цифры");
            Value = BigInteger.Parse(str);
        }
        public BigNumber2()
        {

        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public static BigNumber2 operator +(BigNumber2 a, BigNumber2 b)
        {
            return new BigNumber2() { Value = a.Value + b.Value };
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
