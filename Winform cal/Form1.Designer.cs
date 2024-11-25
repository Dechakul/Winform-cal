namespace Winform_cal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtRadius = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtHeight = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtWidth = new TextBox();
            btnCicleArea = new Button();
            label7 = new Label();
            txtHexagonWidth = new TextBox();
            btnTriangleArea = new Button();
            btnHexagonArea = new Button();
            label8 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DarkSeaGreen;
            label1.Location = new Point(39, 21);
            label1.Name = "label1";
            label1.Size = new Size(389, 98);
            label1.TabIndex = 0;
            label1.Text = "คำนวณหาพื้นที่วงกลม";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkSeaGreen;
            label2.Location = new Point(39, 71);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "รัศมี";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(130, 68);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(100, 23);
            txtRadius.TabIndex = 2;
            txtRadius.Text = "1";
            // 
            // label3
            // 
            label3.BackColor = Color.LightCoral;
            label3.Location = new Point(39, 138);
            label3.Name = "label3";
            label3.Size = new Size(389, 153);
            label3.TabIndex = 3;
            label3.Text = "คำนวณหาพื้นที่สามเหลี่ยม";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightCoral;
            label4.Location = new Point(39, 187);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 4;
            label4.Text = "ความสูง";
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(130, 184);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(100, 23);
            txtHeight.TabIndex = 5;
            txtHeight.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.LightCoral;
            label5.Location = new Point(39, 243);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 6;
            label5.Text = "ความยาวฐาน";
            // 
            // label6
            // 
            label6.BackColor = Color.NavajoWhite;
            label6.Location = new Point(39, 310);
            label6.Name = "label6";
            label6.Size = new Size(389, 122);
            label6.TabIndex = 7;
            label6.Text = "คำนวณหาพื้นที่หกเหลี่ยมด้านเท่า";
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(130, 240);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(100, 23);
            txtWidth.TabIndex = 8;
            txtWidth.Text = "1";
            // 
            // btnCicleArea
            // 
            btnCicleArea.Location = new Point(278, 68);
            btnCicleArea.Name = "btnCicleArea";
            btnCicleArea.Size = new Size(130, 23);
            btnCicleArea.TabIndex = 9;
            btnCicleArea.Text = "คำนวณพื้นที่วงกลม";
            btnCicleArea.UseVisualStyleBackColor = true;
            btnCicleArea.Click += btnCicleArea_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.NavajoWhite;
            label7.Location = new Point(39, 365);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 10;
            label7.Text = "ความยาวฐาน";
            // 
            // txtHexagonWidth
            // 
            txtHexagonWidth.Location = new Point(130, 365);
            txtHexagonWidth.Name = "txtHexagonWidth";
            txtHexagonWidth.Size = new Size(100, 23);
            txtHexagonWidth.TabIndex = 11;
            txtHexagonWidth.Text = "1";
            // 
            // btnTriangleArea
            // 
            btnTriangleArea.Location = new Point(278, 212);
            btnTriangleArea.Name = "btnTriangleArea";
            btnTriangleArea.Size = new Size(130, 23);
            btnTriangleArea.TabIndex = 12;
            btnTriangleArea.Text = "คำนวณพื้นที่สามเหลี่ยม";
            btnTriangleArea.UseVisualStyleBackColor = true;
            btnTriangleArea.Click += btnTriangleArea_Click;
            // 
            // btnHexagonArea
            // 
            btnHexagonArea.Location = new Point(278, 364);
            btnHexagonArea.Name = "btnHexagonArea";
            btnHexagonArea.Size = new Size(130, 23);
            btnHexagonArea.TabIndex = 13;
            btnHexagonArea.Text = "คำนวณพื้นที่หกเหลี่ยม";
            btnHexagonArea.UseVisualStyleBackColor = true;
            btnHexagonArea.Click += btnHexagonArea_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(573, 40);
            label8.Name = "label8";
            label8.Size = new Size(118, 17);
            label8.TabIndex = 14;
            label8.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.FromArgb(192, 255, 255);
            lblResult.BorderStyle = BorderStyle.FixedSingle;
            lblResult.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(573, 57);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(177, 111);
            lblResult.TabIndex = 15;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label8);
            Controls.Add(btnHexagonArea);
            Controls.Add(btnTriangleArea);
            Controls.Add(txtHexagonWidth);
            Controls.Add(label7);
            Controls.Add(btnCicleArea);
            Controls.Add(txtWidth);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtHeight);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtRadius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRadius;
        private Label label3;
        private Label label4;
        private TextBox txtHeight;
        private Label label5;
        private Label label6;
        private TextBox txtWidth;
        private Button btnCicleArea;
        private Label label7;
        private TextBox txtHexagonWidth;
        private Button btnTriangleArea;
        private Button btnHexagonArea;
        private Label label8;
        private Label lblResult;
    }
}
