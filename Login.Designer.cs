namespace Password_manager;

partial class Login
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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(340, 120);
        this.Text = "Login";
        Label usernameLabel = new Label() {
            Text = "Username:",
            Location = new Point(10, 10),
            AutoSize = true,
        };

        TextBox usernameTextBox = new TextBox() {
            Location = new Point(100, 10),
            Width = 200,
            AutoSize = true,
        };

        Label passwordLabel = new Label() {
            Text = "Password:",
            Location = new Point(10, 40),
            AutoSize = true,
        };

        TextBox passwordTextBox = new TextBox() {
            Location = new Point(100, 40),
            Width = 200,
            PasswordChar = '*',
            AutoSize = true,
        };

        Button loginButton = new Button() {
            Text = "Login",
            Location = new Point(100, 70),
            Width = 90,
            AutoSize = true,
        };

        Button registerButton = new Button() {
            Text = "Register",
            Location = new Point(210, 70),
            Width = 90,
            AutoSize = true,
        };

        this.Controls.Add(usernameLabel);
        this.Controls.Add(usernameTextBox);
        this.Controls.Add(passwordLabel);
        this.Controls.Add(passwordTextBox);
        this.Controls.Add(loginButton);
        this.Controls.Add(registerButton);

    }

    #endregion
}
