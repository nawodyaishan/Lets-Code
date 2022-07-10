// Given an array of integers, where all elements but one occur twice, find the unique element.

// Example

// The unique element is .

// Function Description

// Complete the lonelyinteger function in the editor below.

// lonelyinteger has the following parameter(s):

// int a[n]: an array of integers
// Returns

// int: the element that occurs only once
// Input Format

// The first line contains a single integer, , the number of integers in the array.
// The second line contains  space-separated integers that describe the values in a.

#include <stdio.h>
#include <string.h>
#include <math.h>
#include <stdlib.h>

int main() {

	int count;
		    
	scanf("%d\n", &count);
	for (; count > 0; count--) {
		unsigned int num;
		scanf("%u\n", &num);
		printf("%u\n", ~num);
	}
	return 0;
}