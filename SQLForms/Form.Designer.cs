namespace SQLForms
{
    partial class Form
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
            btnGo = new Button();
            tbQuery = new TextBox();
            label1 = new Label();
            lbQueryResult = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // btnGo
            // 
            btnGo.Location = new Point(651, 259);
            btnGo.Name = "btnGo";
            btnGo.Size = new Size(75, 23);
            btnGo.TabIndex = 0;
            btnGo.Text = "Go";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += btnGo_Click;
            // 
            // tbQuery
            // 
            tbQuery.Location = new Point(634, 201);
            tbQuery.Name = "tbQuery";
            tbQuery.Size = new Size(154, 23);
            tbQuery.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(593, 204);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 2;
            label1.Text = "ID: ";
            // 
            // lbQueryResult
            // 
            lbQueryResult.Location = new Point(22, 174);
            lbQueryResult.Name = "lbQueryResult";
            lbQueryResult.Size = new Size(71, 15);
            lbQueryResult.TabIndex = 3;
            lbQueryResult.Text = "Query result";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(22, 192);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(532, 96);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(lbQueryResult);
            Controls.Add(label1);
            Controls.Add(tbQuery);
            Controls.Add(btnGo);
            Name = "Form";
            Text = "Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGo;
        private TextBox tbQuery;
        private Label label1;
        private Label lbQueryResult;
        private RichTextBox richTextBox1;
    }
}
