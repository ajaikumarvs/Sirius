using System.Windows.Forms;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;


public class ScintillaEditor : Scintilla
{



    private Scintilla scintilla;
    private string[] cKeywords = { "if", "else", "while", "for", /*...add more keywords...*/ };

    // Constructor

    public ScintillaEditor()
    {

     
       
        //Margins
        Margins[0].Width = 50;  // Adjust the width as needed

        // Initialize Scintilla properties and settings here
   

        // Set the default style for the editor
        Styles[Style.Default].Font = "Consolas";
        Styles[Style.Default].Size = 12;
        Styles[Style.Default].ForeColor = Color.Black;
        Styles[Style.Default].BackColor = Color.White;

        // Configure styles for C language elements
        Styles[Style.Cpp.Comment].ForeColor = Color.Green;
        Styles[Style.Cpp.CommentLine].ForeColor = Color.Green;
        Styles[Style.Cpp.CommentDoc].ForeColor = Color.Green;
        Styles[Style.Cpp.Number].ForeColor = Color.Blue;
        Styles[Style.Cpp.String].ForeColor = Color.Red;
        Styles[Style.Cpp.Character].ForeColor = Color.Red;
        Styles[Style.Cpp.Preprocessor].ForeColor = Color.Gray;
        Styles[Style.Cpp.Word].ForeColor = Color.BlueViolet;
        Styles[Style.Cpp.Operator].ForeColor = Color.Violet;

        

        // Enable automatic syntax highlighting
        Styles[Style.Cpp.Default].Hotspot = true;
        //Styles[Style.Cpp.Default].Underline = true;
        //Styles[Style.Cpp.Default].Case = StyleCase.Upper;
        Styles[Style.Cpp.Default].Visible = true;


        //Style configuration for HTML language elements

        // Configure styles for HTML tags
        Styles[Style.Html.Tag].ForeColor = Color.Blue;
        // Set up HTML keyword styling
        Styles[Style.Html.Default].ForeColor = Color.Black; // Default text color
        Styles[Style.Html.Tag].ForeColor = Color.Blue; // Tag color
        Styles[Style.Html.Attribute].ForeColor = Color.Red; // Attribute color
        Styles[Style.Html.Comment].ForeColor = Color.Green; // Comment color
        Styles[Style.Html.DoubleString].ForeColor = Color.DarkRed; // Double-quoted string color
        Styles[Style.Html.SingleString].ForeColor = Color.DarkRed; // Single-quoted string color

        

        // Configure styles for HTML attributes
        Styles[Style.Html.Attribute].ForeColor = Color.Red;

        // Configure style for HTML comments
       Styles[Style.Html.Comment].ForeColor = Color.Green;

        // Configure style for HTML entities
        Styles[Style.Html.Entity].ForeColor = Color.Purple;

        // Configure style for HTML double-quoted strings
        Styles[Style.Html.DoubleString].ForeColor = Color.DarkRed;

        // Configure style for HTML single-quoted strings
        Styles[Style.Html.SingleString].ForeColor = Color.DarkRed;

        // Configure style for HTML numbers
        Styles[Style.Html.Number].ForeColor = Color.DarkBlue;
  
    }






}



