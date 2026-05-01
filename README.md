# Applicants Enrollment

**Applicants Enrollment** is a Windows desktop application for managing university admissions. Built with C# and Windows Forms, it allows prospective students to apply for university programs and university staff to review applications and admission rankings.

This was my first software project, created while learning C# and object-oriented programming. The goal was to put OOP concepts into practice through a complete desktop application with distinct user roles, admission workflows, and persistent data storage. At the time, the project used JSON files instead of a database.

## Features

- **Applicant registration:** Applicants create profiles and provide their examination results.
- **Program applications:** Applicants can apply to a limited number of academic programs offered by the university.
- **Applicant workflow:** Applicants submit applications for consideration by university staff.
- **Staff interface:** University employees can review submitted applications and manage admission decisions.
- **Program rankings:** View ranked lists of applicants for each academic program.
- **Individual application review:** Examine applications and make decisions on a case-by-case basis.
- **Automated approval:** Use examination results to assist with automatic application approval.
- **Local persistence:** Store and retrieve application data using JSON files.
- **Desktop interface:** Navigate applicant and staff workflows through Windows Forms.

## Tech Stack

| Layer | Technology |
| --- | --- |
| Language | C# |
| Platform | .NET |
| User interface | Windows Forms (WinForms) |
| Programming approach | Object-oriented programming (OOP) |
| Data storage | JSON files |

## How It Works

Applicants Enrollment separates the admission process into two main roles:

1. **Applicants** register, enter examination results, and submit applications to a limited number of university programs.
2. **University staff** review applications, inspect ranked applicant lists for each program, and evaluate individual submissions.
3. **Admission processing** supports both manual review and automatic approval based on examination results.
4. **JSON persistence** saves application data locally, allowing the program to retain information between sessions without a database server.

The project was an early exercise in organizing application behavior around objects and classes, designing desktop forms, and implementing a multistep workflow from registration to admission decisions.

## Author

- **Andrii Vus**  
  GitHub:  https://github.com/APAXIC  
  LinkedIn:  https://www.linkedin.com/in/andrii-vus/  
  Email:  irishardron@gmail.com
