namespace Mult_Conn_Server_GUI;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if(disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        List_Clients = new ListView();
        columnHeader1 = new ColumnHeader();
        columnHeader2 = new ColumnHeader();
        columnHeader3 = new ColumnHeader();
        columnHeader4 = new ColumnHeader();
        SuspendLayout();
        // 
        // List_Clients
        // 
        List_Clients.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
        List_Clients.GridLines = true;
        List_Clients.Location = new Point(12, 12);
        List_Clients.Name = "List_Clients";
        List_Clients.Size = new Size(606, 274);
        List_Clients.TabIndex = 0;
        List_Clients.UseCompatibleStateImageBehavior = false;
        List_Clients.View = View.Details;
        // 
        // columnHeader1
        // 
        columnHeader1.Text = "EndPoint";
        columnHeader1.Width = 150;
        // 
        // columnHeader2
        // 
        columnHeader2.Text = "Id";
        columnHeader2.Width = 150;
        // 
        // columnHeader3
        // 
        columnHeader3.Text = "LastMsg";
        columnHeader3.Width = 150;
        // 
        // columnHeader4
        // 
        columnHeader4.Text = "LastRcvTime";
        columnHeader4.Width = 150;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(629, 298);
        Controls.Add(List_Clients);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
    }

    #endregion

    private ListView List_Clients;
    private ColumnHeader columnHeader1;
    private ColumnHeader columnHeader2;
    private ColumnHeader columnHeader3;
    private ColumnHeader columnHeader4;
}
