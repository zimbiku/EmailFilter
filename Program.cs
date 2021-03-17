using System;

namespace EmailFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] emails = {"a+team.1+bob@somewhere.com", "team.1+bob+jill@somewhere.com", "team.2@somewhere.com", "team.2@somew.here.com", "team.3+bob@some.where.com", "team.1+bob+frank+tom@somewhere.com"
            , "team.1+bob@somewhere.com", "team.1+bob@somewhere.com", "team.2+bob@somewhere.com", "2team.1+bob@somewh.ere.com", "teadm.1+bob@somewhere.com", "teasm.1+bb@somewhere.com", "a.a@com", "a.a.a@com", "aaa@com"};

            Solution sol = new Solution();
            Console.WriteLine(sol.NumberofUniqueEmailAddresses(emails));
        }
    }
}
