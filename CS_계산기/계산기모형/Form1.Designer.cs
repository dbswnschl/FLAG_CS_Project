namespace 계산기모형
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Text_main = new System.Windows.Forms.TextBox();
            this.Btn_1 = new System.Windows.Forms.Button();
            this.Btn_2 = new System.Windows.Forms.Button();
            this.Btn_3 = new System.Windows.Forms.Button();
            this.Btn_5 = new System.Windows.Forms.Button();
            this.Btn_6 = new System.Windows.Forms.Button();
            this.Btn_7 = new System.Windows.Forms.Button();
            this.Btn_8 = new System.Windows.Forms.Button();
            this.Btn_9 = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.Btn_0 = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Btn_divide = new System.Windows.Forms.Button();
            this.Btn_multi = new System.Windows.Forms.Button();
            this.Btn_minus = new System.Windows.Forms.Button();
            this.Btn_plus = new System.Windows.Forms.Button();
            this.Btn_result = new System.Windows.Forms.Button();
            this.Btn_4 = new System.Windows.Forms.Button();
            this.Btn_dot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_main
            // 
            this.Text_main.Font = new System.Drawing.Font("돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Text_main.Location = new System.Drawing.Point(12, 12);
            this.Text_main.Name = "Text_main";
            this.Text_main.ReadOnly = true;
            this.Text_main.Size = new System.Drawing.Size(224, 29);
            this.Text_main.TabIndex = 0;
            this.Text_main.Text = "0";
            this.Text_main.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Btn_1
            // 
            this.Btn_1.Location = new System.Drawing.Point(12, 209);
            this.Btn_1.Name = "Btn_1";
            this.Btn_1.Size = new System.Drawing.Size(40, 40);
            this.Btn_1.TabIndex = 2;
            this.Btn_1.Text = "1";
            this.Btn_1.UseVisualStyleBackColor = true;
            this.Btn_1.Click += new System.EventHandler(this.Btn_1_Click);
            // 
            // Btn_2
            // 
            this.Btn_2.Location = new System.Drawing.Point(58, 209);
            this.Btn_2.Name = "Btn_2";
            this.Btn_2.Size = new System.Drawing.Size(40, 40);
            this.Btn_2.TabIndex = 3;
            this.Btn_2.Text = "2";
            this.Btn_2.UseVisualStyleBackColor = true;
            this.Btn_2.Click += new System.EventHandler(this.Btn_2_Click);
            // 
            // Btn_3
            // 
            this.Btn_3.Location = new System.Drawing.Point(104, 209);
            this.Btn_3.Name = "Btn_3";
            this.Btn_3.Size = new System.Drawing.Size(40, 40);
            this.Btn_3.TabIndex = 4;
            this.Btn_3.Text = "3";
            this.Btn_3.UseVisualStyleBackColor = true;
            this.Btn_3.Click += new System.EventHandler(this.Btn_3_Click);
            // 
            // Btn_5
            // 
            this.Btn_5.Location = new System.Drawing.Point(58, 163);
            this.Btn_5.Name = "Btn_5";
            this.Btn_5.Size = new System.Drawing.Size(40, 40);
            this.Btn_5.TabIndex = 5;
            this.Btn_5.Text = "5";
            this.Btn_5.UseVisualStyleBackColor = true;
            this.Btn_5.Click += new System.EventHandler(this.Btn_5_Click);
            // 
            // Btn_6
            // 
            this.Btn_6.Location = new System.Drawing.Point(104, 163);
            this.Btn_6.Name = "Btn_6";
            this.Btn_6.Size = new System.Drawing.Size(40, 40);
            this.Btn_6.TabIndex = 7;
            this.Btn_6.Text = "6";
            this.Btn_6.UseVisualStyleBackColor = true;
            this.Btn_6.Click += new System.EventHandler(this.Btn_6_Click);
            // 
            // Btn_7
            // 
            this.Btn_7.Location = new System.Drawing.Point(12, 117);
            this.Btn_7.Name = "Btn_7";
            this.Btn_7.Size = new System.Drawing.Size(40, 40);
            this.Btn_7.TabIndex = 8;
            this.Btn_7.Text = "7";
            this.Btn_7.UseVisualStyleBackColor = true;
            this.Btn_7.Click += new System.EventHandler(this.Btn_7_Click);
            // 
            // Btn_8
            // 
            this.Btn_8.Location = new System.Drawing.Point(58, 117);
            this.Btn_8.Name = "Btn_8";
            this.Btn_8.Size = new System.Drawing.Size(40, 40);
            this.Btn_8.TabIndex = 9;
            this.Btn_8.Text = "8";
            this.Btn_8.UseVisualStyleBackColor = true;
            this.Btn_8.Click += new System.EventHandler(this.Btn_8_Click);
            // 
            // Btn_9
            // 
            this.Btn_9.Location = new System.Drawing.Point(104, 117);
            this.Btn_9.Name = "Btn_9";
            this.Btn_9.Size = new System.Drawing.Size(40, 40);
            this.Btn_9.TabIndex = 10;
            this.Btn_9.Text = "9";
            this.Btn_9.UseVisualStyleBackColor = true;
            this.Btn_9.Click += new System.EventHandler(this.Btn_9_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(12, 71);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(40, 40);
            this.Btn_back.TabIndex = 11;
            this.Btn_back.Text = "←";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // Btn_0
            // 
            this.Btn_0.Location = new System.Drawing.Point(58, 71);
            this.Btn_0.Name = "Btn_0";
            this.Btn_0.Size = new System.Drawing.Size(40, 40);
            this.Btn_0.TabIndex = 12;
            this.Btn_0.Text = "0";
            this.Btn_0.UseVisualStyleBackColor = true;
            this.Btn_0.Click += new System.EventHandler(this.Btn_0_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Location = new System.Drawing.Point(104, 71);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(40, 40);
            this.Btn_reset.TabIndex = 13;
            this.Btn_reset.Text = "C";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Btn_divide
            // 
            this.Btn_divide.Location = new System.Drawing.Point(150, 209);
            this.Btn_divide.Name = "Btn_divide";
            this.Btn_divide.Size = new System.Drawing.Size(40, 40);
            this.Btn_divide.TabIndex = 14;
            this.Btn_divide.Text = "/";
            this.Btn_divide.UseVisualStyleBackColor = true;
            this.Btn_divide.Click += new System.EventHandler(this.Btn_divide_Click);
            // 
            // Btn_multi
            // 
            this.Btn_multi.Location = new System.Drawing.Point(150, 163);
            this.Btn_multi.Name = "Btn_multi";
            this.Btn_multi.Size = new System.Drawing.Size(40, 40);
            this.Btn_multi.TabIndex = 15;
            this.Btn_multi.Text = "*";
            this.Btn_multi.UseVisualStyleBackColor = true;
            this.Btn_multi.Click += new System.EventHandler(this.Btn_multi_Click);
            // 
            // Btn_minus
            // 
            this.Btn_minus.Location = new System.Drawing.Point(150, 117);
            this.Btn_minus.Name = "Btn_minus";
            this.Btn_minus.Size = new System.Drawing.Size(40, 40);
            this.Btn_minus.TabIndex = 16;
            this.Btn_minus.Text = "-";
            this.Btn_minus.UseVisualStyleBackColor = true;
            this.Btn_minus.Click += new System.EventHandler(this.Btn_minus_Click);
            // 
            // Btn_plus
            // 
            this.Btn_plus.Location = new System.Drawing.Point(150, 71);
            this.Btn_plus.Name = "Btn_plus";
            this.Btn_plus.Size = new System.Drawing.Size(40, 40);
            this.Btn_plus.TabIndex = 17;
            this.Btn_plus.Text = "+";
            this.Btn_plus.UseVisualStyleBackColor = true;
            this.Btn_plus.Click += new System.EventHandler(this.Btn_plus_Click);
            // 
            // Btn_result
            // 
            this.Btn_result.Location = new System.Drawing.Point(196, 163);
            this.Btn_result.Name = "Btn_result";
            this.Btn_result.Size = new System.Drawing.Size(40, 86);
            this.Btn_result.TabIndex = 18;
            this.Btn_result.Text = "=";
            this.Btn_result.UseVisualStyleBackColor = true;
            this.Btn_result.Click += new System.EventHandler(this.Btn_result_Click);
            // 
            // Btn_4
            // 
            this.Btn_4.Location = new System.Drawing.Point(12, 163);
            this.Btn_4.Name = "Btn_4";
            this.Btn_4.Size = new System.Drawing.Size(40, 40);
            this.Btn_4.TabIndex = 19;
            this.Btn_4.Text = "4";
            this.Btn_4.UseVisualStyleBackColor = true;
            this.Btn_4.Click += new System.EventHandler(this.Btn_4_Click);
            // 
            // Btn_dot
            // 
            this.Btn_dot.Location = new System.Drawing.Point(196, 71);
            this.Btn_dot.Name = "Btn_dot";
            this.Btn_dot.Size = new System.Drawing.Size(40, 40);
            this.Btn_dot.TabIndex = 20;
            this.Btn_dot.Text = ".";
            this.Btn_dot.UseVisualStyleBackColor = true;
            this.Btn_dot.Click += new System.EventHandler(this.Btn_dot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 261);
            this.Controls.Add(this.Btn_dot);
            this.Controls.Add(this.Btn_4);
            this.Controls.Add(this.Btn_result);
            this.Controls.Add(this.Btn_plus);
            this.Controls.Add(this.Btn_minus);
            this.Controls.Add(this.Btn_multi);
            this.Controls.Add(this.Btn_divide);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_0);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_9);
            this.Controls.Add(this.Btn_8);
            this.Controls.Add(this.Btn_7);
            this.Controls.Add(this.Btn_6);
            this.Controls.Add(this.Btn_5);
            this.Controls.Add(this.Btn_3);
            this.Controls.Add(this.Btn_2);
            this.Controls.Add(this.Btn_1);
            this.Controls.Add(this.Text_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "계산기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Text_main;
        private System.Windows.Forms.Button Btn_1;
        private System.Windows.Forms.Button Btn_2;
        private System.Windows.Forms.Button Btn_3;
        private System.Windows.Forms.Button Btn_5;
        private System.Windows.Forms.Button Btn_6;
        private System.Windows.Forms.Button Btn_7;
        private System.Windows.Forms.Button Btn_8;
        private System.Windows.Forms.Button Btn_9;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button Btn_0;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Button Btn_divide;
        private System.Windows.Forms.Button Btn_multi;
        private System.Windows.Forms.Button Btn_minus;
        private System.Windows.Forms.Button Btn_plus;
        private System.Windows.Forms.Button Btn_result;
        private System.Windows.Forms.Button Btn_4;
        private System.Windows.Forms.Button Btn_dot;
    }
}

