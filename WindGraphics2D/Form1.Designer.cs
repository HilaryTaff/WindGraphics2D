namespace WindGraphics2D
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.txtboxTranslationX = new System.Windows.Forms.TextBox();
            this.txtboxRotationOrigin = new System.Windows.Forms.TextBox();
            this.txtBoxRotationX = new System.Windows.Forms.TextBox();
            this.txtboxTranslationY = new System.Windows.Forms.TextBox();
            this.txtboxRotationAngle = new System.Windows.Forms.TextBox();
            this.txtboxRotationY = new System.Windows.Forms.TextBox();
            this.txtboxScalingX = new System.Windows.Forms.TextBox();
            this.txtboxScalingY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTransformation = new System.Windows.Forms.Button();
            this.lblTransformations = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 462);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(471, 668);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Location = new System.Drawing.Point(513, 328);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1384, 802);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 299);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Polygon";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(295, 297);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(200, 40);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Translation",
            "Rotation about Origin",
            "Rotation about Point ",
            "Scaling"});
            this.checkedListBox1.Location = new System.Drawing.Point(35, 95);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(471, 179);
            this.checkedListBox1.TabIndex = 4;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // btnPolygon
            // 
            this.btnPolygon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.btnPolygon.Location = new System.Drawing.Point(24, 352);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(471, 93);
            this.btnPolygon.TabIndex = 6;
            this.btnPolygon.Text = "Plot";
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // txtboxTranslationX
            // 
            this.txtboxTranslationX.Location = new System.Drawing.Point(852, 106);
            this.txtboxTranslationX.Name = "txtboxTranslationX";
            this.txtboxTranslationX.Size = new System.Drawing.Size(100, 31);
            this.txtboxTranslationX.TabIndex = 7;
            this.txtboxTranslationX.Text = "50";
            // 
            // txtboxRotationOrigin
            // 
            this.txtboxRotationOrigin.Location = new System.Drawing.Point(852, 160);
            this.txtboxRotationOrigin.Name = "txtboxRotationOrigin";
            this.txtboxRotationOrigin.Size = new System.Drawing.Size(100, 31);
            this.txtboxRotationOrigin.TabIndex = 8;
            this.txtboxRotationOrigin.Text = "30";
            // 
            // txtBoxRotationX
            // 
            this.txtBoxRotationX.Location = new System.Drawing.Point(852, 221);
            this.txtBoxRotationX.Name = "txtBoxRotationX";
            this.txtBoxRotationX.Size = new System.Drawing.Size(100, 31);
            this.txtBoxRotationX.TabIndex = 9;
            this.txtBoxRotationX.Text = "100";
            // 
            // txtboxTranslationY
            // 
            this.txtboxTranslationY.Location = new System.Drawing.Point(978, 106);
            this.txtboxTranslationY.Name = "txtboxTranslationY";
            this.txtboxTranslationY.Size = new System.Drawing.Size(100, 31);
            this.txtboxTranslationY.TabIndex = 7;
            this.txtboxTranslationY.Text = "30";
            // 
            // txtboxRotationAngle
            // 
            this.txtboxRotationAngle.Location = new System.Drawing.Point(1101, 221);
            this.txtboxRotationAngle.Name = "txtboxRotationAngle";
            this.txtboxRotationAngle.Size = new System.Drawing.Size(100, 31);
            this.txtboxRotationAngle.TabIndex = 8;
            this.txtboxRotationAngle.Text = "30";
            // 
            // txtboxRotationY
            // 
            this.txtboxRotationY.Location = new System.Drawing.Point(978, 221);
            this.txtboxRotationY.Name = "txtboxRotationY";
            this.txtboxRotationY.Size = new System.Drawing.Size(100, 31);
            this.txtboxRotationY.TabIndex = 9;
            this.txtboxRotationY.Text = "90";
            // 
            // txtboxScalingX
            // 
            this.txtboxScalingX.Location = new System.Drawing.Point(852, 276);
            this.txtboxScalingX.Name = "txtboxScalingX";
            this.txtboxScalingX.Size = new System.Drawing.Size(100, 31);
            this.txtboxScalingX.TabIndex = 9;
            this.txtboxScalingX.Text = "0.5";
            // 
            // txtboxScalingY
            // 
            this.txtboxScalingY.Location = new System.Drawing.Point(978, 278);
            this.txtboxScalingY.Name = "txtboxScalingY";
            this.txtboxScalingY.Size = new System.Drawing.Size(100, 31);
            this.txtboxScalingY.TabIndex = 9;
            this.txtboxScalingY.Text = "0.5";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label12.Location = new System.Drawing.Point(851, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 33);
            this.label12.TabIndex = 10;
            this.label12.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label3.Location = new System.Drawing.Point(1112, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 33);
            this.label3.TabIndex = 10;
            this.label3.Text = "Angle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label4.Location = new System.Drawing.Point(539, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 33);
            this.label4.TabIndex = 10;
            this.label4.Text = "Translation";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label6.Location = new System.Drawing.Point(539, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 33);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rotation About Origin";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label7.Location = new System.Drawing.Point(539, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(277, 33);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rotation about Point";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label8.Location = new System.Drawing.Point(540, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 33);
            this.label8.TabIndex = 10;
            this.label8.Text = "Scaling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.label5.Location = new System.Drawing.Point(972, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y";
            // 
            // btnTransformation
            // 
            this.btnTransformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F);
            this.btnTransformation.Location = new System.Drawing.Point(1305, 256);
            this.btnTransformation.Name = "btnTransformation";
            this.btnTransformation.Size = new System.Drawing.Size(592, 60);
            this.btnTransformation.TabIndex = 11;
            this.btnTransformation.Text = "Transform";
            this.btnTransformation.UseVisualStyleBackColor = true;
            this.btnTransformation.Click += new System.EventHandler(this.btnTransformation_Click);
            // 
            // lblTransformations
            // 
            this.lblTransformations.AutoSize = true;
            this.lblTransformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransformations.Location = new System.Drawing.Point(35, 13);
            this.lblTransformations.Name = "lblTransformations";
            this.lblTransformations.Size = new System.Drawing.Size(0, 31);
            this.lblTransformations.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1921, 1143);
            this.Controls.Add(this.lblTransformations);
            this.Controls.Add(this.btnTransformation);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtboxRotationY);
            this.Controls.Add(this.txtboxScalingY);
            this.Controls.Add(this.txtboxScalingX);
            this.Controls.Add(this.txtBoxRotationX);
            this.Controls.Add(this.txtboxRotationAngle);
            this.Controls.Add(this.txtboxTranslationY);
            this.Controls.Add(this.txtboxRotationOrigin);
            this.Controls.Add(this.txtboxTranslationX);
            this.Controls.Add(this.btnPolygon);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.TextBox txtboxTranslationX;
        private System.Windows.Forms.TextBox txtboxRotationOrigin;
        private System.Windows.Forms.TextBox txtBoxRotationX;
        private System.Windows.Forms.TextBox txtboxTranslationY;
        private System.Windows.Forms.TextBox txtboxRotationAngle;
        private System.Windows.Forms.TextBox txtboxRotationY;
        private System.Windows.Forms.TextBox txtboxScalingX;
        private System.Windows.Forms.TextBox txtboxScalingY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTransformation;
        private System.Windows.Forms.Label lblTransformations;
    }
}

