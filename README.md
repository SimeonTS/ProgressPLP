# ProgressPLP

## Hosting Model: WebAssembly

## Description

The Progress PLP Project is a simple demonstration of an online shop built using the Blazor framework. The chosen hosting model for this project is WebAssembly. WebAssembly was chosen as the hosting model due to its ability to execute C# code directly in the browser, providing a more interactive and responsive user experience.

## Components

- Product Class: The Product class defines the structure of each product in the online shop.
- ProductsList Class: The ProductsList class contains a static list of example products, each represented by an instance of the Product class.
-ProductsDisplay Component: The ProductsDisplay component is a Blazor Razor component that renders the list of products. The component also applies CSS styles to create an grid layout with responsive design.

## Hosting Model Selection

WebAssembly was chosen over the server-side hosting model for several reasons. WebAssembly allows the application to run directly in the browser, reducing the need for constant communication with the server. This results in improved performance and a more fluid user experience. Additionally, WebAssembly enables the use of C# and .NET libraries on the client side, making it possible to share code between the server and the client.