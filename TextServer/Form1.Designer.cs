namespace TextServer;

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
        TextBox = new RichTextBox();
        Btn_Listen = new Button();
        SuspendLayout();
        // 
        // TextBox
        // 
        TextBox.Location = new Point(12, 12);
        TextBox.Name = "TextBox";
        TextBox.ReadOnly = true;
        TextBox.Size = new Size(530, 160);
        TextBox.TabIndex = 0;
        TextBox.Text = "";
        // 
        // Btn_Listen
        // 
        Btn_Listen.Location = new Point(12, 179);
        Btn_Listen.Name = "Btn_Listen";
        Btn_Listen.Size = new Size(530, 23);
        Btn_Listen.TabIndex = 1;
        Btn_Listen.Text = "Listen";
        Btn_Listen.UseVisualStyleBackColor = true;
        Btn_Listen.Click += Btn_Listen_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(554, 214);
        Controls.Add(Btn_Listen);
        Controls.Add(TextBox);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private RichTextBox TextBox;
    private Button Btn_Listen;
}
