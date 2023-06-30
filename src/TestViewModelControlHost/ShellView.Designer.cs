
namespace TestViewModelControlHost
{
    partial class ShellView
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
            this.btnSelectView1 = new System.Windows.Forms.Button();
            this.btnSelectView2 = new System.Windows.Forms.Button();
            this.cachedControlHost1 = new TestViewModelControlHost.CachedControlHost();
            this.btnSelectNullView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSelectView1
            // 
            this.btnSelectView1.Location = new System.Drawing.Point(129, 325);
            this.btnSelectView1.Name = "btnSelectView1";
            this.btnSelectView1.Size = new System.Drawing.Size(75, 23);
            this.btnSelectView1.TabIndex = 1;
            this.btnSelectView1.Text = "View 1";
            this.btnSelectView1.UseVisualStyleBackColor = true;
            // 
            // btnSelectView2
            // 
            this.btnSelectView2.Location = new System.Drawing.Point(253, 325);
            this.btnSelectView2.Name = "btnSelectView2";
            this.btnSelectView2.Size = new System.Drawing.Size(75, 23);
            this.btnSelectView2.TabIndex = 2;
            this.btnSelectView2.Text = "View 2";
            this.btnSelectView2.UseVisualStyleBackColor = true;
            // 
            // cachedControlHost1
            // 
            this.cachedControlHost1.Location = new System.Drawing.Point(12, 12);
            this.cachedControlHost1.Name = "cachedControlHost1";
            this.cachedControlHost1.Size = new System.Drawing.Size(457, 291);
            this.cachedControlHost1.TabIndex = 3;
            this.cachedControlHost1.ViewModel = null;
            // 
            // btnSelectNullView
            // 
            this.btnSelectNullView.Location = new System.Drawing.Point(379, 325);
            this.btnSelectNullView.Name = "btnSelectNullView";
            this.btnSelectNullView.Size = new System.Drawing.Size(75, 23);
            this.btnSelectNullView.TabIndex = 4;
            this.btnSelectNullView.Text = "Null View";
            this.btnSelectNullView.UseVisualStyleBackColor = true;
            // 
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 361);
            this.Controls.Add(this.btnSelectNullView);
            this.Controls.Add(this.cachedControlHost1);
            this.Controls.Add(this.btnSelectView2);
            this.Controls.Add(this.btnSelectView1);
            this.Name = "ShellView";
            this.Text = "Shell";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSelectView1;
        private System.Windows.Forms.Button btnSelectView2;
        private CachedControlHost cachedControlHost1;
        private System.Windows.Forms.Button btnSelectNullView;
    }
}

