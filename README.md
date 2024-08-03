<!--### User Documentation for Quiz App-->

## Overview

**CRUD Operations App** This application allows users to manage a list of users through basic CRUD operations (Create, Read, Update, Delete). Users can:
 - Add: Create a new user by entering their full name, email address and phone number.
 - Read: View details of all users in the system.
 - Update: Modify the details of an existing user by seleting their phone number and updating their information.
 - Delete: Remove a user from the system by selecting their phone number.

 The app uses basic console input and output for interaction, and all user data is managed within a static list to ensure consistency across the application.

## Requirements

- Windows operating system
- .NET Runtime installed on the system
- Integrated Development Environment (IDE) like Visual Studio (optional for code modification)

## Getting Started

1. **Downloading and Running the Program:**

   - <b>Executable File</b>: If the program is available as an executable (.exe) file, download the file and double-click to run it.
   - <b>Source Code</b>: If the program is available as source code, use your development environment (e.g., Visual Studio) to build and run the program.

2. **Starting the Program:**

   Upon running the program, a welcome message will appear followed by instructions to begin interacting with the application.

3. **Using the Application**

    - <b>Add User</b>: Enter user details (Full Name, Email, Phone Number) to create a new user.
    - <b>View Users</b>: Display a list of all users currently in the system.
    - <b>Update User</b>: Modify the details of an existing user by selecting their phone number and updating their information.
    - <b>Delete User</b>: Remove a user from the list by providing their phone number.
    - <b>Clear Console</b>: Clear the console screen.
    - <b>Exit</b>: Close the application.


## Example Run

```
Welcome to CRUD Operations Application!

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 1

══════════════════════════════════Add User══════════════════════════════════

Please Enter Full-Name: Rick Grimes
Please Enter Email Address: rickgrimes@mail.com
Please Enter Phone Number: +123456789

User Added Successfully!

══════════════════════════════════New User Information════════════════════════

Full-Name: Rick Grimes
Email Address: rickgrimes@mail.com
Phone Number: +123456789

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 1

══════════════════════════════════Add User══════════════════════════════════

Please Enter Full-Name: Daryl Dixon
Please Enter Email Address: daryaldixon@gmail.com
Please Enter Phone Number: +401391445

User Added Successfully!

══════════════════════════════════New User Information════════════════════════

Full-Name: Daryl Dixon
Email Address: daryaldixon@gmail.com
Phone Number: +401391445

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 2

══════════════════════════════════Update User Data════════════════════════

Enter Phone Number to Update User Data: +401391445
1-Full Name
2-Email
3-Phone Number
Please Choose Number to Update: 3
Enter New Phone Number: +3019301391
Phone Number updated successfully!

══════════════════════════════════User Updated Information════════════════════════

Full-Name: Daryl Dixon
Email Address: daryaldixon@gmail.com
Phone Number: +3019301391

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 3

══════════════════════════════════Delete User══════════════════════════════════

Please enter the Phone Number of the user: +3019301391
User Deleted Successfully!

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 3

══════════════════════════════════Delete User══════════════════════════════════

Please enter the Phone Number of the user: 013
No Users Found!

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 4

══════════════════════════════════════════════════════════

User #1

Full-Name: Rick Grimes
Email Address: rickgrimes@mail.com
Phone Number: +123456789

══════════════════════════════════════════════════════════

1-Add User
2-Update Data of User
3-Delete User
4-Print All Users
5-Clear Console
6-Exit

══════════════════════════════════════════════════════════

Enter your choice: 6
Exiting Application...
```


## Future Enhancements

- Add more input validation.
- Add search by email address feature.
- Add Handling exceptions and errors more effectively.

---
