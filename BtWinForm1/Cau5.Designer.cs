namespace BtWinForm1
{
    partial class Cau5
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbSo1 = new System.Windows.Forms.Label();
            this.lbSo2 = new System.Windows.Forms.Label();
            this.lbSo3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btQuaySo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.rd11 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đoán số ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSo1
            // 
            this.lbSo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo1.Location = new System.Drawing.Point(162, 84);
            this.lbSo1.Name = "lbSo1";
            this.lbSo1.Size = new System.Drawing.Size(136, 148);
            this.lbSo1.TabIndex = 1;
            // 
            // lbSo2
            // 
            this.lbSo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo2.Location = new System.Drawing.Point(339, 84);
            this.lbSo2.Name = "lbSo2";
            this.lbSo2.Size = new System.Drawing.Size(136, 148);
            this.lbSo2.TabIndex = 1;
            // 
            // lbSo3
            // 
            this.lbSo3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSo3.Location = new System.Drawing.Point(509, 84);
            this.lbSo3.Name = "lbSo3";
            this.lbSo3.Size = new System.Drawing.Size(136, 148);
            this.lbSo3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd11);
            this.groupBox1.Controls.Add(this.rd3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(65, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 89);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn :";
            // 
            // btQuaySo
            // 
            this.btQuaySo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btQuaySo.Location = new System.Drawing.Point(54, 421);
            this.btQuaySo.Name = "btQuaySo";
            this.btQuaySo.Size = new System.Drawing.Size(215, 61);
            this.btQuaySo.TabIndex = 3;
            this.btQuaySo.Text = "Quay Số";
            this.btQuaySo.UseVisualStyleBackColor = true;
            this.btQuaySo.Click += new System.EventHandler(this.btQuaySo_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(411, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 80);
            this.label2.TabIndex = 4;
            this.label2.Text = "ĐIỂM :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDiem
            // 
            this.lbDiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbDiem.Location = new System.Drawing.Point(580, 377);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(167, 152);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rd3
            // 
            this.rd3.AutoSize = true;
            this.rd3.Location = new System.Drawing.Point(152, 26);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(231, 43);
            this.rd3.TabIndex = 0;
            this.rd3.TabStop = true;
            this.rd3.Text = "radioButton1";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // rd11
            // 
            this.rd11.AutoSize = true;
            this.rd11.Location = new System.Drawing.Point(389, 26);
            this.rd11.Name = "rd11";
            this.rd11.Size = new System.Drawing.Size(231, 43);
            this.rd11.TabIndex = 0;
            this.rd11.TabStop = true;
            this.rd11.Text = "radioButton1";
            this.rd11.UseVisualStyleBackColor = true;
            // 
            // Cau5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btQuaySo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbSo3);
            this.Controls.Add(this.lbSo2);
            this.Controls.Add(this.lbSo1);
            this.Controls.Add(this.label1);
            this.Name = "Cau5";
            this.Text = "Cau5";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSo1;
        private System.Windows.Forms.Label lbSo2;
        private System.Windows.Forms.Label lbSo3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btQuaySo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDiem;
        private System.Windows.Forms.RadioButton rd11;
        private System.Windows.Forms.RadioButton rd3;
    }
}