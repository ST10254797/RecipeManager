# Recipe Manager Application

## Overview
The Recipe Manager application allows users to manage their recipes by adding, filtering, viewing details, and exporting recipes to a text file. It includes dynamic addition of ingredients and steps, filtering recipes by ingredient, food group, and maximum calories, as well as generating menus (placeholder feature) and displaying a food group distribution pie chart.

## Features
- **Add Recipe**: Enter recipe details including name, ingredients, steps, food group, and calories. Ingredients and steps can be added dynamically.
- **Filter Recipes**: Filter recipes based on ingredient, food group, and maximum calories.
- **View Recipe Details**: Select a recipe to view its detailed ingredients and steps.
- **Export Recipes**: Export all recipes to a text file for external storage.
- **Pie Chart Display**: Display a static pie chart showing food group distribution (placeholder feature).
- **Generate Menu**: Placeholder feature for generating menus based on selected recipes.

## Lecture Feedback on Code Changes
- Implemented dynamic addition of ingredients and steps effectively.
- Applied filtering functionality well; ensure consistent user feedback on applied filters.
- Generated a static pie chart for food group distribution; consider making it dynamic based on real data.
- Implemented recipe export functionality to a text file.

## Improving Coding Structure and Referencing Practices
- **Coding Structure**: 
  - Organized code into logical methods and event handlers.
  - Utilized object-oriented principles effectively with the Recipe class.
  - Improved user interface interactions with event-driven programming.

- **Referencing Practices**: 
  - Applied C# language features appropriately.
  - Utilized WPF for the user interface, implementing MVVM pattern for better separation of concerns.
  - Used OxyPlot for generating static pie chart; consider enhancing it with dynamic data.


## How to Compile and Run

### Prerequisites
- **Development Environment**: Ensure you have Visual Studio installed with support for C# development.
- **.NET Framework**: The application is built on .NET Framework. Ensure your development environment supports .NET Framework 4.7.2 or later.

### Steps
1. **Clone Repository**: Clone the Recipe Manager repository to your local machine:

2. **Open Solution**: Open the `RecipeManager.sln` solution file in Visual Studio.

3. **Build Solution**: Build the solution to compile the application.

4. **Run Application**: Set `MainWindow.xaml` as the startup object and run the application.

5. **Explore Features**: Use the application to add recipes, apply filters, view recipe details, and export recipes.

## User Interface
- **Recipe Details**: The left panel allows adding recipes, managing ingredients and steps, and applying filters.
- **Recipe List**: Displays filtered recipes and allows selection for viewing details.
- **Additional Functionality**: Buttons for exporting recipes, generating menus (placeholder), and showing food group distribution (static pie chart).

## Contributing
Contributions are welcome! Please fork the repository, make your changes, and submit a pull request.

## License
This project is licensed under the MIT License - see the LICENSE file for details.
