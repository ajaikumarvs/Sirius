﻿using System.Windows.Forms;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;


public class ScintillaEditor : Scintilla
{



    private Scintilla scintilla;
   
    // Constructor

    public ScintillaEditor()
    {

     

        //Margins
        Margins[0].Width = 50;  // Adjust the width as needed

        // Initialize Scintilla properties and settings here
        Lexer = Lexer.Cpp;

        // Set the default style for the editor
        Styles[Style.Default].Font = "Consolas";
        Styles[Style.Default].Size = 10;
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
        Styles[Style.Cpp.Word].ForeColor = Color.DarkBlue;

        // Enable automatic syntax highlighting
        Styles[Style.Cpp.Default].Hotspot = true;
        //Styles[Style.Cpp.Default].Underline = true;
        Styles[Style.Cpp.Default].Case = StyleCase.Upper;
        Styles[Style.Cpp.Default].Visible = true;

        // Set the keywords for C language
        SetKeywords(0, "auto break case char const continue default do double else enum extern float for goto if int long register return short signed sizeof static struct switch typedef union unsigned void volatile while");





    }






}


