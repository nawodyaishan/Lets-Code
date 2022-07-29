int diagonalDifference(int arr_rows, int arr_columns, int **arr)
{
    int l_diagonal_sum = 0, r_diagonal_sum = 0;
    for (int i = 0; i < arr_rows; i++)
    {
        for (int j = 0; j < arr_columns; j++)
        {
            if (i == j)
            {
                l_diagonal_sum += arr[i][j];
            }

            if ((i + j) == (arr_columns - 1))
            {
                r_diagonal_sum += arr[i][j];
            }
        }
    }

    return abs(l_diagonal_sum - r_diagonal_sum);
}