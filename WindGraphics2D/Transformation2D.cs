using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindGraphics2D
{
    internal class Transformation2D
    {
        public static float[,] RightTranslationMatrix(float tx,float ty) {
            float[,] Tr = { {1,0,0},
                             {0,1,0},
                             {tx,ty,1}};
            return Tr;
        }
        public static float[,] RightRotationMatrix(double angle) {
            float sin = Convert.ToSingle(Math.Sin(angle));
            float cos = Convert.ToSingle(Math.Cos(angle));
            float[,] Rr = {{cos,sin,0},
                            {-sin,cos,0},
                            {0,0,1 } };
            return Rr;
        }
        public static float[,] RightRotationAboutPointMatrix(float x,float y,double angle) {
            float sin = Convert.ToSingle(Math.Sin(angle));
            float cos = Convert.ToSingle(Math.Cos(angle));
            float[,] RAboutPoint = { { cos,sin,0},
                                      {-sin,cos,0},
                                      {x*(1-cos)+y*sin,y*(1-cos)+x*sin,1 } };
            return RAboutPoint;
        }
        public static float[,] ScalingMatrix(float Sx, float Sy)
        {
            float[,] S = { {Sx,0,0 },
                             {0,Sy,0},
                             {0,0,1} };
            return S;
        }
        public static float[,] MatrixMultiplication(float[,] A, float[,] B) {
            int numOfRowsA = A.GetLength(0);
            int numOfColumsA =A.GetLength(1);
            int numOfRowsB = B.GetLength(0);
            int numOfColumsB = B.GetLength(1);
            if (numOfColumsA == numOfRowsB)
            {
                float temp;
                float[,] Result = new float[numOfRowsA, numOfColumsB];
                for (int i = 0; i < numOfRowsA; i++)
                {
                    for (int k= 0; k < numOfColumsB; k++)
                    {
                        temp = 0;
                        for (int j = 0; j < numOfColumsA; j++)
                        {
                            temp += A[i, j] * B[j, k];
                        }
                        Result[i, k] = temp;
                    }
                }
                return Result;
            }

            else return null;
        }
        public static void displayMatrix(float[,] array,DataGridView dataGridView)
        {
            string[] row= new string[array.GetLength(1)];
            for (int j = 0; j < array.GetLength(0); j++)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    row[i] = array[j,i].ToString();
                }
                dataGridView.Rows.Add(row);
            }
            dataGridView.Rows.Add();
        }
    }
}
