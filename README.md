# HealthCarePortal - ITSC-3112-001 Final Project 
## By Joshua Foster 

A Healthcare Portal recreation based on my personal experience with healthcare patient portals used by doctor's office, written in C# and utlizing WinForms for the GUI. 

For a video presentation of this project click [here](https://drive.google.com/file/d/1zpKCCyDUvNZUHnJaiMwYHU7s9XPnmsgQ/view?usp=sharing)

 ## To install and run this project

* Download the code from the github repository and run it in Visual Studio (I used the Start button in Debug mode personally 🙂) 
* You will need to register a patient and doctor to gain most of the functionality of the project
   * However, there is commented dummy data in the Program.cs file that you can uncomment to use for fast-tracked testing 
      * Patient: 
        * Username: joshua
        * password: hi
      * Doctor:
        * Username: foster
        * password: hi
* Outside of that, you should be able to enter the **CORRECT** credentials and log into the program. From there, the decision branch depends on whether you have logged in as a Patient or Doctor
  * Patients:
    * Can view their Inbox and message Doctors 
    * Can schedule or cancel appointments with Doctors 
    * Can view their Medical History which contains information regarding their diagnoses and prescriptions 
  * Doctors:
    * Can view the Patients that have ever scheduled an appointment with them 
    * Can double-click on any Patient in their Patients tab to view their details, including demographic data and Medical History. They can also adjust any of the Medical History data found on this page, either adding to it, editing it, or removing it
    * Can view their Inbox and message Patients
    * Can view their schedule and edit or cancel Appointments
* Both Patients and Doctors alike will find Notification ListViews in their Overview tab where, if they click on the notification, it will take them to the appropriate tab
* Additionally, both Patients and Doctors will be able to view their upcoming Appointments. For Patients, it will show their next 5 Appointments, but for Doctors it will showcase their Daily Schedule 
* Outside of these functionalities, both users can choose to logout and exit the program at any time in their main dashboard page