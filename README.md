# Edge Detection Project  

## Overview  
This project implements edge detection algorithms (Sobel, Prewitt) using **EmguCV** in C#. It allows users to apply edge detection to images and visualize the results.  

## Features  
- Enable user to select and apply different edge detection methods (Sobel, Prewitt) on an image
- Enable user to adjust parameters for edge detection operator  
- Display the edge detected image & original grayscale image

## Prerequisites  
Ensure you have the following installed:  
- .NET SDK (version 9.0)  
- Emgu.CV library (`dotnet add package Emgu.CV`)  
- A C# IDE (Visual Studio, VS Code)  

## Installation Steps
1. **Clone the Repository**  
   ```sh
   git clone https://github.com/ytia001/edge-detection.git

2. **Ensure Prerequisites are Installed**  
   - Make sure you have all the required dependencies installed on your system.  
   - Emgu can be downloaded from the `dependencies` folder.  
3. Locate to project directory & Install Dependencies 
    ```sh
    dotnet restore
4. Build the project 
    ```sh
    dotnet build
5. Run the application 
    ```sh
    dotnet run
6. Select an Image file 
    - Example images are provided in the examples folder
7. Choose an Edge Detection Method
    - Once chosen, the orginal grayscale image & image with detected edges will be displayed

## Steps to use 
1. User will be prompted to enter an image file path 
2. User will then select whether to use Sobel or Prewitt Edge Operator for Edge Detection 
3. Original grayscale image and the Edge Detected image will be displayed 
