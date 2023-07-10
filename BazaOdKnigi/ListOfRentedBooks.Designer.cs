namespace BazaOdKnigi
{
    partial class ListOfRentedBooks
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
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listBox1);
            groupBox1.Location = new Point(19, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(291, 319);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "List of rented books";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(7, 19);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(278, 289);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(19, 404);
            button1.Name = "button1";
            button1.Size = new Size(291, 34);
            button1.TabIndex = 1;
            button1.Text = "Close";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(19, 365);
            button2.Name = "button2";
            button2.Size = new Size(292, 33);
            button2.TabIndex = 2;
            button2.Text = "Return book";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ListOfRentedBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Name = "ListOfRentedBooks";
            Text = "Form4";
            Load += ListOfRentedBooks_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
    }
}