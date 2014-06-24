using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class Matrix<T>
        where T: IComparable,IFormattable,IConvertible,IEquatable<T>
    {
        private T[,] matrix;
       
        //constructors
        public Matrix(int rows, int cols)
        {
            if (rows < 0 || cols < 0)
            {
                throw new ArgumentOutOfRangeException("Matrix cannot have negative dimensions!");
            }
            this.matrix = new T[rows, cols];
        }
        public T this[int row, int col]
        {
            get 
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException();
                }
                return this.matrix[row, col];
            }
            set
            {
                if (row < 0 || row >= this.matrix.GetLength(0) || col < 0 || col >= this.matrix.GetLength(1))
                {
                    throw new IndexOutOfRangeException();
                }
                this.matrix[row, col] = value;
            }
        }
        //properties
        public int GetRows
        {
            get { return this.matrix.GetLength(0); }
        }
        public int GetCols
        {
            get { return this.matrix.GetLength(1); }
        }
        //overload operators
        public static Matrix<T> operator +(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (!(firstMatrix.GetRows == secondMatrix.GetRows && firstMatrix.GetCols == secondMatrix.GetCols))
            {
                throw new ArgumentException("The matrices are not equal!");
            }
            Matrix<T> sumMatrix = new Matrix<T>(firstMatrix.GetRows,firstMatrix.GetCols);
            for (int r = 0; r < sumMatrix.GetRows; r++)
            {
                for (int c = 0; c < sumMatrix.GetCols; c++)
                {
                    checked
                    {
                        sumMatrix[r, c] = (dynamic)firstMatrix[r, c] + secondMatrix[r, c]; 
                    }
                }
            }
            return sumMatrix;
        }
        public static Matrix<T> operator -(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (!(firstMatrix.GetRows == secondMatrix.GetRows && firstMatrix.GetCols == secondMatrix.GetCols))
            {
                throw new ArgumentException("The matrices are not equal!");
            }
            Matrix<T> subtractMatrix = new Matrix<T>(firstMatrix.GetRows, firstMatrix.GetCols);
            for (int r = 0; r < subtractMatrix.GetRows; r++)
            {
                for (int c = 0; c < subtractMatrix.GetCols; c++)
                {
                    subtractMatrix[r, c] = (dynamic)firstMatrix[r, c] - secondMatrix[r, c];
                }
            }
            return subtractMatrix;
        }
        public static Matrix<T> operator *(Matrix<T> firstMatrix, Matrix<T> secondMatrix)
        {
            if (!(firstMatrix.GetRows == secondMatrix.GetRows && firstMatrix.GetCols == secondMatrix.GetCols))
            {
                throw new ArgumentException("The matrices are not equal!");
            }

            Matrix<T> multiply = new Matrix<T>(firstMatrix.GetRows, firstMatrix.GetCols);
            for (int r = 0; r < firstMatrix.GetRows; r++)
            {
                for (int c = 0; c < firstMatrix.GetCols; c++)
                {
                    for (int i = 0; i < firstMatrix.GetCols; i++)
                    {
                        multiply[r, c] += (dynamic)firstMatrix[r, i] * secondMatrix[i, c];
                    }
                }
            }
            return multiply;
        }
    }
}
