using System;
/*
 * Utility Class, also known as Helper class
 * is a class, which contains just static methods, it is stateless and cannot be instantiated. 
 */ 

namespace Util
{
    public static class TextUtil {
        public static bool isUAlpha(char c)
        {
            return c >= 'A' && c <= 'Z'; 
        }
        public static bool isLAlpha(char c)
        {
            return c >= 'a' && c <= 'z';
        }
        //if we dont care about case 
        public static bool isAlpha (char c)
        {
            return isUAlpha(c) || isLAlpha(c); 
        }
    }
}