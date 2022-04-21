

// Create function fib that returns n'th element of Fibonacci sequence (classic programming task).



public class Fibonacci
{
    public static int Fib(int n)
    {
        if (n <= 1)
        {
            return n;
        }

        int previousFib = 0, currentFib = 1;
        for (int i = 0; i < n - 1; i++)
        {
            int newFib = previousFib + currentFib;
            previousFib = currentFib;
            currentFib = newFib;
        }

        return currentFib;
    }
}