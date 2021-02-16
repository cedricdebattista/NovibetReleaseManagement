using System;
using System.Collections.Generic;
using System.Text;

namespace TestApplication
{
    public class TestService
    {
        public string DoSomething(string s, string y)
        {
            try
            {
                return string.Join(',', s, y);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            
        }
        public string DoSomething2(int i, int y)
        {
            try
            {
                var sum = (i + y);

                return sum.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
    }
}
