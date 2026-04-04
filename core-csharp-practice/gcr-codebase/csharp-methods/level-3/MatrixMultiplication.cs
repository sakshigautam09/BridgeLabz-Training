using System;
class MatrixMultiplication
{
    static Random rand = new Random();
    static double[,] Create(int rows, int cols)
    {
        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rand.Next(1, 10);
        return matrix;
    }
    static void Display(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
                Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    static double[,] Add(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] ans = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                ans[i, j] = a[i, j] + b[i, j];

        return ans;
    }

    static double[,] Subtract(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    static double[,] Multiply(double[,] a, double[,] b)
    {
        int rows = a.GetLength(0);
        int cols = b.GetLength(1);
        int common = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                for (int k = 0; k < common; k++)
                    result[i, j] += a[i, k] * b[k, j];
        return result;
    }

    static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transpose = new double[cols, rows];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transpose[j, i] = matrix[i, j];

        return transpose;
    }

    static double Determinant(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    static double Determinant3(double[,] m)
    {
        return m[0,0]*(m[1,1]*m[2,2]-m[1,2]*m[2,1]) - m[0,1]*(m[1,0]*m[2,2]-m[1,2]*m[2,0]) + m[0,2]*(m[1,0]*m[2,1]-m[1,1]*m[2,0]);
    }

    static double[,] Inverse(double[,] m)
    {
        double det = Determinant(m);
        if (det == 0) return null;
        double[,] inv = new double[2, 2];
        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;
        return inv;
    }
    static double[,] Inverse3(double[,] m)
    {
        double det = Determinant3(m);
        if (det == 0) return null;

        double[,] inv = new double[3, 3];

        inv[0,0]=(m[1,1]*m[2,2]-m[1,2]*m[2,1])/det;
        inv[0,1]=(m[0,2]*m[2,1]-m[0,1]*m[2,2])/det;
        inv[0,2]=(m[0,1]*m[1,2]-m[0,2]*m[1,1])/det;

        inv[1,0]=(m[1,2]*m[2,0]-m[1,0]*m[2,2])/det;
        inv[1,1]=(m[0,0]*m[2,2]-m[0,2]*m[2,0])/det;
        inv[1,2]=(m[0,2]*m[1,0]-m[0,0]*m[1,2])/det;

        inv[2,0]=(m[1,0]*m[2,1]-m[1,1]*m[2,0])/det;
        inv[2,1]=(m[0,1]*m[2,0]-m[0,0]*m[2,1])/det;
        inv[2,2]=(m[0,0]*m[1,1]-m[0,1]*m[1,0])/det;

        return inv;
    }
    static void Main()
    {
        double[,] A = Create(3, 3);
        Display(A);
        double[,] B = Create(3, 3);
        Display(B);

        Display(Add(A, B));
        Display(Subtract(A, B));
        Display(Multiply(A, B));
        Display(Transpose(A));
        Console.WriteLine(Determinant3(A));
        double[,] invA = Inverse3(A);
        if (invA != null)
            Display(invA);
        else
            Console.WriteLine("Inverse not possible");
    }
}
