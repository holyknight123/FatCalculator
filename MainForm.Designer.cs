namespace FatCalculator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTotalWeight = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbWaistLine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBMI = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbBMI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBFR = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbBFR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbStandardWeight = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbStandardWeightPercent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBMI.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBFR.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(171, 81);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 33);
            this.cbSex.TabIndex = 0;
            this.cbSex.SelectedIndexChanged += new System.EventHandler(this.cbSex_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "性别";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "总体重";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 33);
            this.label4.TabIndex = 4;
            this.label4.Text = "身高";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbTotalWeight
            // 
            this.tbTotalWeight.Location = new System.Drawing.Point(171, 141);
            this.tbTotalWeight.Name = "tbTotalWeight";
            this.tbTotalWeight.Size = new System.Drawing.Size(121, 31);
            this.tbTotalWeight.TabIndex = 5;
            this.tbTotalWeight.TextChanged += new System.EventHandler(this.tbTotalWeight_TextChanged);
            // 
            // tbHeight
            // 
            this.tbHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHeight.Location = new System.Drawing.Point(163, 44);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(419, 31);
            this.tbHeight.TabIndex = 7;
            this.tbHeight.TextChanged += new System.EventHandler(this.tbHeight_TextChanged);
            // 
            // tbWaistLine
            // 
            this.tbWaistLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbWaistLine.Location = new System.Drawing.Point(159, 42);
            this.tbWaistLine.Name = "tbWaistLine";
            this.tbWaistLine.Size = new System.Drawing.Size(433, 31);
            this.tbWaistLine.TabIndex = 9;
            this.tbWaistLine.TextChanged += new System.EventHandler(this.tbWaistLine_TextChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 33);
            this.label5.TabIndex = 8;
            this.label5.Text = "腰围";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBMI
            // 
            this.groupBMI.Controls.Add(this.label15);
            this.groupBMI.Controls.Add(this.label13);
            this.groupBMI.Controls.Add(this.tbStandardWeightPercent);
            this.groupBMI.Controls.Add(this.label14);
            this.groupBMI.Controls.Add(this.tbStandardWeight);
            this.groupBMI.Controls.Add(this.label12);
            this.groupBMI.Controls.Add(this.label11);
            this.groupBMI.Controls.Add(this.tbBMI);
            this.groupBMI.Controls.Add(this.label9);
            this.groupBMI.Controls.Add(this.label7);
            this.groupBMI.Controls.Add(this.tbHeight);
            this.groupBMI.Controls.Add(this.label4);
            this.groupBMI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBMI.Location = new System.Drawing.Point(0, 0);
            this.groupBMI.Name = "groupBMI";
            this.groupBMI.Size = new System.Drawing.Size(728, 487);
            this.groupBMI.TabIndex = 10;
            this.groupBMI.TabStop = false;
            this.groupBMI.Text = "身体质量指数BMI";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(593, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 25);
            this.label11.TabIndex = 17;
            this.label11.Text = "%";
            // 
            // tbBMI
            // 
            this.tbBMI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBMI.Location = new System.Drawing.Point(163, 97);
            this.tbBMI.Name = "tbBMI";
            this.tbBMI.Size = new System.Drawing.Size(419, 31);
            this.tbBMI.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 33);
            this.label9.TabIndex = 15;
            this.label9.Text = "BMI指数";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(593, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "厘米CM";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 220);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBFR);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBMI);
            this.splitContainer1.Size = new System.Drawing.Size(1432, 487);
            this.splitContainer1.SplitterDistance = 700;
            this.splitContainer1.TabIndex = 11;
            // 
            // groupBFR
            // 
            this.groupBFR.Controls.Add(this.label10);
            this.groupBFR.Controls.Add(this.tbBFR);
            this.groupBFR.Controls.Add(this.label8);
            this.groupBFR.Controls.Add(this.label6);
            this.groupBFR.Controls.Add(this.tbWaistLine);
            this.groupBFR.Controls.Add(this.label5);
            this.groupBFR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBFR.Location = new System.Drawing.Point(0, 0);
            this.groupBFR.Name = "groupBFR";
            this.groupBFR.Size = new System.Drawing.Size(700, 487);
            this.groupBFR.TabIndex = 0;
            this.groupBFR.TabStop = false;
            this.groupBFR.Text = "体脂率BFR";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 101);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 25);
            this.label10.TabIndex = 16;
            this.label10.Text = "%";
            // 
            // tbBFR
            // 
            this.tbBFR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbBFR.Location = new System.Drawing.Point(159, 97);
            this.tbBFR.Name = "tbBFR";
            this.tbBFR.Size = new System.Drawing.Size(433, 31);
            this.tbBFR.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 33);
            this.label8.TabIndex = 14;
            this.label8.Text = "体脂率BFR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(598, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "厘米CM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "公斤/千克KG";
            // 
            // tbStandardWeight
            // 
            this.tbStandardWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStandardWeight.Location = new System.Drawing.Point(163, 148);
            this.tbStandardWeight.Name = "tbStandardWeight";
            this.tbStandardWeight.Size = new System.Drawing.Size(419, 31);
            this.tbStandardWeight.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(17, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(140, 33);
            this.label12.TabIndex = 18;
            this.label12.Text = "标准体重";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(593, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 25);
            this.label13.TabIndex = 22;
            this.label13.Text = "%";
            // 
            // tbStandardWeightPercent
            // 
            this.tbStandardWeightPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbStandardWeightPercent.Location = new System.Drawing.Point(163, 203);
            this.tbStandardWeightPercent.Name = "tbStandardWeightPercent";
            this.tbStandardWeightPercent.Size = new System.Drawing.Size(419, 31);
            this.tbStandardWeightPercent.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(17, 201);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 33);
            this.label14.TabIndex = 20;
            this.label14.Text = "体重偏离";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(588, 154);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(132, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = "公斤/千克KG";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 789);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tbTotalWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSex);
            this.Name = "MainForm";
            this.Text = "脂肪计算器";
            this.groupBMI.ResumeLayout(false);
            this.groupBMI.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBFR.ResumeLayout(false);
            this.groupBFR.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTotalWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbWaistLine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBMI;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBFR;
        private System.Windows.Forms.TextBox tbBFR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBMI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbStandardWeightPercent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbStandardWeight;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
    }
}

