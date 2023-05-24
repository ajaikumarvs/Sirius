using ComponentFactory.Krypton.Toolkit;
using ScintillaNET;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace Sirius


{
    public partial class Form1 : KryptonForm
    {

        public Form1()
        {
            InitializeComponent();






            scintilla1.Styles[Style.BraceLight].BackColor = Color.LightGray;
            scintilla1.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.BraceBad].ForeColor = Color.Red;

            //KEY BINDINGS
            scintilla1.AssignCmdKey(Keys.Control | Keys.H, Command.CharLeft);
            scintilla1.AssignCmdKey(Keys.Control | Keys.J, Command.LineDown);
            scintilla1.AssignCmdKey(Keys.Control | Keys.K, Command.LineUp);
            scintilla1.AssignCmdKey(Keys.Control | Keys.L, Command.CharRight);

            //MULTIPLE SELECTIONS
            scintilla1.MultipleSelection = true;
            scintilla1.MouseSelectionRectangularSwitch = true;
            scintilla1.AdditionalSelectionTyping = true;
            scintilla1.VirtualSpaceOptions = VirtualSpace.RectangularSelection;


            //CPP PROPERTIES ----------------------------------------------
            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();

            // Configure the CPP (C#) lexer styles
            scintilla1.Styles[Style.Cpp.Default].ForeColor = Color.Silver;
            scintilla1.Styles[Style.Cpp.Comment].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintilla1.Styles[Style.Cpp.CommentLine].ForeColor = Color.FromArgb(0, 128, 0); // Green
            scintilla1.Styles[Style.Cpp.CommentLineDoc].ForeColor = Color.FromArgb(128, 128, 128); // Gray
            scintilla1.Styles[Style.Cpp.Number].ForeColor = Color.Olive;
            scintilla1.Styles[Style.Cpp.Word].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Cpp.Word2].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Cpp.String].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintilla1.Styles[Style.Cpp.Character].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintilla1.Styles[Style.Cpp.Verbatim].ForeColor = Color.FromArgb(163, 21, 21); // Red
            scintilla1.Styles[Style.Cpp.StringEol].BackColor = Color.Pink;
            scintilla1.Styles[Style.Cpp.Operator].ForeColor = Color.Purple;
            scintilla1.Styles[Style.Cpp.Preprocessor].ForeColor = Color.Maroon;
            scintilla1.Lexer = Lexer.Cpp;

            // Set the keywords
            scintilla1.SetKeywords(0, "abstract as base break case catch checked continue default delegate do else event explicit extern false finally fixed for foreach goto if implicit in interface internal is lock namespace new null object operator out override params private protected public readonly ref return sealed sizeof stackalloc switch this throw true try typeof unchecked unsafe using virtual while");
            scintilla1.SetKeywords(1, "bool byte char class const decimal double enum float int long sbyte short static string struct uint ulong ushort void");

            //END

            //CPP CODE FOLDING START -----------------------------------------------------------------------------------
            // Instruct the lexer to calculate folding
            scintilla1.SetProperty("fold", "1");
            scintilla1.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            scintilla1.Margins[2].Type = MarginType.Symbol;
            scintilla1.Margins[2].Mask = Marker.MaskFolders;
            scintilla1.Margins[2].Sensitive = true;
            scintilla1.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla1.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla1.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla1.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla1.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla1.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla1.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla1.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla1.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);
            //CPP CODE FOLDING END ------------------------------------------------------------------------------------------





            //LUA PROPERTIES -----------------------------------------------
            var alphaChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var numericChars = "0123456789";
            var accentedChars = "ŠšŒœŸÿÀàÁáÂâÃãÄäÅåÆæÇçÈèÉéÊêËëÌìÍíÎîÏïÐðÑñÒòÓóÔôÕõÖØøÙùÚúÛûÜüÝýÞþßö";

            // Configuring the default style with properties
            // we have common to every lexer style saves time.
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();

            // Configure the Lua lexer styles
            scintilla1.Styles[Style.Lua.Default].ForeColor = Color.Silver;
            scintilla1.Styles[Style.Lua.Comment].ForeColor = Color.Green;
            scintilla1.Styles[Style.Lua.CommentLine].ForeColor = Color.Green;
            scintilla1.Styles[Style.Lua.Number].ForeColor = Color.Olive;
            scintilla1.Styles[Style.Lua.Word].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Lua.Word2].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.Lua.Word3].ForeColor = Color.DarkSlateBlue;
            scintilla1.Styles[Style.Lua.Word4].ForeColor = Color.DarkSlateBlue;
            scintilla1.Styles[Style.Lua.String].ForeColor = Color.Red;
            scintilla1.Styles[Style.Lua.Character].ForeColor = Color.Red;
            scintilla1.Styles[Style.Lua.LiteralString].ForeColor = Color.Red;
            scintilla1.Styles[Style.Lua.StringEol].BackColor = Color.Pink;
            scintilla1.Styles[Style.Lua.Operator].ForeColor = Color.Purple;
            scintilla1.Styles[Style.Lua.Preprocessor].ForeColor = Color.Maroon;
            scintilla1.WordChars = alphaChars + numericChars + accentedChars;

            // Console.WriteLine(scintilla.DescribeKeywordSets());

            // Keywords
            scintilla1.SetKeywords(0, "and break do else elseif end for function if in local nil not or repeat return then until while" + " false true" + " goto");
            // Basic Functions
            scintilla1.SetKeywords(1, "assert collectgarbage dofile error _G getmetatable ipairs loadfile next pairs pcall print rawequal rawget rawset setmetatable tonumber tostring type _VERSION xpcall string table math coroutine io os debug" + " getfenv gcinfo load loadlib loadstring require select setfenv unpack _LOADED LUA_PATH _REQUIREDNAME package rawlen package bit32 utf8 _ENV");
            // String Manipulation & Mathematical
            scintilla1.SetKeywords(2, "string.byte string.char string.dump string.find string.format string.gsub string.len string.lower string.rep string.sub string.upper table.concat table.insert table.remove table.sort math.abs math.acos math.asin math.atan math.atan2 math.ceil math.cos math.deg math.exp math.floor math.frexp math.ldexp math.log math.max math.min math.pi math.pow math.rad math.random math.randomseed math.sin math.sqrt math.tan" + " string.gfind string.gmatch string.match string.reverse string.pack string.packsize string.unpack table.foreach table.foreachi table.getn table.setn table.maxn table.pack table.unpack table.move math.cosh math.fmod math.huge math.log10 math.modf math.mod math.sinh math.tanh math.maxinteger math.mininteger math.tointeger math.type math.ult" + " bit32.arshift bit32.band bit32.bnot bit32.bor bit32.btest bit32.bxor bit32.extract bit32.replace bit32.lrotate bit32.lshift bit32.rrotate bit32.rshift" + " utf8.char utf8.charpattern utf8.codes utf8.codepoint utf8.len utf8.offset");
            // Input and Output Facilities and System Facilities
            scintilla1.SetKeywords(3, "coroutine.create coroutine.resume coroutine.status coroutine.wrap coroutine.yield io.close io.flush io.input io.lines io.open io.output io.read io.tmpfile io.type io.write io.stdin io.stdout io.stderr os.clock os.date os.difftime os.execute os.exit os.getenv os.remove os.rename os.setlocale os.time os.tmpname" + " coroutine.isyieldable coroutine.running io.popen module package.loaders package.seeall package.config package.searchers package.searchpath" + " require package.cpath package.loaded package.loadlib package.path package.preload");

            // Instruct the lexer to calculate folding
            scintilla1.SetProperty("fold", "1");
            scintilla1.SetProperty("fold.compact", "1");

            // Configure a margin to display folding symbols
            scintilla1.Margins[2].Type = MarginType.Symbol;
            scintilla1.Margins[2].Mask = Marker.MaskFolders;
            scintilla1.Margins[2].Sensitive = true;
            scintilla1.Margins[2].Width = 20;

            // Set colors for all folding markers
            for (int i = 25; i <= 31; i++)
            {
                scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Configure folding markers with respective symbols
            scintilla1.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla1.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla1.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla1.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla1.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla1.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla1.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla1.AutomaticFold = (AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change);

            //END OF LUA PROPERITES ------------------------------------------


            //XML PROPERTIES ----------------------------------------------------------------------------------------------
            // Reset the styles
            scintilla1.StyleResetDefault();
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();

            // Set the XML Lexer
            scintilla1.Lexer = Lexer.Xml;

            // Show line numbers
            scintilla1.Margins[0].Width = 20;

            // Enable folding
            scintilla1.SetProperty("fold", "1");
            scintilla1.SetProperty("fold.compact", "1");
            scintilla1.SetProperty("fold.html", "1");

            // Use Margin 2 for fold markers
            scintilla1.Margins[2].Type = MarginType.Symbol;
            scintilla1.Margins[2].Mask = Marker.MaskFolders;
            scintilla1.Margins[2].Sensitive = true;
            scintilla1.Margins[2].Width = 20;

            // Reset folder markers
            for (int i = Marker.FolderEnd; i <= Marker.FolderOpen; i++)
            {
                scintilla1.Markers[i].SetForeColor(SystemColors.ControlLightLight);
                scintilla1.Markers[i].SetBackColor(SystemColors.ControlDark);
            }

            // Style the folder markers
            scintilla1.Markers[Marker.Folder].Symbol = MarkerSymbol.BoxPlus;
            scintilla1.Markers[Marker.Folder].SetBackColor(SystemColors.ControlText);
            scintilla1.Markers[Marker.FolderOpen].Symbol = MarkerSymbol.BoxMinus;
            scintilla1.Markers[Marker.FolderEnd].Symbol = MarkerSymbol.BoxPlusConnected;
            scintilla1.Markers[Marker.FolderEnd].SetBackColor(SystemColors.ControlText);
            scintilla1.Markers[Marker.FolderMidTail].Symbol = MarkerSymbol.TCorner;
            scintilla1.Markers[Marker.FolderOpenMid].Symbol = MarkerSymbol.BoxMinusConnected;
            scintilla1.Markers[Marker.FolderSub].Symbol = MarkerSymbol.VLine;
            scintilla1.Markers[Marker.FolderTail].Symbol = MarkerSymbol.LCorner;

            // Enable automatic folding
            scintilla1.AutomaticFold = AutomaticFold.Show | AutomaticFold.Click | AutomaticFold.Change;

            // Set the Styles
            scintilla1.StyleResetDefault();
            // I like fixed font for XML
            scintilla1.Styles[Style.Default].Font = "Consolas";
            scintilla1.Styles[Style.Default].Size = 10;
            scintilla1.StyleClearAll();
            scintilla1.Styles[Style.Xml.Attribute].ForeColor = Color.Red;
            scintilla1.Styles[Style.Xml.Entity].ForeColor = Color.Red;
            scintilla1.Styles[Style.Xml.Comment].ForeColor = Color.Green;
            scintilla1.Styles[Style.Xml.Tag].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Xml.TagEnd].ForeColor = Color.Blue;
            scintilla1.Styles[Style.Xml.DoubleString].ForeColor = Color.DeepPink;
            scintilla1.Styles[Style.Xml.SingleString].ForeColor = Color.DeepPink;
            //END OF XML PROPERTIES ---------------------------------------------------------------------------------------


        }
        private const int BOOKMARK_MARGIN = 1; // Conventionally the symbol margin
        private const int BOOKMARK_MARKER = 3; // Arbitrary. Any valid index would work.
        private void Form1_Load(object sender, EventArgs e)
        {
            scintilla1.Lexer = Lexer.Xml;
            toolStripComboBox1.Text = scintilla1.LexerLanguage.ToString();










            /*
            //MARKERS AND BOOKMARKING -------------------------------------------------
            var margin = scintilla1.Margins[BOOKMARK_MARGIN];
            margin.Width = 16;
            margin.Sensitive = true;
            margin.Type = MarginType.Symbol;
            margin.Mask = Marker.MaskAll;
            margin.Cursor = MarginCursor.Arrow;

            var marker = scintilla1.Markers[BOOKMARK_MARKER];
            marker.Symbol = MarkerSymbol.Bookmark;
            marker.SetBackColor(Color.DeepSkyBlue);
            marker.SetForeColor(Color.Black);

            
            scintilla1.MarginClick += Scintilla1_MarginClick;

              */


        }


        private void Scintilla1_MarginClick(object? sender, MarginClickEventArgs e)
        {
            throw new NotImplementedException();
        }

        private int maxLineNumberCharLength;
        private void scintilla1_TextChanged(object sender, EventArgs e)
        {
            var length = scintilla1.TextLength.ToString();

            toolStripLabel1.Text = "Char: " + scintilla1.TextLength.ToString();
            toolStripLabel2.Text = "Line: " + scintilla1.Lines.Count.ToString();
            toolStripLabel3.Text = "Col: " + scintilla1.EdgeColumn.ToString();
            toolStripLabel7.Text = scintilla1.Styles[Style.Cpp.String].Font.ToString(); //Getting Font Name
            toolStripLabel10.Text = Convert.ToInt32(length) / 1000 + " KB";
            label1.Text = scintilla1.Font.Name;


            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = scintilla1.Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            scintilla1.Margins[0].Width = scintilla1.TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;


        }

        private void Form1_Changed(object sender, EventArgs e)
        {
            toolStripLabel4.Text = this.Height.ToString();
            toolStripLabel6.Text = this.Width.ToString();
        }



        private void cliplistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void TrackClipboardChanges_EventHandler(object sender, EventArgs e)
        {
            cliplistbox.Items.Add(Clipboard.GetText());
        }



        private void button7_Click(object sender, EventArgs e)
        {



        }

        //AUTOCOMPLETION (SCINTILLA CHARACTER ADDED EVENT)
        private void scintilla1_CharAdded(object sender, CharAddedEventArgs e)
        {
            
            
                // Find the word start
                var currentPos = scintilla1.CurrentPosition;
                var wordStartPos = scintilla1.WordStartPosition(currentPos, true);

                // Display the autocompletion list
                var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
                if (scintilla1.Lexer == Lexer.Cpp)
                {

                    {
                        if (!scintilla1.AutoCActive)
                            /*Cpp Keywords */
                            scintilla1.AutoCShow(lenEntered, "alignas alignof and and_eq asm auto bitand bitor bool break case catch char char8_t char16_t char32_t class compl concept const constexpr const_cast continue decltype default delete do double dynamic_cast else enum explicit export extern false float for friend goto if include inline int long mutable namespace new noexcept not not_eq nullptr operator or or_eq private protected public register reinterpret_cast requires return short signed sizeof static static_assert static_cast struct switch synchronized template this thread_local throw true try typedef typeid typename union unsigned using virtual void volatile wchar_t while xor xor_eq ");

                        /*Cpp Headers */
                        scintilla1.AutoCShow(lenEntered, "algorithm array atomic bitset cassert cccomplex cctype cerrno cfenv cfloat cintclimits ciso646 climits clocale clocale climits cmath csetjmp csignal cstdalign cstdarg cstdbool cstddef cstdint cstdio cstdlib cstring ctime cuchar cwchar cwctype cxxabi cxxscope exception fenv functional future initializer_list iomanip ios iosfwd iostream istream iterator limits list locale map memory mutex new numeric ostream queue random ratio regex set shared_mutex sstream stack stdalign stdarg stdatomic stdbool stddef stdexcept stdint stdio stdlib stdnoreturn stdstring stdtype_traits system_error tgmath thread tuple typeindex typeinfo type_traits unordered_map unordered_set utility valarray vector version");
                        //scintilla1.AutoCShow(lenEntered, "");
                    }
                }

            if( scintilla1.Lexer == Lexer.Xml)
            {
                
                {
                    if (!scintilla1.AutoCActive)
                        /*XML Elements */
                        scintilla1.AutoCShow(lenEntered, "<xml> <element> <attribute> <value> <data> <text> <comment> <cdata> <root> <body> <head> <title> <link> <image> <table> <row> <column> <list> <item> <namespace> <schema> <document> <header> <footer> <section> <paragraph> <emphasis> <strong> <code> <quote> <anchor> <url> <date> <time>");
                    /*XML Attributes */
                    //scintilla1.AutoCShow(lenEntered, "id name value type src href width height style class target rel required min max pattern placeholder checked disabled readonly selected");                    
                    //scintilla1.AutoCShow(lenEntered, "</xml> </element> </attribute> </value> </data> </text> </comment> </cdata> </root> </body> </head> </title> </link> </image> </table> </row> </column> </list> </item> </namespace> </schema> </document> </header> </footer> </section> </paragraph> </emphasis> </strong> </code> </quote> </anchor> </url> </date> </time>");
                }


            }
           

            
           
        }

        //BRACE MATCHING -------------------------------------------------------------------------------------------------------
        int lastCaretPos = 0;

        private void form_Load(object sender, EventArgs e)
        {
            scintilla1.IndentationGuides = IndentView.LookBoth;
            scintilla1.Styles[Style.BraceLight].BackColor = Color.LightGray;
            scintilla1.Styles[Style.BraceLight].ForeColor = Color.BlueViolet;
            scintilla1.Styles[Style.BraceBad].ForeColor = Color.Red;
        }

        private static bool IsBrace(int c)
        {
            switch (c)
            {
                case '(':
                case ')':
                case '[':
                case ']':
                case '{':
                case '}':
                case '<':
                case '>':
                    return true;
            }

            return false;
        }


        private void scintilla_UpdateUI(object sender, UpdateUIEventArgs e)
        {
            // Has the caret changed position?
            var caretPos = scintilla1.CurrentPosition;
            if (lastCaretPos != caretPos)
            {
                lastCaretPos = caretPos;
                var bracePos1 = -1;
                var bracePos2 = -1;

                // Is there a brace to the left or right?
                if (caretPos > 0 && IsBrace(scintilla1.GetCharAt(caretPos - 1)))
                    bracePos1 = (caretPos - 1);
                else if (IsBrace(scintilla1.GetCharAt(caretPos)))
                    bracePos1 = caretPos;

                if (bracePos1 >= 0)
                {
                    // Find the matching brace
                    bracePos2 = scintilla1.BraceMatch(bracePos1);
                    if (bracePos2 == Scintilla.InvalidPosition)
                    {
                        scintilla1.BraceBadLight(bracePos1);
                        scintilla1.HighlightGuide = 0;
                    }
                    else
                    {
                        scintilla1.BraceHighlight(bracePos1, bracePos2);
                        scintilla1.HighlightGuide = scintilla1.GetColumn(bracePos1);
                    }
                }
                else
                {
                    // Turn off brace matching
                    scintilla1.BraceHighlight(Scintilla.InvalidPosition, Scintilla.InvalidPosition);
                    scintilla1.HighlightGuide = 0;
                }
            }


            //CURSOR POSITION INDICATOR --------------------------------------------------------------------------------
            if ((e.Change & UpdateChange.Selection) > 0)
            {
                // The caret/selection changed
                var currentPos = scintilla1.CurrentPosition;
                var anchorPos = scintilla1.AnchorPosition;
                toolStripLabel11.Text = "Ch: " + currentPos + " Sel: " + Math.Abs(anchorPos - currentPos);

            }
            //END OF CURSOR POSITION INDICATOR ----------------------------------------------------------------------------

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            HighlightWord(textBox1.Text);
        }
        //FIND AND HIGHLIGHT ------------------------------------------------------------------
        private void HighlightWord(string text)
        {
            if (string.IsNullOrEmpty(text))
                return;

            // Indicators 0-7 could be in use by a lexer
            // so we'll use indicator 8 to highlight words.
            const int NUM = 8;

            // Remove all uses of our indicator
            scintilla1.IndicatorCurrent = NUM;
            scintilla1.IndicatorClearRange(0, scintilla1.TextLength);

            // Update indicator appearance
            scintilla1.Indicators[NUM].Style = IndicatorStyle.StraightBox;
            scintilla1.Indicators[NUM].Under = true;
            scintilla1.Indicators[NUM].ForeColor = Color.OrangeRed;
            scintilla1.Indicators[NUM].OutlineAlpha = 50;
            scintilla1.Indicators[NUM].Alpha = 30;

            // Search the document
            scintilla1.TargetStart = 0;
            scintilla1.TargetEnd = scintilla1.TextLength;
            scintilla1.SearchFlags = SearchFlags.None;
            while (scintilla1.SearchInTarget(text) != -1)
            {
                // Mark the search results with the current indicator
                scintilla1.IndicatorFillRange(scintilla1.TargetStart, scintilla1.TargetEnd - scintilla1.TargetStart);

                // Search the remainder of the document
                scintilla1.TargetStart = scintilla1.TargetEnd;
                scintilla1.TargetEnd = scintilla1.TextLength;
            }
        }
        //FIND AND HIGHLIGHT END------------------------------------------------------------------
        private void button10_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomIn();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            scintilla1.ZoomOut();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            scintilla1.Zoom = 0;
        }





        /*
        //MARGIN CLICK EVENT (PART OF MARKERS AND BOOKMARKING -----------------------------------------------------
        private void scintilla_MarginClick(object sender, MarginClickEventArgs e)
        {
            if (e.Margin == BOOKMARK_MARGIN)
            {
                // Do we have a marker for this line?
                const uint mask = (1 << BOOKMARK_MARKER);
                var line = scintilla1.Lines[scintilla1.LineFromPosition(e.Position)];
                if ((line.MarkerGet() & mask) > 0)
                {
                    // Remove existing bookmark
                    line.MarkerDelete(BOOKMARK_MARKER);
                }
                else
                {
                    // Add bookmark
                    line.MarkerAdd(BOOKMARK_MARKER);
                }
            }
        }
        //END OF MARGIN CLICK EVENT -----------------------------------------------------------------------------------------
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            var line = scintilla1.LineFromPosition(scintilla1.CurrentPosition);
            var prevLine = scintilla1.Lines[--line].MarkerPrevious(1 << BOOKMARK_MARKER);
            if (prevLine != -1)
                scintilla1.Lines[prevLine].Goto();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            var line = scintilla1.LineFromPosition(scintilla1.CurrentPosition);
            var nextLine = scintilla1.Lines[++line].MarkerNext(1 << BOOKMARK_MARKER);
            if (nextLine != -1)
                scintilla1.Lines[nextLine].Goto();
        }
        //END OF MARGIN CLICK MODULE --------------------------------------------------------------------------------
        */
    }

}

