<https://forbidden-duck.github.io/PasswordManager/>
# PasswordManager Project

This project was a created on 07/04/2020 at 5:00pm AEST.
Project Initial Commit Date: 07/04/2020.

## WARNINGS
### Modifying Project
When modifying the project, it is recommended you have experience in C# and in using WinForms and SQL Server. This project uses WinForms for the GUI and SQL Server 2019 for the use of the database. Make sure that when downloading the required SQL applications and modifying the app.config you do it correctly.

### Downloading Project
On-going updates to the project will be happening. If you find bugs in the project please report them, refer to "Support or Contact". If you do find large bugs or constantly finding bugs or that you lost some data in the database you may have downloaded the project while I was pushing some new updates and you may have gotten a broken version. If so keep an eye on the commits and you may see a new one come through.

### General use
While the purpose of this is to allow management of large quantities of passwords with ease. It will not have super safe security and if you were to be a victim of a hack or malware that the malicious user may find it easy to get your passwords and decrypt them. This project is more just getting experience and having a portfolio. Once more features get added security may get better as well as releasing this application without having to modify the app.config to actually have the database working.

## Project Notes & Contact Information

### Note

This project was solely created by Harrison Howard (Forbidden-Duck).
This project can be used at will (following the MIT License).

A stable version of this project has been released. More features will be added in the coming days.

Code has been appropriately commented. If any confusions comes from the code refer to "Support or Contact"

### Support or Contact

If you find bugs or need help understanding some code please contact me.

**Discord**: Duck#9999
**Email**: harrison.howard00707@gmail.com

## Project Features

### Features in the works
**Account Management**
Be able to manage your account. Such as deleting, changing your password and staying signed in. As well as more optional security, as always request the password when editing or creating passwords.

**Admin**
The first account created will automatically be assigned as an Admin. Be able to manage all users (not passwords).

**More control of the passwords**
Be able to save your passwords in an CSV file (options to be encrypted or in plain text) and delete passwords.

**More options to be added to passwords**
Such as, the date it was created and specific tags (Email, Discord).

**Custom key**
Be able to assign a custom key to the encryption process. Please keep in mind that once activated you have to store the key elsewhere as the database will not store it as that would make the key useless as any person who gets access to the database will see the decryption key. Also note that the key would need to be entered every time.

**Password used as key**
There are 2 approaches to this. We get you to use the password for the user account, the downside is that we can not decrypt the password and you will need to enter it every time. The other approach is you give the password and that is stored again but encrypted with the key process. However, much planning would need to be invested for a clean version to be released.

**Confirm password**
Adding confirm password when making an account. I've enter a password incorrectly so many times when testing this application. It will come.

**Pressing enter**
Pressing enter will not Login or Add/Save a password at this time. This is a definite feature that will be added.

**Exit button**
We don't have an exit button on the login screen. While it's not needed to close the application and may be helpful.

**Importing**
I will do some research on Googles Saved Passwords and so on to see if it is possible to have passwords saved on other applications or webites to be exported and imported into this application.

### Available Features
**Account creation**
Be able to create as many accounts you please

**Create and Edit Passwords**
Be able to edit and create passwords

**Password Security**
We use Hash Salt for making passwords secure and Encryption and Decryption with a key. 

## Frequently asked questions
### How do I start the program?
You will have to go into the app.config (this will be located along side all the forms). You will need SQL Server downloaded and it is recommended to also have SQL Management Studio. In the app.config locate < connectionStrings > and modifed Data Source as the Server Name and Initial Catalog as the Database name. **Do not do this unless you know what you are doing, it is recommended you look at a guide that explains how to setup SQL Server in an app.config**

### How do I create an account
Start the program and on the login screen you will see a blue link like label sitting underneath Password. Click that and you will be greeted with the Account Creation form. Enter a username and password and enter that at the login screen once you have clicked Created. Please keep in mind no account management has been created and if you make a mistake you may have to delete all the users (you don't have to delete the passwords as they will connect up to the same ID as long as you create in the correct order) **again we don't recommend using this application if you are not familar with C# and using SQL. A version of this maybe created so it requires no programming skill**

### How do I create a password
Once you have successfully logged in you can click "New Password" in the bottom left and it will bring up a new form. You can enter a title for your password like "Google Account" "GMail Account" and so on and enter the password. **Note when editing or adding a new password the password will be visible as text. This is so you can actually edit or add a password with ease**
