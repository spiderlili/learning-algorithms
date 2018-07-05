// C# Program to find maximum guest 
// at any time in a party
using System;
class MaxIntervalsOverlap{
    static void findMaxGuests(int []arrl, 
                              int []exit, 
                              int n){ 
    // Sort arrival and exit arrays
    Array.Sort(arrl);
    Array.Sort(exit);
 
    // guests_in indicates number of guests at a time
    int guests_in = 1, 
        max_guests = 1, 
        time = arrl[0];
    int i = 1, j = 0;
 
    // Similar to merge in merge sort to process all events in sorted order
    while (i < n && j < n){
        // If next event in sorted 
        // order is arrival, 
        // increment count of guests
        if (arrl[i] <= exit[j]){
            guests_in++;
 
            // Update max_guests if needed
            if (guests_in > max_guests){
                max_guests = guests_in;
                time = arrl[i];
            }
             
            //increment index of arrival array
            i++; 
        }
         
         // If event is exit, decrement 
         // count of guests.
        else{ 
            guests_in--;
            j++;
        }
    }
 
    Console.Write("Maximum Number of Guests = "+
                                    max_guests + 
                            " at time " + time);
    }
 
    // Driver Code
    public static void Main(){
        int []arrl = {1, 2, 10, 5, 5};
        int []exit = {4, 5, 12, 9, 12};
        int n = arrl.Length;
        findMaxGuests(arrl, exit, n);
    }
}
