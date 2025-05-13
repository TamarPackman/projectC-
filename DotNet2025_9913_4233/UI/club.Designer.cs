namespace UI
{
    partial class club
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
            fevoriteCustomer = new CheckBox();
            idCard = new Label();
            inputidCard = new TextBox();
            insert = new Button();
            SuspendLayout();
            // 
            // fevoriteCustomer
            // 
            fevoriteCustomer.AutoSize = true;
            fevoriteCustomer.Location = new Point(103, 67);
            fevoriteCustomer.Name = "fevoriteCustomer";
            fevoriteCustomer.Size = new Size(145, 19);
            fevoriteCustomer.TabIndex = 0;
            fevoriteCustomer.Text = "?האם אתה לקוח מועדון";
            fevoriteCustomer.UseVisualStyleBackColor = true;
            fevoriteCustomer.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // idCard
            // 
            idCard.AutoSize = true;
            idCard.Location = new Point(150, 123);
            idCard.Name = "idCard";
            idCard.Size = new Size(136, 15);
            idCard.TabIndex = 1;
            idCard.Text = ":הכנס מספר תעודת זהות";
            // 
            // inputidCard
            // 
            inputidCard.Location = new Point(42, 119);
            inputidCard.Name = "inputidCard";
            inputidCard.Size = new Size(100, 23);
            inputidCard.TabIndex = 2;
            // 
            // insert
            // 
            insert.Location = new Point(121, 160);
            insert.Name = "insert";
            insert.Size = new Size(75, 23);
            insert.TabIndex = 3;
            insert.Text = "הכנס";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // club
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 269);
            Controls.Add(insert);
            Controls.Add(inputidCard);
            Controls.Add(idCard);
            Controls.Add(fevoriteCustomer);
            Name = "club";
            Text = "club";
            Load += club_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox fevoriteCustomer;
        private Label idCard;
        private TextBox inputidCard;
        private Button insert;
    }
}