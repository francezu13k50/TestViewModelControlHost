
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
            this.viewModelControlHost1 = new ReactiveUI.Winforms.ViewModelControlHost();
            this.btnSelectView1 = new System.Windows.Forms.Button();
            this.btnSelectView2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewModelControlHost1
            // 
            this.viewModelControlHost1.CacheViews = false;
            this.viewModelControlHost1.DefaultContent = null;
            this.viewModelControlHost1.Location = new System.Drawing.Point(40, 25);
            this.viewModelControlHost1.Name = "viewModelControlHost1";
            this.viewModelControlHost1.Size = new System.Drawing.Size(402, 277);
            this.viewModelControlHost1.TabIndex = 0;
            this.viewModelControlHost1.ViewLocator = null;
            this.viewModelControlHost1.ViewModel = null;
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
            // ShellView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 361);
            this.Controls.Add(this.btnSelectView2);
            this.Controls.Add(this.btnSelectView1);
            this.Controls.Add(this.viewModelControlHost1);
            this.Name = "ShellView";
            this.Text = "Shell";
            this.ResumeLayout(false);

        }

        #endregion

        private ReactiveUI.Winforms.ViewModelControlHost viewModelControlHost1;
        private System.Windows.Forms.Button btnSelectView1;
        private System.Windows.Forms.Button btnSelectView2;
    }
}

