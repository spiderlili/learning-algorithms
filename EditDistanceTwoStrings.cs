//check if given two strings are at distance one.
//simultaneously traverse both strings and keep track of count of different characters.

using System;
 
class EditDistanceTwoStrings{
// Returns true if edit distance between s1 and s2 is 1, else false
 static bool isEditDistanceOne(String str1,String str2){
     
    // Find lengths of given strings
    int str1Length = str1.Length, str2Length = str2.Length;
 
    // If difference between lengths > 1, then strings can't be at one distance
    if (Math.Abs(str1Length - str2Length) > 1)
        return false;
 
        // Count of edits
        int count = 0;
        int i = 0, j = 0;
         
    while (i < str1Length && j < str2Length){
        // If current characters don't match
        if (str1[i] !== str2[j])
        {
            if (count == 1)
                return false;
 
            // If length of one string is more, then only possible edit is to remove a character
            if (str1Length > str2Length)
                i++;
            else if (str1Length < str2Length)
                j++;
                 
             // If lengths of both strings is the same
            else{
                i++;
                j++;
            }
             
            // Increment count of edits 
            count++;
        }
 
        // If current characters match
        else{
            i++;
            j++;
        }
    }
 
    // If last character is extra in any string
    if (i < str1Length || j < str2Length)
        count++;
 
    return count == 1;
}
 
// Driver code
public static void Main (){
    String str1 = "gfg";
    String str2 = "gf";
    if(isEditDistanceOne(str1, str2))
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No"); 
}
}
