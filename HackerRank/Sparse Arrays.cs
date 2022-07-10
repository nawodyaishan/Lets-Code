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

    for (int i = 0; i < queries.Count; i++)
    {
        int count = 0;
        string queryTemp = queries[i];

        for (int j = 0; j < strings.Count; j++)
        {
            string stringTemp = strings[j];

            if (queryTemp == stringTemp)
            {
                count++;
            }
        }
        result.Add(count);
    }
    return result;
}
