
namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button_w = new System.Windows.Forms.Button();
            this.button_s = new System.Windows.Forms.Button();
            this.button_k = new System.Windows.Forms.Button();
            this.button_i = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(787, 439);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(336, 447);
            this.button_start.Margin = new System.Windows.Forms.Padding(2);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(103, 26);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button_w
            // 
            this.button_w.Location = new System.Drawing.Point(12, 447);
            this.button_w.Name = "button_w";
            this.button_w.Size = new System.Drawing.Size(75, 23);
            this.button_w.TabIndex = 2;
            this.button_w.Text = "w";
            this.button_w.UseVisualStyleBackColor = true;
            this.button_w.Click += new System.EventHandler(this.button_w_Click);
            // 
            // button_s
            // 
            this.button_s.Location = new System.Drawing.Point(12, 476);
            this.button_s.Name = "button_s";
            this.button_s.Size = new System.Drawing.Size(75, 23);
            this.button_s.TabIndex = 3;
            this.button_s.Text = "s";
            this.button_s.UseVisualStyleBackColor = true;
            this.button_s.Click += new System.EventHandler(this.button_s_Click);
            // 
            // button_k
            // 
            this.button_k.Location = new System.Drawing.Point(716, 476);
            this.button_k.Name = "button_k";
            this.button_k.Size = new System.Drawing.Size(75, 23);
            this.button_k.TabIndex = 5;
            this.button_k.Text = "k";
            this.button_k.UseVisualStyleBackColor = true;
            this.button_k.Click += new System.EventHandler(this.button_k_Click);
            // 
            // button_i
            // 
            this.button_i.Location = new System.Drawing.Point(716, 447);
            this.button_i.Name = "button_i";
            this.button_i.Size = new System.Drawing.Size(75, 23);
            this.button_i.TabIndex = 4;
            this.button_i.Text = "i";
            this.button_i.UseVisualStyleBackColor = true;
            this.button_i.Click += new System.EventHandler(this.button_i_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 499);
            this.Controls.Add(this.button_k);
            this.Controls.Add(this.button_i);
            this.Controls.Add(this.button_s);
            this.Controls.Add(this.button_w);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button_w;
        private System.Windows.Forms.Button button_s;
        private System.Windows.Forms.Button button_k;
        private System.Windows.Forms.Button button_i;
    }
}

