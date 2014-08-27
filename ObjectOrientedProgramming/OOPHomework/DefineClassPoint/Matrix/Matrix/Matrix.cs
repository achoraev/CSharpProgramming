namespace Matrix
{
    using System;
    using System.Text;

    public class Matrix <T> // 8. Define Matrix
        where T: struct, IConvertible, IComparable, IComparable<T>
    {
        //fields
        private T[,] matrix;
        private int rows;
        private int cols;
        // construktor
        public Matrix(int rows, int cols)
        { 
            T type = default(T);
            if (!((type is int) || (type is double) || (type is decimal) || (type is float)))
            {
                throw new ApplicationException("Number must be of type int, float or decimal!!!");
            }
            else
            {
                this.rows = rows;
                this.cols = cols;
                this.matrix = new T[rows, cols];
            }
        }
        // indexer 9.Implement indexer
        public T this[int row, int col]
        {
            get
            {
                if ((row < 0) || (row >= this.rows) || (col < 0) || (col >= this.cols))
                {
                    throw new IndexOutOfRangeException("Index out of range!!!");                    
                }
                else
                {
                    return this.matrix[row, col];
                }
            }
            set
            {
                if ((row < 0) || (row >= this.rows) || (col < 0) || (col >= this.cols))
                {
                    throw new IndexOutOfRangeException("Index out of range!!!");                    
                }
                else
                {
                    this.matrix[row, col] = value;
                }
            }
        }
        // overload operator + 10. Implement operators
        public static Matrix<T> operator +(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("The matrices must have the same size!");
            }
            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] + second[i, j];
                }
            }
            return resultMatrix;
        }
        // overload operator -
        public static Matrix<T> operator -(Matrix<T> first, Matrix<T> second)
        {
            if ((first.rows != second.rows) || (first.cols != second.cols))
            {
                throw new ApplicationException("The matrices must have the same size!");
            }
            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    resultMatrix[i, j] = (dynamic)first[i, j] - second[i, j];
                }
            }
            return resultMatrix;
        }
        // overload operator *
        public static Matrix<T> operator *(Matrix<T> first, Matrix<T> second)
        {
            if (first.cols != second.rows)
            {
                throw new ApplicationException("The matrices must have the same size!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(first.rows, first.cols);
            for (int i = 0; i < first.rows; i++)
            {
                for (int j = 0; j < first.cols; j++)
                {
                    for (int k = 0; k < first.cols; k++)
                    {
                        resultMatrix[i, j] += (dynamic)first[i, k] * second[k, j];
                    }
                }
            }
            return resultMatrix;
        }
        //   overload operator true
        public static bool operator true(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        // false oprator overload
        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.cols; j++)
                {
                    if ((dynamic)matrix[i, j] != default(T))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.cols; j++)
                {
                    builder.AppendFormat("{0,5}", this[i, j]);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}
