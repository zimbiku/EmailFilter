
using System;
using System.Collections;

namespace EmailFilter
{
    public class Solution
    {
        public int NumberofUniqueEmailAddresses(string[] emails)
        {
            //THIS CODE ASSUMES ALL EMAIL ADDRESSES ARE VALID AS I DID NOT CHECK THAT THERE IS A VALID LOCAL PART AND A DOMAIN PART
            //I ASSUME THERE IS ATLEAST 1 VALID LOCAL CHARACTER AND AN @ FOLLOWED BY CHARACTERS.
            Stack myStack = new Stack();

            for (int x = 0; x<emails.Length; x++)
            {
                //Console.WriteLine(emails[x]);
                //remove the + and remaiining chars
                if (emails[x].Contains('+')){
                    int a = emails[x].IndexOf('@');
                    int b = emails[x].IndexOf('+');

                    //          anything before a +         @xxxxx.com
                    emails[x] = emails[x].Substring(0, b) + emails[x].Substring(a); 
                }

                //remove the .
                string[] sub = emails[x].Split('@');
                sub[0] = sub[0].Replace(".", "");
                emails[x] = sub[0] + "@" + sub[1];

                //Console.WriteLine(emails[x]);

                if (!myStack.Contains(emails[x])){
                    myStack.Push(emails[x].ToString()) ;
                }
            }
            return myStack.Count;
        }
    }
}