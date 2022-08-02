using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MatrixCalc
{
    public partial class MatrixCalculator : Form
    {
        #region variables
        Result res;
        static double[,] arrayA;//contains matrixA
        static double[,] arrayB;//contains matrixB
        static double[,] arrayC;//will be put resultMatrix
        #endregion//
        public MatrixCalculator()
        {
            InitializeComponent();
            matrixA.ColumnCount = Convert.ToInt32(setAColumn.Value);
            matrixA.RowCount = 2;
            arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
            matrixB.ColumnCount = 4;
            matrixB.RowCount = 4;
            arrayB = new double[matrixB.RowCount, matrixB.ColumnCount];
            cmbOperations.SelectedIndex = 0;
        }

        #region DataGridView - Array functions
        void putMatrixAToArray()
        {
            try
            {
                for (int i = 0; i < matrixA.RowCount; i++)
                {
                    for (int j = 0; j < matrixA.ColumnCount; j++)
                    {
                        arrayA[i, j] = Convert.ToDouble(matrixA.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fill up Matrix A with numbers","Incomplete Matrix",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        void putMatrixBToArray()
        {
            try
            {
                for (int i = 0; i < matrixB.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        arrayB[i, j] = Convert.ToDouble(matrixB.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Fill up Matrix B with numbers", "Incomplete Matrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        bool isMatrixNotEmpty(DataGridView matrix)
        {
            bool flag = true;
            foreach (DataGridViewRow rw in matrix.Rows)
            {
                for (int i = 0; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value ||
                        String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                    {
                        flag = false;
                        MessageBox.Show("Fill up Matrix " + matrix.Name.Last() + " with numbers", "Incomplete Matrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                if (flag == false)
                    break;
            }
            return flag;
        }
        void putToGrid()//puts array to grid
        {
            res.resultMatrix.RowCount = matrixA.RowCount;
            res.resultMatrix.ColumnCount = matrixB.ColumnCount;
            try
            {
                for (int i = 0; i < matrixA.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        res.resultMatrix.Rows[i].Cells[j].Value = arrayC[i, j];
                    }
                }
                res.Show();
            }
            catch
            {
                MessageBox.Show("Fill up Matrix", "Incomplete Matrix", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        #region setMatrixSizes
        private void setAButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOperations.SelectedIndex != 2)
                {
                    matrixA.ColumnCount = Convert.ToInt32(setAColumn.Value);
                    matrixA.RowCount = Convert.ToInt32(setARow.Value);
                    arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                }
                else
                {
                    matrixA.ColumnCount = Convert.ToInt32(setAColumn.Value);
                    matrixA.RowCount = Convert.ToInt32(setARow.Value);
                    arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                    matrixB.RowCount = matrixA.ColumnCount;
                    setBRow.Value = setAColumn.Value;                    
                }
            }
            catch
            {
                MessageBox.Show("Matrix Sizes should be postive integers greater than 1", "Invalid Matrix Size");
            }
            
            

        }//sets matrixA size
        private void setBButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOperations.SelectedIndex != 2)
                {
                    matrixB.ColumnCount = Convert.ToInt32(setBColumn.Value);
                    matrixB.RowCount = Convert.ToInt32(setBRow.Value);
                    arrayB = new double[matrixB.RowCount, matrixB.ColumnCount];
                }
                else
                {
                    matrixB.ColumnCount = Convert.ToInt32(setBColumn.Value);
                    matrixB.RowCount = Convert.ToInt32(setBRow.Value);
                    arrayB = new double[matrixB.RowCount, matrixB.ColumnCount];
                    matrixA.ColumnCount = matrixB.RowCount;
                    setAColumn.Value = setBRow.Value;
                }

            }
            catch
            {
                MessageBox.Show("Matrix Sizes should be postive integers greater than 1", "Invalid Matrix Size");
            }

        }//sets matrixB size
        private void setButton_Click(object sender, EventArgs e)
        {
            try
            {             
                matrixA.ColumnCount = Convert.ToInt32(setAColumn.Value);
                matrixA.RowCount = Convert.ToInt32(setARow.Value);
                matrixB.ColumnCount = Convert.ToInt32(setAColumn.Value);
                matrixB.RowCount = Convert.ToInt32(setARow.Value);


                matrixA.RowCount = matrixA.RowCount;//causes error if numupdown>5
                matrixA.ColumnCount = matrixA.ColumnCount;//causes error if numupdown>5
                matrixB.RowCount = matrixA.RowCount;//causes error if numupdown>5
                matrixB.ColumnCount = matrixA.ColumnCount;//causes error if numupdown>5

                arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                arrayB = new double[matrixA.RowCount, matrixA.ColumnCount];
            }
            catch
            {
                MessageBox.Show("Matrix Sizes should be postive integers greater than 1", "Invalid Matrix Size");
            }

        }//sets all matrices size
        private void btnSetSquareMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                matrixA.ColumnCount = Convert.ToInt32(setSquare.Value);
                matrixA.RowCount = Convert.ToInt32(setSquare.Value);

                arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                matrixA.RowCount = matrixA.RowCount;
                matrixA.ColumnCount = matrixA.ColumnCount;
            }
            catch
            {
                MessageBox.Show("Matrix Sizes should be postive integers greater than 1", "Invalid Matrix Size");
            }
        }//sets squarematrix size
        #endregion

        #region operations
        void MatrixMultiply()
        {
            arrayC = new double[matrixA.RowCount, matrixB.ColumnCount];
            if (matrixA.ColumnCount == matrixB.RowCount)
            {
                for (int i = 0; i < matrixA.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        for (int k = 0; k < matrixA.ColumnCount; k++)
                        {
                            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
                        }
                    }
                }
                res.Text = "Result : Multiplication";
                putToGrid();
            }
            else
            {
                MessageBox.Show("Matrix A's Columns shoud be equal to Matrix B's Rows","Matrix Multiplication",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        void MatrixAdd()
        {
            arrayC = new double[matrixA.RowCount, matrixA.ColumnCount];
            if (matrixA.ColumnCount == matrixB.ColumnCount && matrixA.RowCount == matrixB.RowCount)
            {

                for (int i = 0; i < matrixB.RowCount; i++)
                {
                    for (int j = 0; j < matrixA.ColumnCount; j++)
                    {
                        arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                    }
                }
                res.Text = "Result : Addition";
                putToGrid();
            }
            else
            {
                MessageBox.Show("To be able to add two matrices, they must be of the same size","Matrix Addition",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
        void MatrixSubtract()
        {
            arrayC = new double[matrixA.RowCount, matrixA.ColumnCount];
            if (matrixA.ColumnCount == matrixB.ColumnCount && matrixA.RowCount == matrixB.RowCount)
            {
                for (int i = 0; i < matrixB.RowCount; i++)
                {
                    for (int j = 0; j < matrixB.ColumnCount; j++)
                    {
                        arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                    }
                }
                res.Text = "Result : Subtraction";
                putToGrid();
            }
            else
            {
                MessageBox.Show("To be able to subtract two matrices, they must be of the same size", "Matrix Subtraction", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        void MatrixTranspose()
        {
            try
            {
                int rows = arrayA.GetLength(0);
                int columns = arrayA.GetLength(1);
                res.resultMatrix.RowCount = columns;
                res.resultMatrix.ColumnCount = rows;
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        res.resultMatrix.Rows[c].Cells[r].Value = arrayA[r, c];
                        if (res.resultMatrix.Rows[c].Cells[r].Value == null || res.resultMatrix.Rows[c].Cells[r].Value == DBNull.Value || String.IsNullOrWhiteSpace(res.resultMatrix.Rows[c].Cells[r].Value.ToString()))
                        {
                            MessageBox.Show("Error");
                            return;
                        }

                    }
                }
                res.Text = "Result: Transpose";
                res.Show();
            }
            catch
            {
                MessageBox.Show("Set Matrix A Size First");
                return;
            }


        }
        double MatrixDetermiant(double[,] mat, int n)
        {
            double D = 0; // Initialize result 
            if (matrixA.ColumnCount == matrixA.RowCount)
            {
                {
                    if (n == 1)
                        return mat[0, 0];
                    // To store cofactors 
                    double[,] temp = new double[matrixA.RowCount-1, matrixA.RowCount - 1];

                    // To store sign multiplier 
                    int sign = 1;

                    // Iterate for each element 
                    // of first row 
                    for (int f = 0; f < n; f++)
                    {
                        // Getting Cofactor of mat[0][f] 
                        getCofactor(mat, temp, 0, f, n);
                        D += sign * mat[0, f] * MatrixDetermiant(temp, n - 1);

                        // terms are to be added with  
                        // alternate sign 
                        sign = -sign;
                    }
                }
            }
            else
            {
                MessageBox.Show("Matrix A should be a Square Matrix");
            }            
            return D;
        }
        void getCofactor(double[,] mat, double[,] temp, int p, int q, int n)//Determinant helper
        {
            int i = 0, j = 0;

            // Looping for each element of  
            // the matrix 
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {

                    // Copying into temporary matrix  
                    // only those element which are  
                    // not in given row and column 
                    if (row != p && col != q)
                    {
                        temp[i, j++] = mat[row, col];

                        // Row is filled, so increase  
                        // row index and reset col  
                        //index 
                        if (j == n - 1)
                        {
                            j = 0;
                            i++;
                        }
                    }
                }
            }
        }
        #endregion

        #region compute
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (cmbOperations.SelectedIndex == 3 || cmbOperations.SelectedIndex == 4)
            {
                if (isMatrixNotEmpty(matrixA) == true)
                {
                    putMatrixAToArray();
                }
                else
                {
                    return;
                }
            }
            else
            {

                if (isMatrixNotEmpty(matrixA) == true && isMatrixNotEmpty(matrixB) == true)
                {
                    putMatrixAToArray();
                    putMatrixBToArray();
                }
                else
                {
                    return;
                }
            }
            res = new Result();
            switch (cmbOperations.SelectedIndex)
            {
                case 0://Add
                    MatrixAdd();
                    break;
                case 1://Subtract
                    MatrixSubtract();
                    break;
                case 2://Multiply
                    MatrixMultiply();
                    break;
                case 3://Transpose
                    MatrixTranspose();
                    break;
                case 4://Determinant
                    double d =MatrixDetermiant(arrayA, matrixA.RowCount);
                    MessageBox.Show("Matrix A Determinant: " + d, "Result : Determinant");

                    break;
                default:
                    MessageBox.Show("Choose an Operation");
                    break;
            }

        }
        #endregion

        #region visibility
        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOperations.SelectedIndex == 0 || cmbOperations.SelectedIndex == 1)//Add&Subtract
            {
                pMatrixBSize.Hide();
                setButton.Show();
                setAButton.Hide();
                gbMatrixA.Show();
                gbMatrixB.Show();
                gbMatrixA.Location = new Point(10, 30);
                pMatrixSize.Location = new Point(324, 193);
                pMatrixSize.Show();
                pSquare.Hide();
                btnClearB.Show();
                btnClearA.Location = new Point(185, 343);
                btnFillZero.Location = new Point(185, 381);
                if (matrixA.RowCount>matrixB.RowCount)
                {
                    matrixB.RowCount = matrixA.RowCount;
                    setARow.Value = matrixA.RowCount;
                }
                else
                {
                    matrixA.RowCount = matrixB.RowCount;
                    setARow.Value = matrixB.RowCount;
                }
                if(matrixA.ColumnCount>matrixB.ColumnCount)
                {
                    matrixB.ColumnCount = matrixA.ColumnCount;
                    setAColumn.Value = matrixA.ColumnCount;
                }
                else
                {
                    matrixA.ColumnCount = matrixB.ColumnCount;
                    setAColumn.Value = matrixB.ColumnCount;
                }
                arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                arrayB = new double[matrixA.RowCount, matrixA.ColumnCount];


            }
            else if (cmbOperations.SelectedIndex == 2)//Multiplication
            {
                setButton.Visible=false;
                setAButton.Show();                
                gbMatrixB.Show();
                pMatrixBSize.Show();
                pMatrixSize.Show();
                pMatrixSize.Location = new Point(120, 193);
                gbMatrixA.Location = new Point(10, 30);
                pSquare.Hide();
                btnClearB.Show();
                btnClearA.Location = new Point(185, 343);
                if(matrixA.ColumnCount>matrixB.RowCount)
                {
                    setBRow.Value = setAColumn.Value;
                    matrixB.RowCount = matrixA.ColumnCount;
                }
                else
                {
                    setAColumn.Value = setBRow.Value;
                    matrixA.ColumnCount = matrixB.RowCount ;
                }
                setARow.Value = matrixA.RowCount;
                setBColumn.Value = matrixB.ColumnCount;
                arrayA = new double[matrixA.RowCount, matrixA.ColumnCount];
                arrayB = new double[matrixB.RowCount, matrixB.ColumnCount];


            }
            else if (cmbOperations.SelectedIndex == 3)//Transpose
            {
                setButton.Hide();
                gbMatrixA.Show();
                gbMatrixB.Visible=false;
                setAButton.Show();
                pMatrixBSize.Hide();
                gbMatrixA.Location = new Point(230, 30);
                pMatrixSize.Location = new Point(324, 193);
                pMatrixSize.Show();
                pSquare.Hide();
                btnClearB.Hide();
                btnClearA.Location = new Point(546, 343);
                setARow.Value = matrixA.RowCount;
                setAColumn.Value = matrixA.ColumnCount;
                btnFillZero.Location = new Point(185, 343);
            }
            else if (cmbOperations.SelectedIndex == 4)//Determinant
            {
                setButton.Hide();
                gbMatrixA.Show();
                gbMatrixB.Visible = false;
                setAButton.Show();
                pMatrixBSize.Hide();
                pMatrixSize.Hide();
                gbMatrixA.Location = new Point(230, 30);
                pSquare.Location = new Point(324, 193);
                pSquare.Show();
                btnClearB.Hide();
                btnClearA.Location = new Point(546, 343);
                btnFillZero.Location = new Point(185, 343);
                if (matrixA.ColumnCount<matrixA.RowCount)
                {
                    matrixA.ColumnCount = matrixA.RowCount;
                    setSquare.Value = matrixA.ColumnCount;
                }
                else
                {
                    matrixA.RowCount = matrixA.ColumnCount;
                    setSquare.Value = matrixA.RowCount;
                }

            }
        }
        #endregion

        #region help
        private void aboutBasicMatrixCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Basic Matrix Calculator v.1.0\nCopyright©2018\nby Kim Escabarte", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void matrixAdditionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.purplemath.com/modules/mtrxadd.htm");
        }

        private void matrixMultiplcationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.purplemath.com/modules/mtrxmult.htm");
        }

        private void squareMatricesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.purplemath.com/modules/matrices.htm");
        }

        private void squareMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Square_matrix");
        }

        private void determinantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Determinant");
        }

        private void transposeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Transpose");
        }
        #endregion

        #region Prevent user from entering nonnumbers
        private void matrixA_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += Control_KeyPress;
        }
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '-') ||
                (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)||
                (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0))
            {
                e.Handled = true;
            }       
        }
        private void matrixB_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs o)
        {
            o.Control.KeyPress += Control_KeyPress1;
        }

        private void Control_KeyPress1(object sender, KeyPressEventArgs o)
        {
            if ((!char.IsControl(o.KeyChar) && !char.IsDigit(o.KeyChar) && o.KeyChar != '.' && o.KeyChar != '-') ||
                (o.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) ||
                (o.KeyChar == '-' && (sender as TextBox).Text.Length > 0))
            {
                o.Handled = true;
            }
        }


        #endregion

        #region clear grid
        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixA.Columns.Count; i++)
            {
                for (int j = 0; j < matrixA.Rows.Count; j++)
                {
                    matrixA.Rows[j].Cells[i].Value = DBNull.Value;
                }
            }
        }

        private void btnClearB_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < matrixB.Columns.Count; i++)
            {
                for (int j = 0; j < matrixB.Rows.Count; j++)
                {
                    matrixB.Rows[j].Cells[i].Value = DBNull.Value;
                }
            }
        }
        #endregion

        private void btnFillZero_Click(object sender, EventArgs e)
        {
            if(cmbOperations.SelectedIndex==3|| cmbOperations.SelectedIndex == 4)
            {
                foreach (DataGridViewRow rw in matrixA.Rows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value ||
                            String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                        {
                            rw.Cells[i].Value = 0;
                        }
                    }
                }
            }

            else
            {
                foreach (DataGridViewRow rw in matrixA.Rows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value ||
                            String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                        {
                            rw.Cells[i].Value = 0;
                        }
                    }
                }
                foreach (DataGridViewRow rw in matrixB.Rows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value ||
                            String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                        {
                            rw.Cells[i].Value = 0;
                        }
                    }
                }
            }
        }
    }
}
