namespace Lab_3_4
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
            search_Button = new Button();
            textBoxResponse = new TextBox();
            companyCountry_TextBox = new TextBox();
            companyNip_TextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addToDatabase_Button = new Button();
            deleteFromDatabase_Button = new Button();
            showDataBase_Button = new Button();
            SuspendLayout();
            // 
            // search_Button
            // 
            search_Button.Font = new Font("Segoe UI", 12F);
            search_Button.Location = new Point(44, 222);
            search_Button.Name = "search_Button";
            search_Button.Size = new Size(169, 59);
            search_Button.TabIndex = 0;
            search_Button.Text = "SZUKAJ";
            search_Button.UseVisualStyleBackColor = true;
            search_Button.Click += buttonDownload_ClickAsync_Click;
            // 
            // textBoxResponse
            // 
            textBoxResponse.Font = new Font("Segoe UI", 10F);
            textBoxResponse.Location = new Point(546, 83);
            textBoxResponse.Multiline = true;
            textBoxResponse.Name = "textBoxResponse";
            textBoxResponse.ReadOnly = true;
            textBoxResponse.ScrollBars = ScrollBars.Vertical;
            textBoxResponse.Size = new Size(501, 397);
            textBoxResponse.TabIndex = 1;
            // 
            // companyCountry_TextBox
            // 
            companyCountry_TextBox.Font = new Font("Segoe UI", 10F);
            companyCountry_TextBox.Location = new Point(44, 53);
            companyCountry_TextBox.Name = "companyCountry_TextBox";
            companyCountry_TextBox.Size = new Size(169, 30);
            companyCountry_TextBox.TabIndex = 2;
            companyCountry_TextBox.TextChanged += companyCountry_TextBox_TextChanged;
            // 
            // companyNip_TextBox
            // 
            companyNip_TextBox.Font = new Font("Segoe UI", 10F);
            companyNip_TextBox.Location = new Point(44, 159);
            companyNip_TextBox.Name = "companyNip_TextBox";
            companyNip_TextBox.Size = new Size(169, 30);
            companyNip_TextBox.TabIndex = 3;
            companyNip_TextBox.TextChanged += companyNip_TextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(44, 15);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 4;
            label1.Text = "Kraj (skrót)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(44, 109);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 5;
            label2.Text = "NIP firmy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(546, 15);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 6;
            label3.Text = "Dane firmy";
            // 
            // addToDatabase_Button
            // 
            addToDatabase_Button.Font = new Font("Segoe UI", 12F);
            addToDatabase_Button.Location = new Point(44, 300);
            addToDatabase_Button.Name = "addToDatabase_Button";
            addToDatabase_Button.Size = new Size(169, 59);
            addToDatabase_Button.TabIndex = 7;
            addToDatabase_Button.Text = "DODAJ";
            addToDatabase_Button.UseVisualStyleBackColor = true;
            addToDatabase_Button.Click += addToDatabase_Button_Click;
            // 
            // deleteFromDatabase_Button
            // 
            deleteFromDatabase_Button.Font = new Font("Segoe UI", 12F);
            deleteFromDatabase_Button.Location = new Point(44, 377);
            deleteFromDatabase_Button.Name = "deleteFromDatabase_Button";
            deleteFromDatabase_Button.Size = new Size(169, 59);
            deleteFromDatabase_Button.TabIndex = 8;
            deleteFromDatabase_Button.Text = "USUŃ";
            deleteFromDatabase_Button.UseVisualStyleBackColor = true;
            deleteFromDatabase_Button.Click += deleteFromDatabase_Button_Click;
            // 
            // showDataBase_Button
            // 
            showDataBase_Button.Font = new Font("Segoe UI", 12F);
            showDataBase_Button.Location = new Point(292, 408);
            showDataBase_Button.Name = "showDataBase_Button";
            showDataBase_Button.Size = new Size(169, 72);
            showDataBase_Button.TabIndex = 9;
            showDataBase_Button.Text = "WYŚWIETL\r\nBAZĘ \r\nDANYCH";
            showDataBase_Button.UseVisualStyleBackColor = true;
            showDataBase_Button.Click += showDataBase_Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1094, 517);
            Controls.Add(showDataBase_Button);
            Controls.Add(deleteFromDatabase_Button);
            Controls.Add(addToDatabase_Button);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(companyNip_TextBox);
            Controls.Add(companyCountry_TextBox);
            Controls.Add(textBoxResponse);
            Controls.Add(search_Button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button search_Button;
        private TextBox textBoxResponse;
        private TextBox companyCountry_TextBox;
        private TextBox companyNip_TextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button addToDatabase_Button;
        private Button deleteFromDatabase_Button;
        private Button showDataBase_Button;
    }
}
