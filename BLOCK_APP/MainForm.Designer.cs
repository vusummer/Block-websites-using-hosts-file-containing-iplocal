namespace BLOCK_APP
{
    partial class MainForm
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
            listBoxUrls = new ListBox();
            btnAdd = new Button();
            txtUrl = new TextBox();
            label1 = new Label();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // listBoxUrls
            // 
            listBoxUrls.FormattingEnabled = true;
            listBoxUrls.Location = new Point(12, 140);
            listBoxUrls.Name = "listBoxUrls";
            listBoxUrls.Size = new Size(663, 244);
            listBoxUrls.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(342, 58);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 48);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 58);
            txtUrl.Multiline = true;
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(324, 48);
            txtUrl.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 4;
            label1.Text = "Thêm URL Block";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(564, 86);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 48);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 394);
            Controls.Add(btnDelete);
            Controls.Add(label1);
            Controls.Add(txtUrl);
            Controls.Add(btnAdd);
            Controls.Add(listBoxUrls);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxUrls;
        private Button btnAdd;
        private TextBox txtUrl;
        private Label label1;
        private Button btnDelete;
    }
}