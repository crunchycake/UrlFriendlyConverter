UrlFriendlyConverter

UrlFriendlyConverter is a simple Windows Forms application that helps you quickly convert any text into a URL-friendly format (also known as a "slug"). The program allows you to conveniently enter text, convert it, and copy the result to the clipboard with a single click.


Features

Convert text to URL-friendly format – e.g., turns Polish characters and spaces into URL-safe characters.
Copy the result to the clipboard
Automatic conversion on text change (optional)
Easy clearing of input/output fields
Multi-line input and output text boxes

How it works

Enter your text in the "Text to convert" field.
Click "Convert" to see the result in the "Text after conversion" field.
Optionally, check "Convert automatically" to enable real-time conversion as you type.
To copy the result to the clipboard, click "Copy to clipboard".
"Clear" – wipes both input and output fields.

Project Structure

UrlFriendlyConverter.cs – Main form and UI logic
Program.cs – Application entry point

Example

Input:

Zażółć gęślą jaźń! Mój test 2024.

After conversion:

zazolc-gesla-jazn-moj-test-2024

(* assuming your conversion logic replaces Polish characters and special symbols accordingly)
