using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON_LV3
{
    class MatrixGenerator
    {
        private static MatrixGenerator instance;
        private Random generator;
        private MatrixGenerator()
        {
            generator = new Random();
        }
        public static MatrixGenerator getInstance(){
            if(instance==null)
                instance=new MatrixGenerator();
            return instance;
        }
        private double[][] allocateMatrix(int rows,int columns){
            double[][] matrix = new double[rows][];
            for (int i = 0; i < rows; i++)
                matrix[i] = new double[columns];
            return matrix;
        }
        public double[][] generateMatrix(int rows, int columns)
        {
            double[][] matrix = allocateMatrix(rows, columns);
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < columns; j++)
                    matrix[i][j] = generator.NextDouble();
            return matrix;
        }
    }
}
