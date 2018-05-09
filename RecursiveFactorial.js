//if n = 0: declare that n! = 1
//otherwise: 
//1. solve the subproblem of computing the recursive case (n-1)!, 
//2. multiply this result by n, 
//3. declare the base case n! = to this result

var factorial = function(n) {
	// base case: 
	var result = 1;
	if(n === 0){
	    return 1;
	}
	// recursive case:
	result = n * factorial(n-1);
	return result;
}; 

println("The value of 0! is " + factorial(0) + ".");
println("The value of 5! is " + factorial(5) + ".");

Program.assertEqual(factorial(0), 1);
Program.assertEqual(factorial(5), 120);
