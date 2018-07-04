//find whether an array is subset of another array
//1) Sort both arrays: arr1[] and arr2[] O(mLogm + nLogn)
//2) Use Merge type of process to see if all elements of sorted arr2[] are present in sorted arr1[].
     
using System;

class SubsetArray {
     
    // Return true if arr2[] is 
    // a subset of arr1[] */
    static bool isSubset(int []arr1, 
                         int []arr2, 
                         int m,
                         int n)
    {
        int i = 0, j = 0;
             
        if(m < n)
            return false;
         
        //sorts arr1
        Array.Sort(arr1); 
         
        // sorts arr2
        Array.Sort(arr2); 
 
        while( i < n && j < m )
        {
            if( arr1[j] < arr2[i] )
                j++;
            else if( arr1[j] == arr2[i] )
            {
                j++;
                i++;
            }
            else if( arr1[j] > arr2[i] )
                return false;
        }
         
        if( i < n )
            return false;
        else
            return true;
    } 
         
    // Driver Code
    public static void Main() 
    { 
        int []arr1 = {11, 1, 13, 21, 3, 7};
        int []arr2 = {11, 3, 7, 1};
         
        int m = arr1.Length;
        int n = arr2.Length;
         
        if(isSubset(arr1, arr2, m, n))
            Console.Write("arr2 is a subset of arr1");
        else
            Console.Write("arr2 is not a subset of arr1");
    }
}
