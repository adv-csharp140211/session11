namespace AppRegex;

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
        buttonValidate = new Button();
        label1 = new Label();
        textBoxEmail = new TextBox();
        SuspendLayout();
        // 
        // buttonValidate
        // 
        buttonValidate.BackColor = Color.Chartreuse;
        buttonValidate.Location = new Point(519, 14);
        buttonValidate.Name = "buttonValidate";
        buttonValidate.Size = new Size(75, 29);
        buttonValidate.TabIndex = 0;
        buttonValidate.Text = "Validate";
        buttonValidate.UseVisualStyleBackColor = false;
        buttonValidate.Click += buttonValidate_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(34, 21);
        label1.Name = "label1";
        label1.Size = new Size(36, 15);
        label1.TabIndex = 1;
        label1.Text = "Email";
        // 
        // textBoxEmail
        // 
        textBoxEmail.Location = new Point(86, 18);
        textBoxEmail.Name = "textBoxEmail";
        textBoxEmail.Size = new Size(427, 23);
        textBoxEmail.TabIndex = 2;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(textBoxEmail);
        Controls.Add(label1);
        Controls.Add(buttonValidate);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button buttonValidate;
    private Label label1;
    private TextBox textBoxEmail;
}
