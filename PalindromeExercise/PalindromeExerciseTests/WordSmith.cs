﻿using System;

namespace PalindromeExerciseTests
{
    public class WordSmith
    { 

        internal bool IsAPalindrome(string word)
        {
            var reversed = "";
             for(int i = word.Length - 1;i >=0; i--)
            {
                reversed += word[i];
            }
             if(reversed == word)
            {
                return true;
            }
             else
            {
                return false;
            }
        }
    }
}