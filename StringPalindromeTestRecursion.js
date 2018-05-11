// Returns the first character of the string str
var firstCharacter = function(str) {
    return str.slice(0, 1);
};

// Returns the last character of a string str
var lastCharacter = function(str) {
    return str.slice(-1);
};

// Returns the string that results from removing the first
//  and last characters from str
var middleCharacters = function(str) {
    return str.slice(1, -1);
};

var isPalindrome = function(str) {
    // base case #1: the string is a palindrome if the length of the string is 0 or 1. 
    if(str.length <= 1){
        return true;
    }
    // base case #2: if the first and last characters of the string are different, then the string is not a palindrome. 
    if(firstCharacter(str) !== lastCharacter(str)){
        return false;
    }
    // recursive case
    return isPalindrome(middleCharacters(str));
};

var checkPalindrome = function(str) {
    println("Is this word a palindrome? " + str);
    println(isPalindrome(str));
};

checkPalindrome("a");
Program.assertEqual(isPalindrome("a"), true);
checkPalindrome("motor");
Program.assertEqual(isPalindrome("motor"), false);
checkPalindrome("rotor");
Program.assertEqual(isPalindrome("rotor"), true);
checkPalindrome("abba");
Program.assertEqual(isPalindrome("abba"), true);
checkPalindrome("tacocat");
Program.assertEqual(isPalindrome("tacocat"), true);
