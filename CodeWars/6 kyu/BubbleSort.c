#include <stdio.h>

void Swap(int *a, int *b) {
    int temp = *a;
    *a = *b;
    *b = temp;
}


void printArray(int howMany, int data[], char *str) {
    int i;
    printf("%s", str);

    for (int i = 0; i < howMany; ++i) {
        printf("%d\t", data[i]);
    }
}

void BubbleSort(int data[], int howMany) {
    int i, j;
    int goOn;

    for (i = 0; i < howMany; ++i) {
        printArray(howMany, data, "\nInside the bubble\n");
        printf("i = %d , Input Any Int to continue : ", i);
        scanf("%d", &goOn);

        for (j = (howMany - 1); j > i; j--) {
            if (data[j - 1] > data[j])
                Swap(&data[j - 1], &data[j]);
        }
    }
}


int main() {
    const SIZE = 5;
    int grades[5] = {105, 99, 87, 85, 27};

    printArray(SIZE, grades, "\nMy Grades are : \n");
    printf("\n\n");

    BubbleSort(grades, SIZE);

    printArray(SIZE, grades, "\nMy Sorted Grades are : \n");
    printf("\n\n");

    return 0;
}
