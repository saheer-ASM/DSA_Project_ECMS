using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project_ECMS
{
    public class CompareString()
    {
        public static bool Campare(string s1, string s2)
        {
            // check if there are any null values
            if (s1 == null && s2 == null) return false; 
            if (s1 == null) return true;  
            if (s2 == null) return false;

            // Determine the shorter length to compare
            int length = Math.Min(s1.Length, s2.Length);

            // Compare character by character
            for (int i = 0; i < length; i++)
            {
                if (s1[i] < s2[i])
                    return true;  
                else if (s1[i] > s2[i])
                   return false;
            }

            
            return true;
        }
    }
    
}
