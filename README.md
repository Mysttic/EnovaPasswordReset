# EnovaPasswordReset
The application allows you to reset the operator password in the selected enova database.

![image](https://user-images.githubusercontent.com/19372942/154306069-82dd3471-fecb-49d7-bb31-741509f07c4b.png) 

##How to use:

1. In the Instance field, enter the address of the server on which the database is located. You can load a list of local instances by clicking the Load button
2. Complete the database access parameters (Is Windows authorization, PersistSecurityInfo required, or SQL user login details)
3. After entering the access data, click Refresh to load the list of databases
4. Select the database and the operator for which you want to change the password
5. Enter a new operator password in the New password field
6. Clicking on the Execute button will change the password

Additional info:
- The enova program must be restarted for the password change to be visible
- In the additional *.config* file, you can enter the default access data that will be loaded when the program is started
