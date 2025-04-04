# 🔐 File Locker for Windows (C#)

A simple Windows application to lock and unlock files using a predefined password. Built with C# and Windows Forms, this app helps restrict access to files by toggling file permissions — perfect for basic file security on local machines.

## 🚀 Features

- 🔒 Lock any file with one click
- 🔓 Unlock files using a password
- 🧠 Simple UI with three main components:
  - **Lock Button**: Restricts access to the selected file
  - **Unlock Button**: Restores access to the file
  - **Password TextBox**: Requires the correct password to unlock the file
- 🛡️ Requires elevated permissions (Administrator access) to modify file security

## 📷 Screenshots
![IMG3](https://github.com/user-attachments/assets/aa388e4a-da56-43c3-88e0-4311ae87cfbd)

## ⚙️ How It Works

- The app modifies the file's access control list (ACL) to deny or allow access.
- A hardcoded password is required to unlock the file.
- Make sure to run the app with sufficient privileges.

## 📝 Usage

1. Run the application as Administrator.
2. Choose a file to lock or unlock (you can integrate a File Dialog or manually enter the path).
3. Enter the password in the textbox.
4. Click **Lock** to restrict access or **Unlock** to restore access.

> **Note:** The password is currently hardcoded in the source code. You can change it by editing the relevant section in `Form1.cs`.

## 📦 Technologies Used

- C#
- .NET Framework / .NET (specify your version)
- Windows Forms

## 📦 How to Use

Clone the repository:
```
git clone https://github.com/moeinnrz/FileLocker.git
```
