Automatic File Organizer Tool 🗂️
=================================

Welcome to the **Automatic File Organizer Tool**! This is a simple yet powerful C# console application designed to help you organize files in any directory by automatically sorting them into folders based on their file extensions. Whether you're dealing with a cluttered Downloads folder or just want to keep your files neatly organized, this tool has got you covered!

Features ✨
----------

*   **Automatic File Sorting:** Files are automatically moved into folders based on their extensions (e.g., .jpg files go to the "Images" folder, .pdf files go to the "Documents" folder).
    
*   **Customizable Folders:** Easily customize folder names for different file types by modifying the code.
    
*   **User-Friendly:** Simply provide the directory path, and the tool does the rest!
    
*   **Error Handling:** Built-in error handling ensures smooth operation even if unexpected issues arise.
    
*   **Lightweight:** A simple console application that doesn't require any additional dependencies.
    

Supported File Types 📁
-----------------------

The tool currently supports the following file types:

*   **Images:** .jpg, .jpeg, .png, .gif
    
*   **Documents:** .pdf, .doc, .docx, .xls, .xlsx
    
*   **Music:** .mp3, .wav
    
*   **Videos:** .mp4, .avi, .mkv
    
*   **Archives:** .zip, .rar, .7z
    
*   **Other:** All other file types are moved to the "Other" folder.
    

You can easily extend this list by modifying the GetFolderName method in the code.

How to Use 🛠️
--------------

1.  bashCopygit clone https://github.com/UlviPoladov/Automatic-File-Organization-Tool
    
2.  **Open the Project:**
    
    *   Open the project in Visual Studio or your preferred C# IDE.
        
3.  **Build and Run:**
    
    *   Build the project and run the executable.
        
    *   Enter the directory path you want to organize when prompted.
        
4.  **Enjoy Organized Files!**
    
    *   The tool will automatically sort your files into appropriate folders.
        

Example 🖼️
-----------


### Before:

Copy

`   C:\Users\YourUsername\Downloads  ├── example.jpg  ├── document.pdf  ├── song.mp3  ├── video.mp4  └── archive.zip   `

### After Running the Tool:

Copy

`   C:\Users\YourUsername\Downloads  ├── Images  │   └── example.jpg  ├── Documents  │   └── document.pdf  ├── Music  │   └── song.mp3  ├── Videos  │   └── video.mp4  ├── Archives  │   └── archive.zip  └── Other   `


Future Improvements 🚀
----------------------

Here are some ideas to make this tool even better:

*   Add a **Graphical User Interface (GUI)** using WinForms or WPF.
    
*   Allow users to **customize folder names** via a configuration file.
    
*   Implement **logging** to track file movements and errors.
    
*   Add support for **recursive directory organization** (organizing subfolders as well).
    
*   Enable **multi-threading** for faster file organization in large directories.
    

Contributing 🤝
---------------

Contributions are welcome! If you have any ideas, suggestions, or bug reports, feel free to open an issue or submit a pull request. Let's make this tool even better together!


About Me 👋
-----------

Hi! I'm Ulvi, a recent graduate and aspiring software developer. This project is part of my journey to learn and showcase my skills in C# and .NET. Feel free to connect with me on [LinkedIn]([https://www.linkedin.com/in/yourprofile](https://www.linkedin.com/in/ülvi-poladov-51b9042b4/)) or check out my other projects on [GitHub](https://github.com/UlviPoladov).

Show Your Support 🌟
--------------------

If you find this project useful, please give it a ⭐️ on GitHub! Your support motivates me to keep building and sharing cool tools like this.

Happy organizing! 🎉
