<https://forbidden-duck.github.io/PasswordManager/>
# PasswordManager Project

This project was a created on 07/04/2020 at 5:00pm AEST.\
Project Initial Commit Date: 07/04/2020.

## WARNINGS
### Modifying Project
When modifying the project, it is recommended you have experience in C# and in using WinForms and SQL Server. This project uses WinForms for the GUI and SQL Server 2019 for the use of the database. Make sure that when downloading the required SQL applications and modifying the app.config you do it correctly.

### Downloading Project
On-going updates to the project will be happening. If you find bugs in the project please report them, refer to "Support or Contact". If you do find large bugs or constantly finding bugs or that you lost some data in the database you may have downloaded the project while I was pushing some new updates and you may have gotten a broken version. If so keep an eye on the commits and you may see a new one come through.

## Project Notes & Contact Information

### Note

This project was solely created by Harrison Howard (Forbidden-Duck).\
This project can be used at will (following the MIT License).

Projects SQLController and SQLConnection originated from VideoRentals Project. Refer that README.md for more information.

A stable version of this project has been released. More features will be added in the coming days.

Code has been appropriately commented. If any confusions comes from the code refer to "Support or Contact"

### Contact

If you need help understanding some code please contact me. Otherwise please head over to "Issue" or "Pull Request"

**Discord**: Duck#9999
**Email**: harrison.howard00707@gmail.com

## Project Features

### Features in the works
**Account Management**\
Request the password when editing or creating passwords.

**Importing**\
Importing with Custom files (Import Builder which will allow the user to build the structure of the file)

### Available Features
**Account creation**\
Be able to create as many accounts you please. With added Confirm Password protection.

**Account Management**\
Change your password, delete your account and delete all your passwords

**Admin Access**\
First account created is automatically an admin. Be able to manage user accounts and edit user admin access

**Create, Edit and Delete Passwords**\
Be able to create, edit and delete as many passwords as you please.

**Password Security**\
We use Hash Salt for making passwords secure and Encryption and Decryption with a key.

**Stay signed in**\
Have the ability to stay signed in

**Importing** and **Exporting**\
Importing and Exporting features have been added. You can import with Google Passwords or Password Manager Passwords

**Tags**\
Be able to add tags and filter by tags

## Frequently asked questions
### How do I start the program?
You will have to go into the app.config (this will be located along side all the forms). You will need SQL Server downloaded and it is recommended to also have SQL Management Studio. In the app.config locate < connectionStrings > and modifed Data Source as the Server Name and Initial Catalog as the Database name.\
**Do not do this unless you know what you are doing, it is recommended you look at a guide that explains how to setup SQL Server in an app.config**

### How do I create an account
Start the program and on the login screen you will see a blue link like label sitting underneath Password. Click that and you will be greeted with the Account Creation form. Enter a username and password and enter that at the login screen once you have clicked Created. Please keep in mind no account management has been created and if you make a mistake you may have to delete all the users (you don't have to delete the passwords as they will connect up to the same ID as long as you create in the correct order)\
**again we don't recommend using this application if you are not familar with C# and using SQL. A version of this maybe created so it requires no programming skill**

### How do I create a password
Once you have successfully logged in you can click "New Password" in the bottom left and it will bring up a new form. You can enter a title for your password like "Google Account" "GMail Account" and so on and enter the password.\
**Note when editing or adding a new password the password will be visible as text. This is so you can actually edit or add a password with ease**
