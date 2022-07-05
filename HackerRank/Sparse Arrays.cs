// There is a collection of input strings and a collection of query strings. For each query string, determine how many times it occurs in the list of input strings. Return an array of the results.

// Example



// There are  instances of ',  of '' and  of ''. For each query, add an element to the return array, .

// Function Description

// Complete the function matchingStrings in the editor below. The function must return an array of integers representing the frequency of occurrence of each query string in strings.

// matchingStrings has the following parameters:

// string strings[n] - an array of strings to search
// string queries[q] - an array of query strings
// Returns

// int[q]: an array of results for each query


public static List<int> matchingStrings(List<string> strings, List<string> queries)
{
    
    List<int> result = new List<int>();

    foreach (var query in queries)
    {
        int index = 0;

        foreach (var str in strings)
        {
            if (str == query)
            {
                result[index];
            }
        index++;
        }
    }
    return result;
}
