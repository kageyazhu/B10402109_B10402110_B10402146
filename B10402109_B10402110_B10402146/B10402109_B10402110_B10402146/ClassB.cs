using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B10402109_B10402110_B10402146
{
    class ClassB  // 傳入一個數字，傳回是否是質數
    {
        public int n { get; set; }
        public int GetNumber()
        {
            int i;
           
            for (i = 2; i <= n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i < n)
                return 1;
            else
                return 0;
        }
    }
}
