namespace UI
{
    partial class menu
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
            cashier = new Button();
            manager = new Button();
            SuspendLayout();
            // 
            // cashier
            // 
            cashier.Location = new Point(425, 157);
            cashier.Name = "cashier";
            cashier.Size = new Size(160, 89);
            cashier.TabIndex = 0;
            cashier.Text = "קופאי";
            cashier.UseVisualStyleBackColor = true;
            cashier.Click += cashier_Click;
            // 
            // manager
            // 
            manager.Location = new Point(188, 157);
            manager.Name = "manager";
            manager.Size = new Size(149, 89);
            manager.TabIndex = 1;
            manager.Text = "מנהל";
            manager.UseVisualStyleBackColor = true;
            manager.Click += manager_Click;
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(manager);
            Controls.Add(cashier);
            Name = "menu";
            Text = "menu";
            ResumeLayout(false);
        }

        #endregion

        private Button cashier;
        private Button manager;
    }
}