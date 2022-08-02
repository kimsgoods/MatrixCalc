namespace MatrixCalc
{
    partial class MatrixCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixCalculator));
            this.btnGo = new System.Windows.Forms.Button();
            this.cmbOperations = new System.Windows.Forms.ComboBox();
            this.labelOperations = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.setAButton = new System.Windows.Forms.Button();
            this.setAColumn = new System.Windows.Forms.NumericUpDown();
            this.setARow = new System.Windows.Forms.NumericUpDown();
            this.setButton = new System.Windows.Forms.Button();
            this.matrixA = new System.Windows.Forms.DataGridView();
            this.matrixB = new System.Windows.Forms.DataGridView();
            this.setSquare = new System.Windows.Forms.NumericUpDown();
            this.btnSetSquareMatrix = new System.Windows.Forms.Button();
            this.setBColumn = new System.Windows.Forms.NumericUpDown();
            this.SetBButton = new System.Windows.Forms.Button();
            this.setBRow = new System.Windows.Forms.NumericUpDown();
            this.btnClearA = new System.Windows.Forms.Button();
            this.btnClearB = new System.Windows.Forms.Button();
            this.btnFillZero = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareMatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixAdditionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matrixMultiplcationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transposeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.squareMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.determinantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutBasicMatrixCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pMatrixSize = new System.Windows.Forms.Panel();
            this.labelColumnA = new System.Windows.Forms.Label();
            this.labelRowA = new System.Windows.Forms.Label();
            this.gbMatrixA = new System.Windows.Forms.GroupBox();
            this.gbMatrixB = new System.Windows.Forms.GroupBox();
            this.pSquare = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pMatrixBSize = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.setAColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setARow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBColumn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBRow)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.pMatrixSize.SuspendLayout();
            this.gbMatrixA.SuspendLayout();
            this.gbMatrixB.SuspendLayout();
            this.pSquare.SuspendLayout();
            this.pMatrixBSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(488, 469);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(199, 52);
            this.btnGo.TabIndex = 1000;
            this.btnGo.Text = "Calculate";
            this.toolTip.SetToolTip(this.btnGo, "Click here to commence operation");
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // cmbOperations
            // 
            this.cmbOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperations.FormattingEnabled = true;
            this.cmbOperations.Items.AddRange(new object[] {
            "Addition",
            "Subtraction",
            "Multiplication",
            "Transpose",
            "Get Determinant"});
            this.cmbOperations.Location = new System.Drawing.Point(453, 422);
            this.cmbOperations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Size = new System.Drawing.Size(265, 38);
            this.cmbOperations.TabIndex = 99;
            this.cmbOperations.SelectedIndexChanged += new System.EventHandler(this.cmbOperations_SelectedIndexChanged);
            // 
            // labelOperations
            // 
            this.labelOperations.AutoSize = true;
            this.labelOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperations.Location = new System.Drawing.Point(483, 379);
            this.labelOperations.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(193, 39);
            this.labelOperations.TabIndex = 17;
            this.labelOperations.Text = "Operations";
            // 
            // setAButton
            // 
            this.setAButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAButton.Location = new System.Drawing.Point(65, 87);
            this.setAButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setAButton.Name = "setAButton";
            this.setAButton.Size = new System.Drawing.Size(180, 44);
            this.setAButton.TabIndex = 51;
            this.setAButton.Text = "Set Matrix A";
            this.toolTip.SetToolTip(this.setAButton, "Click Here to Set Matrix Size");
            this.setAButton.UseVisualStyleBackColor = true;
            this.setAButton.Visible = false;
            this.setAButton.Click += new System.EventHandler(this.setAButton_Click);
            // 
            // setAColumn
            // 
            this.setAColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setAColumn.Location = new System.Drawing.Point(180, 48);
            this.setAColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setAColumn.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setAColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setAColumn.Name = "setAColumn";
            this.setAColumn.Size = new System.Drawing.Size(65, 30);
            this.setAColumn.TabIndex = 50;
            this.setAColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.setAColumn, "Enter the Number of Columns for the Matrix(MaxSize:5x5) ");
            this.setAColumn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // setARow
            // 
            this.setARow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setARow.Location = new System.Drawing.Point(180, 12);
            this.setARow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setARow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setARow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setARow.Name = "setARow";
            this.setARow.Size = new System.Drawing.Size(65, 30);
            this.setARow.TabIndex = 49;
            this.setARow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.setARow, "Enter the Number of Rows For the Matrix (MaxSize:5x5)");
            this.setARow.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // setButton
            // 
            this.setButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setButton.Location = new System.Drawing.Point(79, 87);
            this.setButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(152, 44);
            this.setButton.TabIndex = 51;
            this.setButton.Text = "Set Matrix ";
            this.toolTip.SetToolTip(this.setButton, "Click Here to Set Matrix Size");
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // matrixA
            // 
            this.matrixA.AllowUserToAddRows = false;
            this.matrixA.AllowUserToDeleteRows = false;
            this.matrixA.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixA.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.matrixA.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.matrixA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixA.ColumnHeadersVisible = false;
            this.matrixA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixA.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matrixA.Location = new System.Drawing.Point(4, 38);
            this.matrixA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrixA.Name = "matrixA";
            this.matrixA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixA.RowHeadersVisible = false;
            this.matrixA.RowHeadersWidth = 51;
            this.matrixA.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrixA.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixA.Size = new System.Drawing.Size(552, 161);
            this.matrixA.TabIndex = 1;
            this.toolTip.SetToolTip(this.matrixA, "Enter Matrix Values Here");
            this.matrixA.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixA_EditingControlShowing);
            // 
            // matrixB
            // 
            this.matrixB.AllowUserToAddRows = false;
            this.matrixB.AllowUserToDeleteRows = false;
            this.matrixB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.matrixB.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.matrixB.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.matrixB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.matrixB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrixB.ColumnHeadersVisible = false;
            this.matrixB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrixB.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.matrixB.Location = new System.Drawing.Point(4, 38);
            this.matrixB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.matrixB.Name = "matrixB";
            this.matrixB.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.matrixB.RowHeadersVisible = false;
            this.matrixB.RowHeadersWidth = 51;
            this.matrixB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.matrixB.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixB.Size = new System.Drawing.Size(552, 161);
            this.matrixB.TabIndex = 6;
            this.toolTip.SetToolTip(this.matrixB, "Enter Matrix Values Here");
            this.matrixB.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.matrixB_EditingControlShowing);
            // 
            // setSquare
            // 
            this.setSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setSquare.Location = new System.Drawing.Point(193, 25);
            this.setSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setSquare.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setSquare.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setSquare.Name = "setSquare";
            this.setSquare.Size = new System.Drawing.Size(65, 30);
            this.setSquare.TabIndex = 49;
            this.setSquare.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.setSquare, "Enter the Square Matrix Size(MaxSize:5x5)");
            this.setSquare.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnSetSquareMatrix
            // 
            this.btnSetSquareMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetSquareMatrix.Location = new System.Drawing.Point(65, 87);
            this.btnSetSquareMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetSquareMatrix.Name = "btnSetSquareMatrix";
            this.btnSetSquareMatrix.Size = new System.Drawing.Size(179, 44);
            this.btnSetSquareMatrix.TabIndex = 50;
            this.btnSetSquareMatrix.Text = "Set Matrix A";
            this.toolTip.SetToolTip(this.btnSetSquareMatrix, "Click Here to Set Matrix Size");
            this.btnSetSquareMatrix.UseVisualStyleBackColor = true;
            this.btnSetSquareMatrix.Click += new System.EventHandler(this.btnSetSquareMatrix_Click);
            // 
            // setBColumn
            // 
            this.setBColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBColumn.Location = new System.Drawing.Point(175, 44);
            this.setBColumn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setBColumn.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setBColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setBColumn.Name = "setBColumn";
            this.setBColumn.Size = new System.Drawing.Size(65, 30);
            this.setBColumn.TabIndex = 50;
            this.setBColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.setBColumn, "Enter the Number of Columns for the Matrix(MaxSize:5x5) ");
            this.setBColumn.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // SetBButton
            // 
            this.SetBButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetBButton.Location = new System.Drawing.Point(67, 87);
            this.SetBButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SetBButton.Name = "SetBButton";
            this.SetBButton.Size = new System.Drawing.Size(176, 44);
            this.SetBButton.TabIndex = 51;
            this.SetBButton.Text = "Set Matrix B ";
            this.toolTip.SetToolTip(this.SetBButton, "Click Here to Set Matrix Size");
            this.SetBButton.UseVisualStyleBackColor = true;
            this.SetBButton.Click += new System.EventHandler(this.setBButton_Click);
            // 
            // setBRow
            // 
            this.setBRow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBRow.Location = new System.Drawing.Point(175, 9);
            this.setBRow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setBRow.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.setBRow.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.setBRow.Name = "setBRow";
            this.setBRow.Size = new System.Drawing.Size(65, 30);
            this.setBRow.TabIndex = 49;
            this.setBRow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.setBRow, "Enter the Number of Rows For the Matrix(MaxSize:5x5) ");
            this.setBRow.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btnClearA
            // 
            this.btnClearA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearA.Location = new System.Drawing.Point(247, 422);
            this.btnClearA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearA.Name = "btnClearA";
            this.btnClearA.Size = new System.Drawing.Size(199, 41);
            this.btnClearA.TabIndex = 100;
            this.btnClearA.Text = "Clear Matrix A";
            this.toolTip.SetToolTip(this.btnClearA, "Click Here to Clear Matrix A");
            this.btnClearA.UseVisualStyleBackColor = true;
            this.btnClearA.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClearB
            // 
            this.btnClearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearB.Location = new System.Drawing.Point(728, 422);
            this.btnClearB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClearB.Name = "btnClearB";
            this.btnClearB.Size = new System.Drawing.Size(199, 41);
            this.btnClearB.TabIndex = 101;
            this.btnClearB.Text = "Clear Matrix B";
            this.toolTip.SetToolTip(this.btnClearB, "Click Here to Clear Matrix B");
            this.btnClearB.UseVisualStyleBackColor = true;
            this.btnClearB.Click += new System.EventHandler(this.btnClearB_Click);
            // 
            // btnFillZero
            // 
            this.btnFillZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFillZero.Location = new System.Drawing.Point(247, 469);
            this.btnFillZero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFillZero.Name = "btnFillZero";
            this.btnFillZero.Size = new System.Drawing.Size(199, 41);
            this.btnFillZero.TabIndex = 1001;
            this.btnFillZero.Text = "Fill Empty Cells\r\n with Zero";
            this.toolTip.SetToolTip(this.btnFillZero, "Click Here to Clear Matrix A");
            this.btnFillZero.UseVisualStyleBackColor = true;
            this.btnFillZero.Click += new System.EventHandler(this.btnFillZero_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1171, 28);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.toolStripSeparator4,
            this.aboutBasicMatrixCalculatorToolStripMenuItem,
            this.toolStripSeparator2});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareMatricesToolStripMenuItem,
            this.matrixAdditionToolStripMenuItem,
            this.matrixMultiplcationToolStripMenuItem,
            this.transposeToolStripMenuItem,
            this.toolStripSeparator1,
            this.squareMatrixToolStripMenuItem,
            this.determinantToolStripMenuItem});
            this.viewHelpToolStripMenuItem.Image = global::MatrixCalc.Properties.Resources.help;
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // squareMatricesToolStripMenuItem
            // 
            this.squareMatricesToolStripMenuItem.Name = "squareMatricesToolStripMenuItem";
            this.squareMatricesToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.squareMatricesToolStripMenuItem.Text = "Matrix Introduction";
            this.squareMatricesToolStripMenuItem.Click += new System.EventHandler(this.squareMatricesToolStripMenuItem_Click);
            // 
            // matrixAdditionToolStripMenuItem
            // 
            this.matrixAdditionToolStripMenuItem.Name = "matrixAdditionToolStripMenuItem";
            this.matrixAdditionToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.matrixAdditionToolStripMenuItem.Text = "Matrix Addition/Subtraction";
            this.matrixAdditionToolStripMenuItem.Click += new System.EventHandler(this.matrixAdditionToolStripMenuItem_Click);
            // 
            // matrixMultiplcationToolStripMenuItem
            // 
            this.matrixMultiplcationToolStripMenuItem.Name = "matrixMultiplcationToolStripMenuItem";
            this.matrixMultiplcationToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.matrixMultiplcationToolStripMenuItem.Text = "Matrix Multiplcation";
            this.matrixMultiplcationToolStripMenuItem.Click += new System.EventHandler(this.matrixMultiplcationToolStripMenuItem_Click);
            // 
            // transposeToolStripMenuItem
            // 
            this.transposeToolStripMenuItem.Name = "transposeToolStripMenuItem";
            this.transposeToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.transposeToolStripMenuItem.Text = "Transpose";
            this.transposeToolStripMenuItem.Click += new System.EventHandler(this.transposeToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(275, 6);
            // 
            // squareMatrixToolStripMenuItem
            // 
            this.squareMatrixToolStripMenuItem.Name = "squareMatrixToolStripMenuItem";
            this.squareMatrixToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.squareMatrixToolStripMenuItem.Text = "Square Matrix";
            this.squareMatrixToolStripMenuItem.Click += new System.EventHandler(this.squareMatrixToolStripMenuItem_Click);
            // 
            // determinantToolStripMenuItem
            // 
            this.determinantToolStripMenuItem.Name = "determinantToolStripMenuItem";
            this.determinantToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.determinantToolStripMenuItem.Text = "Determinant";
            this.determinantToolStripMenuItem.Click += new System.EventHandler(this.determinantToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(285, 6);
            // 
            // aboutBasicMatrixCalculatorToolStripMenuItem
            // 
            this.aboutBasicMatrixCalculatorToolStripMenuItem.Image = global::MatrixCalc.Properties.Resources.about;
            this.aboutBasicMatrixCalculatorToolStripMenuItem.Name = "aboutBasicMatrixCalculatorToolStripMenuItem";
            this.aboutBasicMatrixCalculatorToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.aboutBasicMatrixCalculatorToolStripMenuItem.Text = "About Basic Matrix Calculator";
            this.aboutBasicMatrixCalculatorToolStripMenuItem.Click += new System.EventHandler(this.aboutBasicMatrixCalculatorToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(285, 6);
            // 
            // pMatrixSize
            // 
            this.pMatrixSize.Controls.Add(this.setButton);
            this.pMatrixSize.Controls.Add(this.setAButton);
            this.pMatrixSize.Controls.Add(this.setAColumn);
            this.pMatrixSize.Controls.Add(this.setARow);
            this.pMatrixSize.Controls.Add(this.labelColumnA);
            this.pMatrixSize.Controls.Add(this.labelRowA);
            this.pMatrixSize.Location = new System.Drawing.Point(432, 238);
            this.pMatrixSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMatrixSize.Name = "pMatrixSize";
            this.pMatrixSize.Size = new System.Drawing.Size(311, 135);
            this.pMatrixSize.TabIndex = 50;
            // 
            // labelColumnA
            // 
            this.labelColumnA.AutoSize = true;
            this.labelColumnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColumnA.Location = new System.Drawing.Point(65, 46);
            this.labelColumnA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelColumnA.Name = "labelColumnA";
            this.labelColumnA.Size = new System.Drawing.Size(108, 29);
            this.labelColumnA.TabIndex = 17;
            this.labelColumnA.Text = "Columns";
            // 
            // labelRowA
            // 
            this.labelRowA.AutoSize = true;
            this.labelRowA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRowA.Location = new System.Drawing.Point(100, 15);
            this.labelRowA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRowA.Name = "labelRowA";
            this.labelRowA.Size = new System.Drawing.Size(74, 29);
            this.labelRowA.TabIndex = 16;
            this.labelRowA.Text = "Rows";
            // 
            // gbMatrixA
            // 
            this.gbMatrixA.Controls.Add(this.matrixA);
            this.gbMatrixA.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatrixA.Location = new System.Drawing.Point(35, 37);
            this.gbMatrixA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMatrixA.Name = "gbMatrixA";
            this.gbMatrixA.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMatrixA.Size = new System.Drawing.Size(560, 203);
            this.gbMatrixA.TabIndex = 26;
            this.gbMatrixA.TabStop = false;
            this.gbMatrixA.Text = "Matrix A";
            // 
            // gbMatrixB
            // 
            this.gbMatrixB.Controls.Add(this.matrixB);
            this.gbMatrixB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMatrixB.Location = new System.Drawing.Point(597, 37);
            this.gbMatrixB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMatrixB.Name = "gbMatrixB";
            this.gbMatrixB.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbMatrixB.Size = new System.Drawing.Size(560, 203);
            this.gbMatrixB.TabIndex = 27;
            this.gbMatrixB.TabStop = false;
            this.gbMatrixB.Text = "Matrix B";
            // 
            // pSquare
            // 
            this.pSquare.Controls.Add(this.btnSetSquareMatrix);
            this.pSquare.Controls.Add(this.setSquare);
            this.pSquare.Controls.Add(this.label1);
            this.pSquare.Controls.Add(this.label2);
            this.pSquare.Location = new System.Drawing.Point(160, 238);
            this.pSquare.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pSquare.Name = "pSquare";
            this.pSquare.Size = new System.Drawing.Size(311, 135);
            this.pSquare.TabIndex = 28;
            this.pSquare.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Rows /";
            // 
            // pMatrixBSize
            // 
            this.pMatrixBSize.Controls.Add(this.setBColumn);
            this.pMatrixBSize.Controls.Add(this.SetBButton);
            this.pMatrixBSize.Controls.Add(this.setBRow);
            this.pMatrixBSize.Controls.Add(this.label3);
            this.pMatrixBSize.Controls.Add(this.label4);
            this.pMatrixBSize.Location = new System.Drawing.Point(723, 238);
            this.pMatrixBSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pMatrixBSize.Name = "pMatrixBSize";
            this.pMatrixBSize.Size = new System.Drawing.Size(311, 135);
            this.pMatrixBSize.TabIndex = 29;
            this.pMatrixBSize.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Columns";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(95, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Rows";
            // 
            // MatrixCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1171, 516);
            this.Controls.Add(this.btnFillZero);
            this.Controls.Add(this.btnClearB);
            this.Controls.Add(this.btnClearA);
            this.Controls.Add(this.gbMatrixB);
            this.Controls.Add(this.gbMatrixA);
            this.Controls.Add(this.pMatrixSize);
            this.Controls.Add(this.labelOperations);
            this.Controls.Add(this.cmbOperations);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pSquare);
            this.Controls.Add(this.pMatrixBSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1193, 567);
            this.MinimumSize = new System.Drawing.Size(1193, 567);
            this.Name = "MatrixCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Basic Matrix Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.setAColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setARow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrixB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBColumn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.setBRow)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pMatrixSize.ResumeLayout(false);
            this.pMatrixSize.PerformLayout();
            this.gbMatrixA.ResumeLayout(false);
            this.gbMatrixB.ResumeLayout(false);
            this.pSquare.ResumeLayout(false);
            this.pSquare.PerformLayout();
            this.pMatrixBSize.ResumeLayout(false);
            this.pMatrixBSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ComboBox cmbOperations;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutBasicMatrixCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem squareMatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixAdditionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matrixMultiplcationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transposeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem squareMatrixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem determinantToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel pMatrixSize;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.Button setAButton;
        private System.Windows.Forms.Label labelColumnA;
        private System.Windows.Forms.Label labelRowA;
        private System.Windows.Forms.GroupBox gbMatrixA;
        private System.Windows.Forms.DataGridView matrixA;
        private System.Windows.Forms.GroupBox gbMatrixB;
        private System.Windows.Forms.DataGridView matrixB;
        public System.Windows.Forms.NumericUpDown setAColumn;
        public System.Windows.Forms.NumericUpDown setARow;
        private System.Windows.Forms.Panel pSquare;
        private System.Windows.Forms.Button btnSetSquareMatrix;
        public System.Windows.Forms.NumericUpDown setSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pMatrixBSize;
        public System.Windows.Forms.NumericUpDown setBColumn;
        private System.Windows.Forms.Button SetBButton;
        public System.Windows.Forms.NumericUpDown setBRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClearA;
        private System.Windows.Forms.Button btnClearB;
        private System.Windows.Forms.Button btnFillZero;
    }
}

