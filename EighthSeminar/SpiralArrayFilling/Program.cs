/*
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int countOfRows = 4;
int countOfColumns = 4;

bool horizontally = true; //дижемся мы горизонтально
bool vertical = false; //движемся мы вертикально
bool forward = true; //движемся вперед или назад 
bool down = true; //движемся мы вверх или вниз

int step = 1;
int startIndexForRows = 0;
int startIndexForColumns = 0;

int[,] array = FillArray();
PrintArray(array);

int[,] FillArray()
{
    int rowMoveForwardStep = 0;
    int rowMoveBackStep = countOfRows;
    int columnMoveToptStep = 0;
    int columsMoveDownStep = countOfColumns;

    int[,] array = new int[countOfRows, countOfColumns];
    while (countOfColumns != 0 && countOfRows != 0)
    {
        if (horizontally && forward)
        {
            MoveHorizontallyAndForward(rowMoveForwardStep, columsMoveDownStep, array);
            rowMoveForwardStep++;
            continue;
        }
        if (vertical && down)
        {
            MoveVerticalAndDown(rowMoveBackStep, columsMoveDownStep, array);
            columsMoveDownStep--;
            continue;
        }
        if (horizontally && !forward)
        {
            MoveHorizontallyAndBack(rowMoveBackStep, columsMoveDownStep, array);
            rowMoveBackStep--;
            continue;
        }
        if (vertical && !down)
        {
            MoveVerticalAndTop(rowMoveBackStep, columnMoveToptStep, array);
            columnMoveToptStep++;
            continue;
        }
    }
    return array;
}

void MoveHorizontallyAndForward(int row, int columns, int[,] array)
{
    for (int i = startIndexForRows; i < columns; i++)
    {
        array[row, i] = step;
        step += 1;
    }
    startIndexForColumns++;
    countOfRows--;
    horizontally = false;
    vertical = true;
    forward = false;
}

void MoveVerticalAndDown(int rows, int column, int[,] array)
{
    for (int i = startIndexForColumns; i < rows; i++)
    {
        array[i, column - 1] = step;
        step++;
    }
    countOfColumns--;
    horizontally = true;
    vertical = false;
    down = false;
}

void MoveHorizontallyAndBack(int row, int columns, int[,] array)
{
    for (int i = columns - 1; i >= startIndexForRows; i--)
    {
        array[row - 1, i] = step;
        step++;
    }
    countOfRows--;
    horizontally = false;
    vertical = true;
    forward = true;
}

void MoveVerticalAndTop(int rows, int column, int[,] array)
{
    for (int i = rows - 1; i >= startIndexForColumns; i--)
    {
        array[i, column] = step;
        step++;
    }
    startIndexForRows++;
    countOfColumns--;
    horizontally = true;
    vertical = false;
    down = true;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j].ToString("00") + " ");
        }
        Console.WriteLine();
    }
}