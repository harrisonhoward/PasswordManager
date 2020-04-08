# Contributing to PasswordManager project

Thanks for being interested in contributing to this project.\
This guide is to help incorporate your opinions or code to this project.

## Opening an issue

If you have found an issue with the project, please ensure that you have searched for the issue on existing issues.\
Once you have confirmed it does not already exist feel free to open the issue.

Please include as much detail as possible when creating your issue\
Screenshots can maximise the understand of your issue.\
If you can solve the issue yourself it maybe useful to do a pull request instead.

## Pull Request

We appreicate and welcome pull requests.\
Any issues, features or general fixes that you have done can be requested here.

### Getting the program working
**Getting SQL Server and SQL Server Management Studio**
1. Download the SQL Server Developer or Express
2. Download SQL Server Management Studio 18
3. Open Management Studio and find your Server Name (this will be your Data Source)
- [SQL Server Downloads](https://www.microsoft.com/en-au/sql-server/sql-server-downloads)
- [SQL Server Management Studio 18](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)

**Changing the Data Source**\
Please make sure you have a working version of the program running.
1. Download the SQLConnection repository and having it sitting next to or inside of PasswordManager
2. Open Visual Studio and Right Click the Solution -> Add -> Existing Project -> SQLConnection
3. Go to the PasswordManager Project -> app.config and add your Data Source in the connection string
4. Run the program

**NLog Errors**\
If you are getting errors with NLog please do the following
1. Uninstall NLog, NLog Config and NLog Schema
2. Install NLog to the entire project
3. Install NLog Config to the PasswordManager project

### Error logs

We are using NLog to log errors that originate from our SQLConnection and SQLController. Please sent the logs.
1. Build the solution to Debug
2. Project Directory -> bin -> Debug
3. Zip the log folder (if it exists and contains logs)

### Testing

Please make sure the code you have added has been tested and works as expected.\
If your request is tested on the project and causes errors or bugs we will send it back to you.

### Documentating
Please document any changes you have added.\
Add XML Comments to methods (that aren't events) and general comments to as many lines as possible

**Example**
```cs
/// <summary>
/// This class does this and that
/// </summary>
public class Foo {
	// Create a variable for assigning my integer
	int _myInt = 0;
	
	/// <summary>
	/// Initializes a new Foo Instance
	/// </summary>
	/// <param name="myInt">The provided myInt</param>
	public Foo(int myInt) {
		// Assign myInt to the Global Variable
		_myInt = myInt;
	}
	
	/// <summary>
	/// Resets _myInt back to 0
	/// </summary>
	public void resetMyInt() {
		// Assining 0 to _myInt
		_myInt = 0;
	}
	
	/// <summary>
	/// Gets _myInt variable
	/// </summary>
	/// <returns>Returns integer myInt</returns>
	public int getMyInt() {
		// Return _myInt
		return _myInt;
	}
}
```


## [Developer's Certificate of Origin 1.1](https://elinux.org/Developer_Certificate_Of_Origin)
By making a contribution to this project, I certify that:

(a) The contribution was created in whole or in part by me and I
    have the right to submit it under the open source license
    indicated in the file; or

(b) The contribution is based upon previous work that, to the best
    of my knowledge, is covered under an appropriate open source
    license and I have the right under that license to submit that
    work with modifications, whether created in whole or in part
    by me, under the same open source license (unless I am
    permitted to submit under a different license), as indicated
    in the file; or

(c) The contribution was provided directly to me by some other
    person who certified (a), (b) or (c) and I have not modified
    it.

(d) I understand and agree that this project and the contribution
    are public and that a record of the contribution (including all
    personal information I submit with it, including my sign-off) is
    maintained indefinitely and may be redistributed consistent with
    this project or the open source license(s) involved.
