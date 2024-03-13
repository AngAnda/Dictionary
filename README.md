# Dictionary Application Documentation

## Overview

The Dictionary Application is developed using C# and Windows Presentation Foundation (WPF), designed to provide a comprehensive solution for managing a dictionary database. It allows users to search for words, add new entries, edit existing ones, and participate in quizzes to test their knowledge.

## Features

### Main Interface

The main interface welcomes users with a greeting and offers three main functionalities:

- **Login:** Authenticates users, unlocking additional features.
- **Administration Mode:** Permits authenticated users to manage dictionary entries.
- **Quiz:** Tests the user's knowledge through a quiz interface.

### Administration Mode Interface
In the User Mode, users can perform the following actions:
- **Add New Words:** Users can contribute new words to the dictionary along with their descriptions and categories.
- **Edit Words:** Allows for the modification of existing dictionary entries.
- **Delete Words:** Enables users to remove entries from the dictionary.

  
![image](https://github.com/AngAnda/Dictionary/assets/61116472/e8a58da2-a1ff-4df5-b08c-85b099c7cd8d)


### Dictionary Lookup Interface

This interface simplifies the process of finding words in the dictionary by displaying:

- A dropdown menu for word selection.
- The selected word's description and category.
- An associated image, if available.

### Quiz  Mode
Users can check their vocabulary by playing a funny game where they are given prompts and have to guess the word.
- **Question Progress Indicator:** The application displays the current question number and the total number of questions in the quiz (e.g., 3 / 5), letting users know their progress.
- **Question Display Area:** The application uniquely displays each question either as a descriptive text or an image, chosen randomly. 
- **Answer Submission Field:** Users can type their answers into a text input field. This field supports text-based answers, allowing for a wide range of question types.
- **Navigation Buttons:**
  - **Previous:** Allows users to go back to the previous question. This feature is essential for users who wish to change their answers to earlier questions.
  - **Next:** Users can move forward to the next question. This button also serves to submit the current answer before proceeding.
<figcaption>Description as prompt sample</figcaption>
![Description as prompt sample](https://github.com/AngAnda/Dictionary/assets/61116472/83f4eb8f-d8d0-4f3d-81b5-aa0085b4ed03)

<figcaption>Image as prompt</figcaption>
![Image as prompt](https://github.com/AngAnda/Dictionary/assets/61116472/ce476cca-bdde-4e94-9f74-9e84141a58a1)


## Usage

### Adding or Editing Words

When adding or editing dictionary entries, the application provides fields for:

- **Word Name:** The term to be added or edited.
- **Category:** Allows categorization of the word from a predefined list.
- **Description:** A detailed explanation of the word.
- **Image:** An option to attach a relevant picture.

## Technical Details

Developed in C# and utilizing WPF for the UI, the application follows the MVVM pattern. This approach ensures a clean separation between logic and presentation, facilitating maintenance and scalability.

### Data Management

Dictionary entries are stored and managed through a backend database or file system, encompassing word names, categories, descriptions, and image paths.

### User Authentication

The application includes a user authentication system, distinguishing between regular users and administrators to provide appropriate access levels.

## Conclusion

The Dictionary Application is a versatile tool for anyone interested in language learning and dictionary management. It combines intuitive design with comprehensive functionality, making it a valuable asset for educators, students, and language enthusiasts.
