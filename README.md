# Avcol Forms
A repository of school-related paperwork for teachers and students.

## Usage
This application displays a list of forms, all tailored to a specific user-type. When the user first opens the application, they specify whether to view student or teacher-related forms. 

Form submissions are delivered to the appropriate departments via a built-in STMP email client.

## Contributing
This software does not employ any form of copy-left license, though entities representing Avondale College are free to open pull requests. Such modifications might include additional forms or general modifications to the codebase.

Currently, new form views must be defined in the FormManager class using the `_Student` and `_Teacher` ICollections. These are exposed to the rest of the program via the public GetUserForms() method.
